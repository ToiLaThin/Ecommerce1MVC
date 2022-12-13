using LearnMVC1.Models.EntityFramwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO.DAO.Impl
{
    public class WishListDAOImpl : IWishListDAO
    {
        ApplicationDbContext _db;
        public WishListDAOImpl(ApplicationDbContext db)
        {
            _db = db;
        }
        public void deleteFromWishList(int productId, int accountId)
        {
            int wishListUpdatedCount = _db.Database.ExecuteSqlInterpolated($"Delete From WishList Where id_WishList_Account = {accountId} And id_WishList_Product = {productId}");
            if (wishListUpdatedCount == 1)
                Console.WriteLine("wishList deleted Success");
        }

        public List<int> findAllProductId(int accountId)
        {
            var productIdList = _db.WishLists.FromSqlInterpolated($"Select id_WishList_Product From WishList Where id_WishList_Account = {accountId}").Select(wl => wl.ProductId).ToList();
            return productIdList;
        }

        public void insertToWishList(int productId, int accountId)
        {
            int wishListUpdatedCount = _db.Database.ExecuteSqlInterpolated($"Insert Into WishList(id_WishList_Account,id_WishList_Product) Values({accountId},{productId})");
            if (wishListUpdatedCount == 1)
                Console.WriteLine("wishList inserted Success");
        }

        public bool isInWishList(int productId, int accountId)
        {
			bool isInWishList = false;
	        var wishLists = _db.WishLists.FromSqlInterpolated($"Select * From WishList Where id_WishList_Account = {accountId} And id_WishList_Product = {productId}");
            if (wishLists.Count() >= 1)
                isInWishList = true;
            else
                isInWishList = false;
			return isInWishList;
		}
    }
}
