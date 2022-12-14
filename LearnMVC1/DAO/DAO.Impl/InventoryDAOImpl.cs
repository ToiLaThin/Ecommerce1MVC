using LearnMVC1.Models.EntityFramwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO.DAO.Impl
{
    public class InventoryDAOImpl : IInventoryDAO
    {
        ApplicationDbContext _db;
        public InventoryDAOImpl(ApplicationDbContext db)
        {
            _db = db;
        }
        public void deleteInventory(int productId, int storeId)
        {
            int inventoryDeletedCount = _db.Database.ExecuteSqlInterpolated($"Delete From Inventory Where id_Inventory_Store = {storeId} And id_Inventory_Product = {productId}");
            if (inventoryDeletedCount == 1)
                Console.WriteLine("Inventory Deleted Success");
        }

        public int findAmount(int productId)
        {
            return _db.Inventories.Where(i => i.ProductId == productId).Select(i => i.InventoryProductAmount).First();
        }

        public void insertInventory(int productId, int storeId, int amount)
        {
            int inventoryInsertedCount = _db.Database.ExecuteSqlInterpolated($"Insert Into Inventory(id_Inventory_Store,id_Inventory_Product,inventoryProductAmount) Values({storeId},{productId},{amount})");
            if (inventoryInsertedCount == 1)
                Console.WriteLine("Inventory Inserted Success");
        }

        public void updateInventory(int productId, int amount)
        {
            int inventoryUpdatedCount = _db.Database.ExecuteSqlInterpolated($"Update Inventory Set inventoryProductAmount = {amount} Where id_Inventory_Product = {productId}");
            if (inventoryUpdatedCount == 1)
                Console.WriteLine("Inventory Updated Success");
        }
    }
}
