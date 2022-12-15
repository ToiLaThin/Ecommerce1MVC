using LearnMVC1.DAO.DAO.Impl;
using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Controllers
{
    public class ReceiptController : Controller
    {
        private readonly ApplicationDbContext _db;
        OrderDAOImpl orderDAOImpl;
        OrderItemDAOImpl orderItemDAOImpl;
        ReceiptDAOImpl receiptDAOImpl;
		ProductDAOImpl productDAOImpl;
		InventoryDAOImpl inventoryDAOImpl;

        public ReceiptController(ApplicationDbContext db)
        {
            _db = db;
            orderDAOImpl = new OrderDAOImpl(_db);
            orderItemDAOImpl = new OrderItemDAOImpl(_db);
            receiptDAOImpl = new ReceiptDAOImpl(_db);
			inventoryDAOImpl = new InventoryDAOImpl(_db);
			productDAOImpl = new ProductDAOImpl(_db);
        }

        [Route("/Common/Receipt/List")]
        [HttpGet]
        public IActionResult ListAll()
        {
            List<OrderModel> waitingOrdersOfUser = orderDAOImpl.findAllWaitingOfUser(Global.GlobalVar.AccountId);
            List<OrderModel> validOrdersOfUser = orderDAOImpl.findAllValidOfUser(Global.GlobalVar.AccountId);
            List<OrderModel> checkOutedOrdersOfUser = orderDAOImpl.findAllCheckOutedOfUser(Global.GlobalVar.AccountId);
            List<ReceiptModel> receiptsOfUser = receiptDAOImpl.findAllOfCheckOutedOrders(checkOutedOrdersOfUser);
            bool isOutOfOneProduct = false;
            if (HttpContext.Request.Query["isOutOfOneProduct"].ToString() != string.Empty)
            {
                isOutOfOneProduct = Convert.ToBoolean(HttpContext.Request.Query["isOutOfOneProduct"]);
            }
            Console.WriteLine(HttpContext.Request.Query["isOutOfOneProduct"].ToString());
            ViewData["WaitingOrdersOfUser"] = waitingOrdersOfUser;
            ViewData["ValidOrdersOfUser"] = validOrdersOfUser;
            ViewData["ReceiptsOfUser"] = receiptsOfUser;
            ViewData["IsOutOfOneProduct"] = isOutOfOneProduct;

            return View("/Views/Common/ReceiptList.cshtml");
        }
        
		[Route("/Common/Receipt/Insert")]
        [HttpGet]
        public IActionResult CheckOut(int orderId,DateTime buyDate)
        {
			//tìm tất cả cartItem thuộc về cartId
			List<OrderItemModel> orderItemsOfOrder = orderItemDAOImpl.findAllByOrderId(orderId);
			//hàm kiểm tra tất cả CartItem ko  hề có outOfProduct
			bool isOutOfOneProduct = IsOutOfOneProduct(orderItemsOfOrder);


			//cập nhật inventory nếu ko có món hàng nào thiếu số lượng
			if (!isOutOfOneProduct)
			{
				//duyệt qua từng -> lấy productId, quantity -> tính ra newAmount rồi gọi updateInventory có product đó
				foreach (OrderItemModel orderItem in orderItemsOfOrder)
				{
					int productId = orderItem.ProductId;
					int quantity = orderItem.OrderItemQuantity;

					//cập nhật revenue của sản phẩm cộng thêm quantity
					ProductModel productToEdit = productDAOImpl.find(productId);
					int currProductRevenue = productToEdit.ProductRevenue;
					productToEdit.ProductRevenue = currProductRevenue + quantity;
					productDAOImpl.editProduct(productToEdit);

					int productAmountInInventory = inventoryDAOImpl.findAmount(productId);
					int newProductAmountInInventory = productAmountInInventory - quantity;
					//đã kiểm tra
					inventoryDAOImpl.updateInventory(productId, newProductAmountInInventory);
                    Console.WriteLine(inventoryDAOImpl.findAmount(productId));
					ReceiptModel receiptToInsert = new ReceiptModel();
					receiptToInsert.ReceiptReleaseDate = buyDate;
					receiptToInsert.OrderId = orderId;

					receiptDAOImpl.insertReceipt(receiptToInsert);
					orderDAOImpl.changeStatusToCheckedOut(orderId);
				}
				return Redirect("/Common/Receipt/List");
			}
			else
			{
				//ko thêm id 
				//ko thêm hóa đơn
				//action này ở trên
				return Redirect("/Common/Receipt/List?isOutOfOneProduct=true");

			}
		}

		//multiple route for one action
		[Route("/Common/Receipt/Detail")]
		[Route("/Common/Order/Detail")]
		[HttpGet]
		public IActionResult ReviewDetail(int receiptId, int orderId)
		{
			ReceiptModel receipt = receiptDAOImpl.find(receiptId);
			DateTime releaseDate = receipt.ReceiptReleaseDate;
			List<OrderItemModel> orderItems = orderItemDAOImpl.findAllByOrderId(orderId);
			ViewData["ReceiptReleaseDate"] = releaseDate;
			return View("/Views/Common/ReceiptDetail.cshtml",orderItems);
		}
		#region Util Methods
		private bool IsOutOfOneProduct(List<OrderItemModel> orderItemsOfOrder)
		{
			bool isOutOfOneProduct = false;
			foreach (OrderItemModel orderItem in orderItemsOfOrder)
			{
				//có include product model trong query
				int productId = orderItem.OrderItemProduct.ProductId;
				int quantity = orderItem.OrderItemQuantity;
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
