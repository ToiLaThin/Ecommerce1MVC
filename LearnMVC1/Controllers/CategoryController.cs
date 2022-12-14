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
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        CategoryDAOImpl categoryDAOImpl;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
            categoryDAOImpl = new CategoryDAOImpl(_db);
        }

        [Route("/Admin/Category/List")]
        [HttpGet]
        public IActionResult ListAll()
        {
            List<CategoryModel> categories = categoryDAOImpl.findAll();
            return View("/Views/Admin/CategoryList.cshtml",categories);
        }

        [Route("/Admin/Category/Insert")]
        [HttpGet]
        public IActionResult InsertGet()
        {
            return View("/Views/Admin/CategoryInsert.cshtml");
        }

        [Route("/Admin/Category/Insert")]
        [HttpPost]
        public IActionResult InsertPost()
        {
            CategoryModel category = new CategoryModel();
            category.CategoryName = HttpContext.Request.Form["categoryName"];
            category.CategoryImage = HttpContext.Request.Form["categoryImage"];

            categoryDAOImpl.insertCategory(category);
            return Redirect("/Admin/Category/List");
        }

        [Route("/Admin/Category/Update")]
        [HttpGet]
        public IActionResult UpdateGet(int categoryId)
        {
            CategoryModel category = categoryDAOImpl.find(categoryId);
            return View("/Views/Admin/CategoryUpdate.cshtml", category);
        }

        [Route("/Admin/Category/Update")]
        [HttpPost]
        public IActionResult UpdatePost()
        {
            CategoryModel category = new CategoryModel();
            category.CategoryId = Convert.ToInt32(HttpContext.Request.Form["categoryId"]);
            category.CategoryName = HttpContext.Request.Form["categoryName"];
            category.CategoryImage = HttpContext.Request.Form["categoryImage"];

            categoryDAOImpl.editCategory(category);
            return Redirect("/Admin/Category/List");
        }
    }
}
