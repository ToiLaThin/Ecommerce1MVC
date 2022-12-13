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
    public class WishListController : Controller
    {
        private readonly ApplicationDbContext _db;
        WishListDAOImpl wishListDAOImpl;
        ProductDAOImpl productDAOImpl;

        public WishListController(ApplicationDbContext db)
        {
            _db = db;
            wishListDAOImpl = new WishListDAOImpl(_db);
            productDAOImpl = new ProductDAOImpl(_db);
        }

        [Route("/Common/WishList/Insert")]
        [HttpGet]
        public IActionResult Insert(int productId, int accountId)
        {
            wishListDAOImpl.insertToWishList(productId, accountId);
            return Redirect("/Common/Product/List");
        }

        [Route("/Common/WishList/Delete")]
        [HttpGet]
        public IActionResult Delete()
        {
            int productId = Convert.ToInt32(Request.Query["productId"]);
            int accountId = Convert.ToInt32(Request.Query["accountId"]);
            wishListDAOImpl.deleteFromWishList(productId, accountId);
            return Redirect("/Common/Product/List");
        }

        [Route("/Common/WishList/List")]
        [HttpGet]
        public IActionResult ListAll()
        {
            int accountId = Convert.ToInt32(Request.Query["accountId"]);
            List<int> productIdList = wishListDAOImpl.findAllProductId(accountId);
            List<ProductModel> products = new List<ProductModel>();
            foreach(int productId in productIdList)
            {
                products.Add(productDAOImpl.find(productId));
            }
            ViewData["AccountId"] = accountId;
            return View("/Views/Common/WishList.cshtml",products);
        }
    }
}
