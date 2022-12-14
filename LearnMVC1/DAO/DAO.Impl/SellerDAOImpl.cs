using LearnMVC1.Models.EntityFramwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO.DAO.Impl
{
    public class SellerDAOImpl : ISellerDAO
    {
        ApplicationDbContext _db;
        public SellerDAOImpl(ApplicationDbContext db)
        {
            _db = db;
        }
        public int findSellerId(string sellerName)
        {
            return _db.Sellers.Where(s => s.SellerName == sellerName).Select(s => s.SellerId).First();
        }

        public int findStoreId(int sellerId)
        {
            return _db.Sellers.Where(s => s.SellerId == sellerId).Select(s => s.StoreId).First();
        }

        public void insertSeller(string sellerName, int storeId)
        {
            int sellerInsertedCount = _db.Database.ExecuteSqlInterpolated($"Insert Into Seller(sellerName,sellerStatus,id_Seller_Store) Values ({sellerName},1,{storeId})");
            if (sellerInsertedCount == 1)
                Console.WriteLine("Seller Inserted Success");
        }
    }
}
