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
            int producUpdatedCount = _db.Database.ExecuteSqlRaw("Update Product Set productName='" + product.ProductName + "', productDescription='" + product.ProductDescription + "', productPrice=" + product.ProductPrice + ", productImage='" + product.ProductImage + "', productModifiedDate='" + product.ProductModifiedDate + "', productStatus=" + product.ProductStatus + ", id_Product_Category=" + product.CategoryId + ", productRevenue=" + product.ProductRevenue + " Where productId=" + product.ProductId);
            if (producUpdatedCount == 1)
                Console.WriteLine("Product Updated Success");
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
            return _db.Products.Where(p => p.SellerId == sellerId).ToList();
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
            return _db.Products.Where(p => p.ProductName == product.ProductName && p.ProductDescription == p.ProductDescription && p.ProductPrice == product.ProductPrice && p.ProductImage == product.ProductImage && p.ProductModifiedDate == product.ProductModifiedDate && p.SellerId == product.SellerId).Select(p => p.ProductId).First();
        }

        public void insertProduct(ProductModel product)
        {
            int producInsertedCount = _db.Database.ExecuteSqlInterpolated($"Insert Into Product(productName,productDescription,productPrice,productImage,productModifiedDate,id_Product_Seller,productStatus,id_Product_Category,productRevenue) Values({product.ProductName},{product.ProductDescription},{product.ProductPrice},{product.ProductImage},{product.ProductModifiedDate},{product.SellerId},0,{product.CategoryId},0)");
            if (producInsertedCount == 1)
                Console.WriteLine("Product Inserted Success");
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
