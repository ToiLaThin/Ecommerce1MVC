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
    public class OrderItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        ProductDAOImpl productDAOImpl;
        CategoryDAOImpl categoryDAOImpl;
        WishListDAOImpl wishListDAOImpl;
        AccountDAOImpl accountDAOImpl;
        ReviewDAOImpl reviewDAOImpl;
        InventoryDAOImpl inventoryDAOImpl;
        StoreDAOImpl storeDAOImpl;
        SellerDAOImpl sellerDAOImpl;
        OrderItemDAOImpl orderItemDAOImpl;

        public OrderItemController(ApplicationDbContext db)
        {
            _db = db;
            productDAOImpl = new ProductDAOImpl(_db);
            categoryDAOImpl = new CategoryDAOImpl(_db);
            accountDAOImpl = new AccountDAOImpl(_db);
            wishListDAOImpl = new WishListDAOImpl(_db);
            reviewDAOImpl = new ReviewDAOImpl(_db);
            inventoryDAOImpl = new InventoryDAOImpl(_db);
            storeDAOImpl = new StoreDAOImpl(_db);
            sellerDAOImpl = new SellerDAOImpl(_db);
            orderItemDAOImpl = new OrderItemDAOImpl(_db);
        }

        [Route("/Seller/OrderItem/List")]
        [HttpGet]
        public IActionResult ListAllOfSeller()
        {
            List<OrderItemModel> waitingOrderItems = orderItemDAOImpl.findAllWaitingOfSeller(Global.GlobalVar.SellerId);
            ViewData["WaitingOrderItems"] = waitingOrderItems;
            return View("/Views/Seller/OrderItemList.cshtml");
        }

        [Route("/Seller/OrderItem/ChangeStatus")]
        [HttpGet]
        public IActionResult ChangeStatus(int orderItemId,string status)
        {
            if (status.Equals("Valid"))
                orderItemDAOImpl.changeStatusToValid(orderItemId);
            return Redirect("/Seller/OrderItem/List");
        }
    }
}
