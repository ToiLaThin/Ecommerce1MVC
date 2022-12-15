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
            int categoriesUpdatedCount = _db.Database.ExecuteSqlInterpolated($"Update Category Set categoryName=N'{category.CategoryName}',categoryImage={category.CategoryImage} Where categoryId={category.CategoryId}");
            if (categoriesUpdatedCount == 1)
                Console.WriteLine("Categories updated success");
        }

        public CategoryModel find(int categoryId)
        {
            return _db.Categories.Where(c => c.CategoryId == categoryId).First();
        }

        public List<CategoryModel> findAll()
        {
            var categories = _db.Categories.FromSqlRaw("Select * From Category").ToList();
            return categories;
        }

        public void insertCategory(CategoryModel category)
        {
            int categoriesInsertedCount = _db.Database.ExecuteSqlInterpolated($"Insert Into Category(categoryName,categoryImage,categoryStatus) Values(N'{category.CategoryName}',{category.CategoryImage},0)");
            if (categoriesInsertedCount == 1)
                Console.WriteLine("Categories inserted success");
        }
    }
}
