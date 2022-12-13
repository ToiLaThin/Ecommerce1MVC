using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO.DAO.Impl
{
    public class ProductDAOImpl : IProductDAO
    {
        ApplicationDbContext _db;
        public ProductDAOImpl(ApplicationDbContext db)
        {
            _db = db;
        }

        public void deleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void editProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public ProductModel find(int productId)
        {
            return _db.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public List<ProductModel> findAll()
        {
            return _db.Products.ToList();
        }

        public List<ProductModel> findAllBySellerId(int sellerId)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> findByCategory(int categoryId)
        {
            return _db.Products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductModel> findBySearch(string searchPhrase)
        {
            List<ProductModel> productsBySearch = _db.Products.FromSqlRaw("Select * From Product Where productName Like N'%" + searchPhrase + "%'").ToList();
            return productsBySearch;
        }

        public int findProductId(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public void insertProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> loadInitNine(string orderBy)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> loadNextNine(string orderBy, int skipAmount)
        {
            throw new NotImplementedException();
        }
    }
}
