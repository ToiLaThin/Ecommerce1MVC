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
    public class StoreController : Controller
    {
        private readonly ApplicationDbContext _db;
        StoreDAOImpl storeDAOImpl;

        public StoreController(ApplicationDbContext db)
        {
            _db = db;
            storeDAOImpl = new StoreDAOImpl(_db);
        }

        [Route("/Common/Store/List")]
        [HttpGet]
        public IActionResult ListAll()
        {
            List<StoreModel> stores = storeDAOImpl.findAll();            
            return View("/Views/Common/StoreList.cshtml",stores);
        }

        [Route("/Common/Store/Search")]
        [HttpPost]
        public IActionResult Search()
        {
            string searchPhrase = HttpContext.Request.Form["searchPhrase"];
            List<StoreModel> storesSearched = storeDAOImpl.findBySearch(searchPhrase);
            return View("/Views/Common/StoreList.cshtml", storesSearched);
        }
    }
}
