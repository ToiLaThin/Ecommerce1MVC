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
            return _db.Receipts.Where(r => r.ReceiptId == receiptId).First();
        }

        public List<ReceiptModel> findAllOfCheckOutedOrders(List<OrderModel> checkOutedOrdersOfUser)
        {
            List<ReceiptModel> receipts = new List<ReceiptModel>();
            foreach(OrderModel checkOutedOrderOfUser in checkOutedOrdersOfUser)
            {
                ReceiptModel receipt = _db.Receipts.Where(r => r.OrderId == checkOutedOrderOfUser.OrderId).First();
                receipts.Add(receipt);
            }
            return receipts;
        }

        public void insertReceipt(ReceiptModel receipt)
        {
            _db.Receipts.Add(receipt);
            _db.SaveChanges();
        }
    }
}
