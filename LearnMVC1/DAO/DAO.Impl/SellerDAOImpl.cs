using LearnMVC1.Models.EntityFramwork;
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
            throw new NotImplementedException();
        }

        public int findStoreId(int sellerId)
        {
            throw new NotImplementedException();
        }

        public void insertSeller(string sellerName, int storeId)
        {
            throw new NotImplementedException();
        }
    }
}
