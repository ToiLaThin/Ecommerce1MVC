using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO.DAO.Impl
{
    public class OrderDAOImpl : IOrderDAO
    {
        ApplicationDbContext _db;
        public OrderDAOImpl(ApplicationDbContext db)
        {
            _db = db;
        }
        public void changeStatusToCheckedOut(int orderId)
        {
            throw new NotImplementedException();
        }

        public void changeStatusToInValid(int orderId)
        {
            throw new NotImplementedException();
        }

        public void changeStatusToValid(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<OrderModel> findAllCheckOutedOfUser(int accountId)
        {
            throw new NotImplementedException();
        }

        public List<OrderModel> findAllInValid()
        {
            throw new NotImplementedException();
        }

        public List<OrderModel> findAllInValidOfUser(int accountId)
        {
            throw new NotImplementedException();
        }

        public List<OrderModel> findAllValid()
        {
            throw new NotImplementedException();
        }

        public List<OrderModel> findAllValidOfUser(int accountId)
        {
            throw new NotImplementedException();
        }

        public List<OrderModel> findAllWaiting()
        {
            throw new NotImplementedException();
        }

        public List<OrderModel> findAllWaitingOfUser(int accountId)
        {
            throw new NotImplementedException();
        }

        public int findOrderId(int accountId, string phoneNumber, string address)
        {
            throw new NotImplementedException();
        }

        public void insertNewOrder(OrderModel order)
        {
            throw new NotImplementedException();
        }
    }
}
