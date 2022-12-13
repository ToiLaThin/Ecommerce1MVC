﻿using LearnMVC1.DAO.DAO.Impl;
using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        ProductDAOImpl productDAOImpl;
        CategoryDAOImpl categoryDAOImpl;
        WishListDAOImpl wishListDAOImpl;
        AccountDAOImpl accountDAOImpl;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
            productDAOImpl = new ProductDAOImpl(_db);
            categoryDAOImpl = new CategoryDAOImpl(_db);
            accountDAOImpl = new AccountDAOImpl(_db);
            wishListDAOImpl = new WishListDAOImpl(_db);
        }

        [Route("/Common/Product/List")]
        public IActionResult ListAll()
        {
            var products = productDAOImpl.findAll();
            var categories = categoryDAOImpl.findAll();

            string username = HttpContext.Session.GetString("accountUserName");
            if (username != null)
            {
                int accountId = accountDAOImpl.findAccountId(username);
                ViewData["AccountId"] = accountId;

                foreach (ProductModel product in products)
                {
                    if (wishListDAOImpl.isInWishList(product.ProductId, accountId))
                        product.IsWished = true;
                    else
                        product.IsWished = false;
                }
            }
            ViewData["Products"] = products;
            ViewData["Categories"] = categories;
            return View("/Views/Common/ProductList.cshtml");
        }

        [Route("/Common/Product/Detail")]
        public IActionResult Detail(int productId)
        {
            var product = productDAOImpl.find(productId);
            ViewData["Product"] = product;
            return View("Views/Common/ProductDetail.cshtml");
        }

        [Route("/Common/Product/Search")]
        [HttpPost]
        public IActionResult Search()
        {
            if(ModelState.IsValid)
            {
                string searchPhrase = Request.Form["searchPhrase"];
                var productsSearched = productDAOImpl.findBySearch(searchPhrase);
                ViewData["Products"] = productsSearched;

                string username = HttpContext.Session.GetString("accountUserName");
                if (username != null)
                {
                    int accountId = accountDAOImpl.findAccountId(username);
                    ViewData["AccountId"] = accountId;

                    foreach (ProductModel product in productsSearched)
                    {
                        if (wishListDAOImpl.isInWishList(product.ProductId, accountId))
                            product.IsWished = true;
                        else
                            product.IsWished = false;
                    }
                }
            }    
            var categories = categoryDAOImpl.findAll();
            ViewData["Categories"] = categories;
            return View("/Views/Common/ProductList.cshtml");

            //boolean accountDisabled = false;
            //boolean orderSuccess = false;
            //if (req.getAttribute("accountDisabled") != null)
            //{
            //    accountDisabled = (boolean)req.getAttribute("accountDisabled");
            //}
            //if (req.getAttribute("orderSuccess") != null)
            //{
            //    orderSuccess = (boolean)req.getAttribute("orderSuccess");
            //}
            //req.setAttribute("accountDisabled", accountDisabled);
            //req.setAttribute("orderSuccess", orderSuccess);
        }

        [Route("/Common/Product/FilterByCategory")]
        [HttpGet]
        public IActionResult FilterByCategory(int categoryId,string categoryName)
        {
            List<ProductModel> productsOfCategory = productDAOImpl.findByCategory(categoryId);            
            ViewData["CategoryName"] = categoryName;
            return View("Views/Common/ProductFilterByCategory.cshtml",productsOfCategory);
        }
    }
}
