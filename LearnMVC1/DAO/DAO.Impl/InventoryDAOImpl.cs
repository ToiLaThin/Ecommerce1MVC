using LearnMVC1.Models.EntityFramwork;
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
            throw new NotImplementedException();
        }

        public int findAmount(int productId)
        {
            throw new NotImplementedException();
        }

        public void insertInventory(int productId, int storeId, int amount)
        {
            throw new NotImplementedException();
        }

        public void updateInventory(int productId, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
