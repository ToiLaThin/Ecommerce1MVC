using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO.DAO.Impl
{
    public class ReceiptDAOImpl : IReceiptDAO
    {
        ApplicationDbContext _db;
        public ReceiptDAOImpl(ApplicationDbContext db)
        {
            _db = db;
        }
        public ReceiptModel find(int receiptId)
        {
            throw new NotImplementedException();
        }

        public List<ReceiptModel> findAllOfCheckOutedOrders(List<OrderModel> checkOutedOrdersOfUser)
        {
            throw new NotImplementedException();
        }

        public void insertReceipt(ReceiptModel receipt)
        {
            throw new NotImplementedException();
        }
    }
}
