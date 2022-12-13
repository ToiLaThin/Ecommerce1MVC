using LearnMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO.DAO.Impl
{
    interface IAccountDAO
    {
		bool authenticateAccount(String username, String password);
		String findRoleAccount(String username, String password);
		void registerAccount(String username, String password);
		bool registerAccount(AccountModel account);
		void becomeSeller(int sellerId, String username);
		int findSellerId(String username);
		int findAccountId(String username);
		List<AccountModel> findAll();
		List<AccountModel> findAllSeller();
		List<AccountModel> findAllUser();
		AccountModel findById(int id);
		void changeStatus(int id, int status);
		void changePassword(int accountId, String password);
		void changeProfile(AccountModel account);
	}
}
