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
			ReceiptModel receiptToInsert = new ReceiptModel();
			receiptToInsert.ReceiptReleaseDate = buyDate;
			receiptToInsert.OrderId = orderId;

			receiptDAOImpl.insertReceipt(receiptToInsert);
			orderDAOImpl.changeStatusToCheckedOut(orderId);
			return Redirect("/Common/Receipt/List");
            //ko dc sử dụng vì số lượng sản phẩm đã bị trừ từ khi order
			//return Redirect("/Common/Receipt/List?isOutOfOneProduct=true");
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
		
	}
}
