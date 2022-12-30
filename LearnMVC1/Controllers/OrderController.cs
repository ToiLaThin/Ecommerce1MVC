using LearnMVC1.DAO.DAO.Impl;
using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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

                OrderModel orderToInsert = new OrderModel();
                orderToInsert.AccountId = accountId;
                orderToInsert.OrderBuyDate = DateTime.Now.ToLocalTime();
                orderToInsert.OrderPhone = phoneNumber;
                orderToInsert.OrderAddress = address;
                orderToInsert.OrderTotalPrice = totalPrice;
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


        #region Admin 's order actions
        [Route("/Admin/Order/List")]
        [HttpGet]
        public IActionResult List()
        {
            List<OrderModel> waitingOrders = orderDAOImpl.findAllWaiting();
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
        #endregion
    }
}
