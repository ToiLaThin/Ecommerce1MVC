using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO.DAO.Impl
{
    public class OrderItemDAOImpl : IOrderItemDAO
    {
        ApplicationDbContext _db;
        public OrderItemDAOImpl(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<OrderItemModel> findAllByOrderId(int orderId)
        {
            return _db.OrderItems.Where(o => o.OrderId == orderId).Include(o => o.OrderItemProduct).ToList();
        }

        public void insertToOrder(OrderItemModel orderItem)
        {
            int orderItemInsertedCount = _db.Database.ExecuteSqlInterpolated($"Insert Into OrderItem(orderItemQuantity,orderItemUnitPrice,id_OrderItem_Product,id_OrderItem_Order) Values({orderItem.OrderItemQuantity},{orderItem.OrderItemUnitPrice},{orderItem.ProductId},{orderItem.OrderId})");
            if (orderItemInsertedCount == 1)
                Console.WriteLine("Order Item Inserted Success");
        }
    }
}
