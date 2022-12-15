using LearnMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO
{
    interface IOrderItemDAO
    {
        void insertToOrder(OrderItemModel orderItem);
        List<OrderItemModel> findAllByOrderId(int orderId);
    }
}
