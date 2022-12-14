using LearnMVC1.DAO.DAO.Impl;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Controllers
{
	public class SellerController : Controller
	{
		private readonly ApplicationDbContext _db;
		SellerDAOImpl sellerDAOImpl;
		StoreDAOImpl storeDAOImpl;
		AccountDAOImpl accountDAOImpl;

		public SellerController(ApplicationDbContext db)
		{
			_db = db;
			sellerDAOImpl = new SellerDAOImpl(_db);
			storeDAOImpl = new StoreDAOImpl(_db);
			accountDAOImpl = new AccountDAOImpl(_db);
		}

		[Route("/User/Seller/Register")]
		[HttpPost]
		public IActionResult RegisterPost()
		{
			string sellerName = HttpContext.Request.Form["tenDoanhNghiep"];
			string storeName = HttpContext.Request.Form["tenCuaHang"];
			string maSoDoanhNghiep = HttpContext.Request.Form["maSoDoanhNghiep"];
			string maSoNoiBo = HttpContext.Request.Form["maSoNoiBo"];
			if (maSoDoanhNghiep.Length == 10 && maSoNoiBo.Length == 10)
			{
				storeDAOImpl.insertStore(storeName, DateTime.Now.ToLocalTime());
				int storeInsertedId = storeDAOImpl.findStoreId(storeName);

				sellerDAOImpl.insertSeller(sellerName, storeInsertedId);
				//gắn sellerId đó với user hiện  tại(cập nhật bảng user)
				//đổi role user này thành seller
				int sellerId = sellerDAOImpl.findSellerId(sellerName);
				string username = Global.GlobalVar.AccountUserName;
				accountDAOImpl.becomeSeller(sellerId, username);

				ViewData["RegisterSellerSuccess"] = true;
				return View("/Views/Common/AccountLogin.cshtml");
			}
			else
			{
				ViewData["RegisterSellerFailed"] = true;
				//req.setAttribute("registerSellerFailed", true);
				return View("/Views/User/SellerRegister.cshtml");
			}
			return View();
		}

		[Route("/User/Seller/Register")]
		[HttpGet]
		public IActionResult RegisterGet()
		{
			return View("/Views/User/SellerRegister.cshtml");
		}
	}
}

