using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO.DAO.Impl
{
    public class StoreDAOImpl : IStoreDAO
    {
        ApplicationDbContext _db;
        public StoreDAOImpl(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<StoreModel> findAll()
        {
            return _db.Stores.ToList();
        }

        public List<ProductModel> findAllProduct(int storeId)
        {
            return _db.Products.FromSqlInterpolated($"Select * From Product Inner Join Inventory on Product.productId=Inventory.id_Inventory_Product where id_Inventory_Store={storeId} ").ToList();
        }

        public List<StoreModel> findBySearch(string searchPhrase)
        {
            return _db.Stores.FromSqlRaw("Select * From Store Where storeName Like N'%" + searchPhrase + "%'").ToList();
        }

        public StoreModel findStore(int storeId)
        {
            return _db.Stores.Find(storeId);
        }

        public int findStoreId(string storeName)
        {
            return _db.Stores.Where(st => st.StoreName == storeName).Select(st => st.StoreId).First();
        }

        public void insertStore(string storeName, DateTime storeCreateDate)
        {
            int storeInsertedCount = _db.Database.ExecuteSqlInterpolated($"Insert Into Store(storeName,storeCreateDate) Values ({storeName},{storeCreateDate})");
            if (storeInsertedCount == 1)
                Console.WriteLine("Store Inserted Success");
        }
    }
}
