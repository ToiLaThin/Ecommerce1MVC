using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO.DAO.Impl
{
    public class CategoryDAOImpl : ICategoryDAO
    {
        ApplicationDbContext _db;
        public CategoryDAOImpl(ApplicationDbContext db)
        {
            _db = db;
        }
        public void deleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void editCategory(CategoryModel category)
        {
            throw new NotImplementedException();
        }

        public CategoryModel find(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<CategoryModel> findAll()
        {
            var categories = _db.Categories.FromSqlRaw("Select * From Category").ToList();
            return categories;
        }

        public void insertCategory(CategoryModel category)
        {
            throw new NotImplementedException();
        }
    }
}
