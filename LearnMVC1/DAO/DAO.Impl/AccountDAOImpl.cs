using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO.DAO.Impl
{
    public class AccountDAOImpl : IAccountDAO
    {
        ApplicationDbContext _db;
        public AccountDAOImpl(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool authenticateAccount(string username, string password)
        {
            bool isValid = false;
            var accounts = _db.Accounts.Where(acc => acc.AccountUserName == username && acc.AccountPassword == password).ToList();
            if (accounts.Count == 1)
                isValid = true;
            return isValid;
        }

        public void becomeSeller(int sellerId, string username)
        {
            int accountUpdatedCount = _db.Database.ExecuteSqlInterpolated($"Update Account Set id_Account_Seller = {sellerId},id_Account_Role = 3 Where accountUserName = {username}");
            if (accountUpdatedCount == 1)
                Console.WriteLine("Account became seller Success");
        }

        public void changePassword(int accountId, string password)
        {
            int accountUpdatedCount = _db.Database.ExecuteSqlInterpolated($"Update Account Set accountPassword = {password} Where accountId = {accountId}");
            if (accountUpdatedCount == 1)
                Console.WriteLine("Password Updated Success");
        }

        public void changeProfile(AccountModel account)
        {
            int accountUpdatedCount = _db.Database.ExecuteSqlInterpolated($"Update Account Set accountFullName = {account.AccountFullName}, accountEmail = {account.AccountEmail}, accountPhone = {account.AccountPhone}, accountImage = {account.AccountImage} Where accountId = {account.AccountId}");
            if (accountUpdatedCount == 1)
                Console.WriteLine("Account Updated Success");
        }

        public void changeStatus(int id, int status)
        {
            int accountUpdatedCount = _db.Database.ExecuteSqlInterpolated($"Update Account Set accountStatus = {status} Where accountId = {id}");
            if (accountUpdatedCount == 1)
                Console.WriteLine("Status Updated Success");
        }

        public int findAccountId(string username)
        {
            //trả về IQueryable kiểu int nên chọn phần tử đầu sẽ là int
            var accountResult = _db.Accounts.FromSqlInterpolated($"Select * From Account Where accountUserName = {username}").Select(acc => acc.AccountId);
            if(accountResult.Count() > 0)
            {
                int accountId = accountResult.First();
                return accountId;
            }
            return -1;


        }

        public List<AccountModel> findAll()
        {
            return _db.Accounts.ToList();
        }

        public List<AccountModel> findAllSeller()
        {
            return _db.Accounts.Where(acc => acc.SellerId != null && acc.RoleId == 3).ToList();
        }

        public List<AccountModel> findAllUser()
        {
            return _db.Accounts.Where(acc => acc.SellerId == null && acc.RoleId == 2).ToList();
        }

        public AccountModel findById(int id)
        {
            //trả về IQueryable kiểu int nên chọn phần tử đầu sẽ là int
            var account = _db.Accounts.FromSqlInterpolated($"Select * From Account Where accountId = {id}").First();
            if (account != null)
                return account;
            return null;
        }

        public string findRoleAccount(string username, string password)
        {
            //trả về IQueryable kiểu int nên chọn phần tử đầu sẽ là int
            var accountWithRole = _db.Accounts.Include(a => a.AccountRole).Where(r => r.AccountUserName == username && r.AccountPassword == password).First();
            if (accountWithRole != null)
            {
                string accountRoleName = accountWithRole.AccountRole.RoleName;
                if (accountRoleName != null)
                    return accountRoleName;
                return null;
            }    
            return null;
        }

        public int findSellerId(string username)
        {
            var sellerId = _db.Accounts.Where(acc => acc.AccountUserName == username).Select(acc => acc.SellerId).First();
            return (sellerId == null || sellerId == 0) ? -1 : Convert.ToInt32(sellerId);
        }

        public void registerAccount(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool registerAccount(AccountModel account)
        {
            bool registerSuccessful = true;
            try
            {
                _db.Accounts.Add(account);
                _db.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                registerSuccessful = false;
            }
            return registerSuccessful;


        }
    }
}
