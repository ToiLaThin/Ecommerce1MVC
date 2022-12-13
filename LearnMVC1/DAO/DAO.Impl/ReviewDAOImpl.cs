using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO.DAO.Impl
{
    public class ReviewDAOImpl : IReviewDAO
    {
        ApplicationDbContext _db;
        public ReviewDAOImpl(ApplicationDbContext db)
        {
            _db = db;
        }
        public void delete(int reviewId)
        {
            int reviewUpdatedCount = _db.Database.ExecuteSqlInterpolated($"Delete From Review Where reviewId = {reviewId}");
            if (reviewUpdatedCount == 1)
                Console.WriteLine("review deleted Success");
        }

        public void edit(ReviewModel review)
        {
            int reviewUpdatedCount = _db.Database.ExecuteSqlInterpolated($"Update Review Set reviewContent={review.ReviewContent},reviewDateCreated={review.ReviewDateCreated},id_Review_Product={review.ProductId},id_Review_Account={review.AccountId} where Review.reviewId={review.ReviewId}");
            if (reviewUpdatedCount == 1)
                Console.WriteLine("review updated Success");
        }

        public void insert(ReviewModel review)
        {
            if(_db.Reviews.Add(review).State == EntityState.Added)
            {
                Console.WriteLine("review inserted Success");
                _db.SaveChanges();
            }
            else
            {
                Console.WriteLine("review inserted Failed");
            }
        }

        public List<ReviewModel> loadAllByAccount(int accountId)
        {
            return _db.Reviews.Where(r => r.AccountId == accountId).ToList();
        }

        public List<ReviewModel> loadAllByProduct(int productId)
        {
            return _db.Reviews.Where(r => r.ProductId == productId).ToList();
        }

        public List<ReviewModel> loadInitTenByProduct(int productId)
        {
            return _db.Reviews.FromSqlInterpolated($"Select Top 5 * From Review Where id_Review_Product = {productId} Order By reviewDateCreated Desc").Include(r => r.ReviewAccount).ToList();
        }

        public List<ReviewModel> loadNextTenByProduct(int productId, int skipAmount)
        {
            return _db.Reviews.FromSqlInterpolated($"Select * From Review Where id_Review_Product = {productId} Order By reviewDateCreated Desc Offset {skipAmount} Rows Fetch Next 5 Rows Only").Include(r => r.ReviewAccount).ToList();
        }
    }
}
