using Ecommerce0.Global;
using LearnMVC1.DAO.DAO.Impl;
using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Stripe.BillingPortal;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _db;
        OrderDAOImpl orderDAOImpl;
        OrderItemDAOImpl orderItemDAOImpl;
        ProductDAOImpl productDAOImpl;
        InventoryDAOImpl inventoryDAOImpl;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
            orderDAOImpl = new OrderDAOImpl(_db);
            orderItemDAOImpl = new OrderItemDAOImpl(_db);
            productDAOImpl = new ProductDAOImpl(_db);
            inventoryDAOImpl = new InventoryDAOImpl(_db);
        }

        [Route("/Common/Order/Insert")]
        [HttpGet]
        public IActionResult InsertGet()
        {
            List<CartItemModel> cart = new List<CartItemModel>();
            string sessionCart = HttpContext.Session.GetString("cart");
            if (sessionCart != null)
                cart = JsonConvert.DeserializeObject<List<CartItemModel>>(sessionCart);
            return View("/Views/Common/OrderInsert.cshtml",cart);
        }

        [Route("/Common/Order/Insert")]
        [HttpPost]
        public IActionResult InsertPost()
        {
            List<CartItemModel> cart = new List<CartItemModel>();
            string sessionCart = HttpContext.Session.GetString("cart");
            if (sessionCart != null)
                cart = JsonConvert.DeserializeObject<List<CartItemModel>>(sessionCart);
            //hàm kiểm tra tất cả CartItem ko  hề có outOfProduct
            bool isOutOfOneProduct = IsOutOfOneProduct(cart);


            //cập nhật inventory nếu ko có món hàng nào thiếu số lượng
            if (!isOutOfOneProduct)
            {
                //duyệt qua từng -> lấy productId, quantity -> tính ra newAmount rồi gọi updateInventory có product đó
                foreach (CartItemModel cartItem in cart)
                {
                    int productId = cartItem.CartItemProduct.ProductId;
                    int quantity = cartItem.CartItemQuantity;

                    //cập nhật revenue của sản phẩm cộng thêm quantity
                    ProductModel productToEdit = productDAOImpl.find(productId);
                    int currProductRevenue = productToEdit.ProductRevenue;
                    productToEdit.ProductRevenue = currProductRevenue + quantity;
                    productDAOImpl.editProduct(productToEdit);

                    int productAmountInInventory = inventoryDAOImpl.findAmount(productId);
                    int newProductAmountInInventory = productAmountInInventory - quantity;
                    //đã kiểm tra
                    inventoryDAOImpl.updateInventory(productId, newProductAmountInInventory);
                }

                string phoneNumber = HttpContext.Request.Form["phoneNumber"].ToString();
                string address = HttpContext.Request.Form["address"];
                int accountId = Global.GlobalVar.AccountId;
                decimal totalPrice = Convert.ToDecimal(HttpContext.Request.Form["totalPrice"]);
                //is value of the selected checkbox input 
                string paymentMethod = HttpContext.Request.Form["payment"].ToString();

                OrderModel orderToInsert = new OrderModel();
                orderToInsert.AccountId = accountId;
                orderToInsert.OrderBuyDate = DateTime.Now.ToLocalTime();
                orderToInsert.OrderPhone = phoneNumber;
                orderToInsert.OrderAddress = address;
                orderToInsert.OrderTotalPrice = totalPrice;
                orderToInsert.OrderPaymentMethod = paymentMethod;
                orderDAOImpl.insertNewOrder(orderToInsert);

                int orderInsertedId = orderDAOImpl.findOrderId(accountId, phoneNumber, address);
                foreach (CartItemModel cartItem in cart)
                {
                    OrderItemModel orderItem = new OrderItemModel(cartItem);
                    orderItem.OrderId = orderInsertedId;
                    orderItemDAOImpl.insertToOrder(orderItem);
                }


                HttpContext.Session.Remove("cart");
                TempData["OrderSuccess"] = true;
                return Redirect("/Common/Product/List");
            }
            else
            {
                TempData["OrderSuccess"] = false;
                return Redirect("/Common/Order/Insert");
            }
        }

        [HttpGet]
        public IActionResult MomoProcessPayment(Dictionary<String, String> parameters)
        {
            int myOrderId = int.Parse(parameters["orderId"]);
            DateTime buyDate = Convert.ToDateTime(parameters["buyDate"]).ToLocalTime();

            string endpoint = "https://payment.momo.vn/v2/gateway/api/create";
            string partnerCode = "MOMOI0LX20220922";
            string accessKey = "5DuZliGMfIjEIiQs";
            string serectkey = "JREEY5yK0azGS6YJZV5LQXB2wYR9SN8J";
            string orderInfo = "Order" + myOrderId;
            string redirectUrl = "https://localhost:44334/Common/Receipt/Insert?orderId=" + myOrderId + "&buyDate=" + buyDate;
            string ipnUrl = "https://localhost:44334/Common/Receipt/Insert?orderId=" + myOrderId + "&buyDate=" + buyDate;
            string requestType = "captureWallet";

            string amount = (Convert.ToInt32(Convert.ToDecimal(parameters["payment"]) * 20000).ToString());
            string orderId = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();
            string extraData = "";

            //Before sign HMAC SHA256 signature
            string rawHash = "accessKey=" + accessKey +
                "&amount=" + amount +
                "&extraData=" + extraData +
                "&ipnUrl=" + ipnUrl +
                "&orderId=" + orderId +
                "&orderInfo=" + orderInfo +
                "&partnerCode=" + partnerCode +
                "&redirectUrl=" + redirectUrl +
                "&requestId=" + requestId +
                "&requestType=" + requestType
                ;

            MoMoSecurity crypto = new MoMoSecurity();
            //sign signature SHA256
            string signature = crypto.signSHA256(rawHash, serectkey);

            //build body json request
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "partnerName", "Test" },
                { "storeId", "MomoTestStore" },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderId },
                { "orderInfo", orderInfo },
                { "redirectUrl", redirectUrl },
                { "ipnUrl", ipnUrl },
                { "lang", "en" },
                { "extraData", extraData },
                { "requestType", requestType },
                { "signature", signature }

            };
            string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());
            Console.WriteLine(responseFromMomo);

            JObject jmessage = JObject.Parse(responseFromMomo);
            return Redirect(jmessage.GetValue("payUrl").ToString());
        }

        [HttpGet]
        public IActionResult StripeProcessPayment(Dictionary<String, String> parameters)
        {
            int myOrderId = int.Parse(parameters["orderId"]);
            DateTime buyDate = Convert.ToDateTime(parameters["buyDate"]).ToLocalTime();
            //https://localhost:44334 change to azure domain https://learnmvc120221221223621.azurewebsites.net when host
            var domain = "https://learnmvc120221221223621.azurewebsites.net";
            var options = new Stripe.Checkout.SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
                {
                  new SessionLineItemOptions
                  {
                    Quantity = 1,
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmountDecimal = Convert.ToDecimal(parameters["payment"]) * 100,
                        Currency = "USD",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = "Order" + myOrderId
                        }

                    },                  
                  },                  
                },
                Mode = "payment",
                SuccessUrl = domain + "/Common/Receipt/Insert?orderId=" + myOrderId + "&buyDate=" + buyDate,
                CancelUrl = domain + "/Common/Receipt/List",
            };
            var service = new Stripe.Checkout.SessionService();
            Stripe.Checkout.Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }


        #region Admin 's order actions
        [Route("/Admin/Order/List")]
        [HttpGet]
        public IActionResult List()
        {
            List<OrderModel> waitingOrders = orderDAOImpl.findAllWaiting();
            CheckOrderCanChangeStatus(waitingOrders);
            List<OrderModel> validOrders = orderDAOImpl.findAllValid();
            List<OrderModel> inValidOrders = orderDAOImpl.findAllInValid();

            ViewData["WaitingOrders"] = waitingOrders;
            ViewData["ValidOrders"] = validOrders;
            ViewData["InValidOrders"] = inValidOrders;
            return View("/Views/Admin/OrderList.cshtml");
        }

        [Route("/Admin/Order/Detail")]
        [HttpGet]
        public IActionResult Detail(int orderId)
        {
            List<OrderItemModel> orderItems = orderItemDAOImpl.findAllByOrderId(orderId);
            ViewData["OrderId"] = orderId;
            return View("/Views/Admin/OrderDetail.cshtml",orderItems);
        }

        [Route("/Admin/Order/ChangeStatus")]
        [HttpGet]
        public IActionResult ChangeStatus(int orderId,string status)
        {
            if (status.Equals("Valid"))
                orderDAOImpl.changeStatusToValid(orderId);
            else if (status.Equals("InValid"))
                orderDAOImpl.changeStatusToInValid(orderId);
            return Redirect("/Admin/Order/List");
        }
        #endregion

        #region Util Methods
        private bool IsOutOfOneProduct(List<CartItemModel> cartItems)
        {
            bool isOutOfOneProduct = false;
            foreach (CartItemModel cartItem in cartItems)
            {
                //có include product model trong query
                int productId = cartItem.CartItemProduct.ProductId;
                int quantity = cartItem.CartItemQuantity;
                int productAmountInInventory = inventoryDAOImpl.findAmount(productId);

                if (productAmountInInventory < quantity)
                {
                    isOutOfOneProduct = true;
                    break;
                }
            }
            return isOutOfOneProduct;
        }

        private void CheckOrderCanChangeStatus(List<OrderModel> waitingOrders)
        {
            foreach (OrderModel order in waitingOrders)
            {
                List<OrderItemModel> orderItemsOfOrder = orderItemDAOImpl.findAllByOrderId(order.OrderId);
                bool allValid = true;
                foreach (OrderItemModel orderItem in orderItemsOfOrder)
                {
                    if (orderItem.OrderItemStatus == 0)
                    {
                        allValid = false;
                        break;
                    }
                }
                if (allValid)
                {
                    order.CanChangeStatus = true;
                }
                else
                {
                    order.CanChangeStatus = false;
                }
            }
        }
        #endregion
    }
}
