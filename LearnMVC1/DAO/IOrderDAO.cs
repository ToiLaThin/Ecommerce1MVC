using LearnMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO
{
    interface IOrderDAO
    {
		List<OrderModel> findAllWaiting();
		List<OrderModel> findAllValid();
		List<OrderModel> findAllInValid();
		List<OrderModel> findAllWaitingOfUser(int accountId);
		List<OrderModel> findAllValidOfUser(int accountId);
		List<OrderModel> findAllInValidOfUser(int accountId);
		List<OrderModel> findAllCheckOutedOfUser(int accountId);
		int findOrderId(int accountId, string phoneNumber, string address);

		//khi admin duyệt hoặc không
		void changeStatusToValid(int orderId);
		void changeStatusToInValid(int orderId);
		void changeStatusToCheckedOut(int orderId);

		//tạo cart
		void insertNewOrder(OrderModel order);
	}
}
