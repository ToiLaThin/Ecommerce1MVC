using LearnMVC1.DAO.DAO.Impl;
using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ApplicationDbContext _db;
        ReviewDAOImpl reviewDAOImpl;
        public ReviewController(ApplicationDbContext db)
        {
            _db = db;
            reviewDAOImpl = new ReviewDAOImpl(_db);
        }

        [Route("/Common/Review/Insert")]
        [HttpPost]
        public IActionResult Insert()
        {
            if (ModelState.IsValid)
            {
                int productId= Convert.ToInt32(HttpContext.Request.Form["productId"]);
                int accountId = Convert.ToInt32(HttpContext.Request.Form["accountId"]);
                string reviewContent = HttpContext.Request.Form["yourReviewContent"].ToString();
                ReviewModel reviewCreated = new ReviewModel();
                reviewCreated.ProductId = productId;
                reviewCreated.AccountId = accountId;
                reviewCreated.ReviewContent = reviewContent;
                reviewDAOImpl.insert(reviewCreated);
                return Redirect("/Common/Product/Detail?productId=" + productId);
            }
            //thay trả về trang báo lỗi
            return Redirect("/Common/Product/Detail");
        }

        [Route("/Common/Review/LoadAjax")]
        [HttpGet]
        public string LoadAjax()
        {

            int skipAmountInt = Convert.ToInt32(Request.Query["currReviewsCount"]);
            int productId = Convert.ToInt32(Request.Query["productId"]);
            List<ReviewModel> nextTenReviews = reviewDAOImpl.loadNextTenByProduct(productId, skipAmountInt);
            string returnHtmlString = "";
            foreach(ReviewModel r in nextTenReviews)
            {
                string imgLink;
                if (r.ReviewAccount.AccountImage != null)
                    imgLink = r.ReviewAccount.AccountImage;
                else
                    imgLink = "/img/user.jpg";
                returnHtmlString += "<div class='media mb-4 review'>\r\n"
                    + "                                    <img src='" + imgLink + "' alt='Image' class='img-fluid mr-3 mt-1' style='width: 45px;'>\r\n"
                    + "                                    <div class='media-body'>\r\n"
                    + "                                        <h6>" + r.ReviewAccount.AccountUserName + "<small> - <i>" + r.ReviewDateCreated + "</i></small></h6>\r\n"
                    + "                                        <div class='text-primary mb-2'>\r\n"
                    + "                                            <i class='fas fa-star'></i>\r\n"
                    + "                                            <i class='fas fa-star'></i>\r\n"
                    + "                                            <i class='fas fa-star'></i>\r\n"
                    + "                                            <i class='fas fa-star-half-alt'></i>\r\n"
                    + "                                            <i class='far fa-star'></i>\r\n"
                    + "                                        </div>\r\n"
                    + "                                        <p>" + r.ReviewContent + ".</p>\r\n"
                    + "                                    </div>\r\n"
                    + "                                </div>";
            }
            return returnHtmlString;
        }
    }
}
