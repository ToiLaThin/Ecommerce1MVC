using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.EntityFrameworkCore;
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
            OrderModel orderToChange = _db.Orders.Where(o => o.OrderId == orderId).First();
            orderToChange.OrderStatus = 2;
            _db.SaveChanges();
        }

        public void changeStatusToInValid(int orderId)
        {
            OrderModel orderToChange = _db.Orders.Where(o => o.OrderId == orderId).First();
            orderToChange.OrderStatus = -1;
            _db.SaveChanges();
        }

        public void changeStatusToValid(int orderId)
        {
            OrderModel orderToChange = _db.Orders.Where(o => o.OrderId == orderId).First();
            orderToChange.OrderStatus = 1;
            _db.SaveChanges();
        }

        public List<OrderModel> findAllCheckOutedOfUser(int accountId)
        {
            return _db.Orders.Where(o => o.OrderStatus == 2 && o.AccountId == accountId).ToList();
        }

        public List<OrderModel> findAllInValid()
        {
            return _db.Orders.Where(o => o.OrderStatus == -1).ToList();
        }

        public List<OrderModel> findAllInValidOfUser(int accountId)
        {
            return _db.Orders.Where(o => o.OrderStatus == -1 && o.AccountId == accountId).ToList();
        }

        public List<OrderModel> findAllValid()
        {
            return _db.Orders.Where(o => o.OrderStatus == 1).ToList();

        }

        public List<OrderModel> findAllValidOfUser(int accountId)
        {
            return _db.Orders.Where(o => o.OrderStatus == 1 && o.AccountId == accountId).ToList();
        }

        public List<OrderModel> findAllWaiting()
        {
            return _db.Orders.Where(o => o.OrderStatus == 0).ToList();
        }

        public List<OrderModel> findAllWaitingOfUser(int accountId)
        {
            return _db.Orders.Where(o => o.OrderStatus == 0 && o.AccountId == accountId).ToList();
        }

        public int findOrderId(int accountId, string phoneNumber, string address)
        {
            return _db.Orders.Where(o => o.AccountId == accountId && o.OrderPhone == phoneNumber && o.OrderAddress == address).OrderByDescending(o => o.OrderId).Select(o => o.OrderId).First();
        }

        public void insertNewOrder(OrderModel order)
        {
            try
            {
                _db.Orders.Add(order);
                _db.SaveChanges();
                //Lỗi
                //int orderInsertedCount = _db.Database.ExecuteSqlInterpolated($"Insert Into Order(id_Order_Account,orderBuyDate,orderStatus,orderPhone,orderAddress,orderTotalPrice) Values({order.AccountId},'{order.OrderBuyDate}',0,'{order.OrderPhone}','{order.OrderAddress}',{order.OrderTotalPrice})");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
