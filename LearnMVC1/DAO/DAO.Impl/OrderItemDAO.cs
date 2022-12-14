using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO.DAO.Impl
{
    public class OrderItemDAO : IOrderItemDAO
    {
        ApplicationDbContext _db;
        public OrderItemDAO(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<OrderItemModel> findAllByOrderId(int orderId)
        {
            throw new NotImplementedException();
        }

        public void insertToCart(OrderItemModel orderItem)
        {
            throw new NotImplementedException();
        }
    }
}
