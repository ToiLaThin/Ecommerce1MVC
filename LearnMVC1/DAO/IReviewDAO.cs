using LearnMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.DAO
{
    interface IReviewDAO
    {
		void insert(ReviewModel review);
		void edit(ReviewModel review);
		void delete(int reviewId);
		List<ReviewModel> loadAllByProduct(int productId);
		List<ReviewModel> loadInitTenByProduct(int productId);
		List<ReviewModel> loadAllByAccount(int accountId);
		List<ReviewModel> loadNextTenByProduct(int productId, int skipAmount);
	}
}
