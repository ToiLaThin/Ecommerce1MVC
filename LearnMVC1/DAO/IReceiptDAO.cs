using LearnMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO
{
    interface IReceiptDAO
    {
        List<ReceiptModel> findAllOfCheckOutedOrders(List<OrderModel> checkOutedOrdersOfUser);
        ReceiptModel find(int receiptId);
        void insertReceipt(ReceiptModel receipt);
    }
}
