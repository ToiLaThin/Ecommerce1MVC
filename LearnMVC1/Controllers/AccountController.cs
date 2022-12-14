using LearnMVC1.DAO.DAO.Impl;
using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using LearnMVC1.Global;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        AccountDAOImpl accountDAOImpl;
        WishListController wishListController;
        SellerDAOImpl sellerDAOImpl;
        public AccountController(ApplicationDbContext db)
        {
            _db = db;
            accountDAOImpl = new AccountDAOImpl(_db);
            wishListController = new WishListController(_db);
            sellerDAOImpl = new SellerDAOImpl(_db);
        }

        [Route("/Common/Account/Register")]
        [HttpGet]
        public IActionResult RegisterGet()
        {
            return View("/Views/Common/AccountRegister.cshtml");
        }

        //có thể cùng url nhưng khác http verb
        [Route("/Common/Account/Register")]
        [HttpPost]
        public IActionResult RegisterPost()
        {
            if (ModelState.IsValid)
            {
                string username = HttpContext.Request.Form["username"].ToString();
                string password = HttpContext.Request.Form["password"];
                string fullname = HttpContext.Request.Form["fullname"].ToString();
                string email = HttpContext.Request.Form["email"].ToString();
                string phone = HttpContext.Request.Form["phone"].ToString();
                string confirmedPassword = HttpContext.Request.Form["confirmedPassword"];

                if (password.Equals(confirmedPassword))
                {
                    AccountModel newAccount = new AccountModel();
                    newAccount.AccountUserName = username;
                    newAccount.AccountPassword = password;
                    newAccount.AccountFullName = fullname;
                    newAccount.AccountEmail = email;
                    newAccount.AccountPhone = phone;
                    newAccount.RoleId = 2;
                    bool registerResult = accountDAOImpl.registerAccount(newAccount);
                    if (registerResult == true)
                    {
                        ViewData["RegisterSuccess"] = true;
                        //Redirect dùng cho Url nếu mình thay đổi hành vi mặc định(convention) của MVC
                        //View() không thay đổi URL hiện tại mà chỉ render file html ra browser
                        //RedirectToRoute là dựa theo route table chứ ko phải [Route("") ]
                        //RedirectToAction là đến action dựa theo convention
                        return View("/Views/Common/AccountLogin.cshtml");

                    }
                    else
                    {
                        ViewData["UserExisted"] = true;
                        return View("/Views/Common/AccountRegister.cshtml");
                    }
                }
            }
            ViewData["PasswordMismatch"] = true;
            return View("/Views/Common/AccountRegister.cshtml");
        }

        [Route("/Common/Account/Login")]
        [HttpGet]
        public IActionResult LoginGet()
        {
            return View("/Views/Common/AccountLogin.cshtml");
        }

        [Route("/Common/Account/Login")]
        [HttpPost]
        public IActionResult LoginPost()
        {
            string username = HttpContext.Request.Form["username"].ToString();
            string password = HttpContext.Request.Form["password"];

            bool loginSuccessful = accountDAOImpl.authenticateAccount(username, password);
            if (loginSuccessful)
            {
                int accountId = accountDAOImpl.findAccountId(username);
                AccountModel account = accountDAOImpl.findById(accountId);
                int accountStatus = account.AccountStatus;
                if(accountStatus == 0)
                {
                    HttpContext.Session.SetString("accountUserName", username);
                    string accountRole = accountDAOImpl.findRoleAccount(username, password);
                    HttpContext.Session.SetString("accountRole", accountRole);
                    if (accountRole.Equals("Seller"))
                    {
                        //nếu user role là seller session đưa sellerId vào
                        int sellerId = accountDAOImpl.findSellerId(username);
                        GlobalVar.SellerId = sellerId;
                        GlobalVar.StoreId = sellerDAOImpl.findStoreId(sellerId);
                        HttpContext.Session.SetString("sellerId", GlobalVar.SellerId.ToString());
                        HttpContext.Session.SetString("storeId", GlobalVar.StoreId.ToString());
                    }
                    GlobalVar.AccountId = accountId;
                    GlobalVar.AccountRole = accountRole;
                    GlobalVar.IsLogin = true;
                    GlobalVar.AccountUserName = username;
                }
                else if(accountStatus == 1)
                {
                    SetDefaultGlobalVar();
                    ViewData["AccountDisabled"] = true;
                }
                return Redirect("/Common/Product/List");
            }
            else
            {
                SetDefaultGlobalVar();
                ViewData["LoginFailed"] = true;
                return View("/Views/Common/AccountLogin.cshtml");
            }

        }


        [Route("/Common/Account/Logout")]
        public IActionResult Logout()
        {
            SetDefaultGlobalVar();
            HttpContext.Session.Clear();
            return Redirect("/Common/Product/List");
        }

        [Route("/Common/Account/ProfileUpdate")]
        [HttpGet]
        public IActionResult ProfileUpdateGet()
        {
            //hoạt động tốt
            int accountId = Convert.ToInt32(Request.Query["accountId"]);
            AccountModel account = accountDAOImpl.findById(accountId);
            if(account != null)
                return View("/Views/Common/AccountProfileUpdate.cshtml",account);
            else
                return View("/Views/Common/AccountProfileUpdate.cshtml", account);
        }


        [Route("/Common/Account/ProfileUpdate")]
        [HttpPost]
        public IActionResult ProfileUpdatePost()
        {
            AccountModel updatedAccount = new AccountModel();
            updatedAccount.AccountId = Convert.ToInt32(Request.Form["accountId"]);
            updatedAccount.AccountFullName = Request.Form["accountFullname"];
            updatedAccount.AccountEmail = Request.Form["accountEmail"];
            updatedAccount.AccountPhone = Request.Form["accountPhone"].ToString();
            updatedAccount.AccountImage = Request.Form["accountImage"];

            accountDAOImpl.changeProfile(updatedAccount);

            //vẫn tới đúng ProfileUpdateGet
            return Redirect("/Common/Account/ProfileUpdate?accountId=" + updatedAccount.AccountId);
        }

        [Route("/Common/Account/PasswordUpdate")]
        [HttpGet]
        public IActionResult PasswordUpdateGet(int accountId)
        {
            AccountModel account = accountDAOImpl.findById(accountId);
            //nếu không có tham số này thì lấy convert to bool ra false
            bool newPasswordMismatch = Convert.ToBoolean(Request.Query["newPasswordMismatch"]);
            if (newPasswordMismatch != false)
                ViewData["NewPasswordMismatch"] = newPasswordMismatch;
            bool oldPasswordMismatch = Convert.ToBoolean(Request.Query["oldPasswordMismatch"]);
            if (oldPasswordMismatch != false)
                ViewData["OldPasswordMismatch"] = oldPasswordMismatch;
            string accountOldPassword = account.AccountPassword;
            ViewData["AccountId"] = accountId;
            ViewData["AccountOldPassword"] = accountOldPassword;
            return View("/Views/Common/AccountPasswordUpdate.cshtml");
        }


        [Route("/Common/Account/PasswordUpdate")]
        [HttpPost]
        public IActionResult PasswordUpdatePost()
        {
            int accountId = Convert.ToInt32(Request.Form["accountId"]);
            String accountOldPassword = Request.Form["accountOldPassword"];
            String retypeOldPassword = Request.Form["retypeOldPassword"];
            String accountNewPassword = Request.Form["accountNewPassword"];
            String retypeNewPassword = Request.Form["retypeNewPassword"];
            if (accountOldPassword.Equals(retypeOldPassword))
            {
                if (accountNewPassword.Equals(retypeNewPassword))
                {
                    accountDAOImpl.changePassword(accountId, accountNewPassword);
                    return Redirect("/Common/Product/List");
                }
                else
                {
                    return Redirect("/Common/Account/PasswordUpdate?accountId=" + accountId + "&newPasswordMismatch=" + true);
                }
            }
            else
            {
                return Redirect("/Common/Account/PasswordUpdate?accountId=" + accountId + "&oldPasswordMismatch=" + true);
            }
        }

        #region Util Methods
        private void SetDefaultGlobalVar()
        {
            GlobalVar.SellerId = -1;
            GlobalVar.StoreId = -1;
            GlobalVar.AccountId = -1;
            GlobalVar.AccountRole = null;
            GlobalVar.IsLogin = false;
            GlobalVar.AccountUserName = null;
        }
        #endregion
    }
}
