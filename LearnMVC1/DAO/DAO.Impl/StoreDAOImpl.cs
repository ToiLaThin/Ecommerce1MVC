using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
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
            throw new NotImplementedException();
        }

        public List<ProductModel> findAllProduct(int storeId)
        {
            throw new NotImplementedException();
        }

        public List<StoreModel> findBySearch(string searchPhrase)
        {
            throw new NotImplementedException();
        }

        public StoreModel findStore(int storeId)
        {
            throw new NotImplementedException();
        }

        public int findStoreId(string storeName)
        {
            throw new NotImplementedException();
        }

        public void insertStore(string storeName, DateTime storeCreateDate)
        {
            throw new NotImplementedException();
        }
    }
}
