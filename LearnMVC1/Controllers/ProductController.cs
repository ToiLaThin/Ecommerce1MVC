using LearnMVC1.DAO.DAO.Impl;
using LearnMVC1.Models;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        ProductDAOImpl productDAOImpl;
        CategoryDAOImpl categoryDAOImpl;
        WishListDAOImpl wishListDAOImpl;
        AccountDAOImpl accountDAOImpl;
        ReviewDAOImpl reviewDAOImpl;
        InventoryDAOImpl inventoryDAOImpl;
        StoreDAOImpl storeDAOImpl;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
            productDAOImpl = new ProductDAOImpl(_db);
            categoryDAOImpl = new CategoryDAOImpl(_db);
            accountDAOImpl = new AccountDAOImpl(_db);
            wishListDAOImpl = new WishListDAOImpl(_db);
            reviewDAOImpl = new ReviewDAOImpl(_db);
            inventoryDAOImpl = new InventoryDAOImpl(_db);
            storeDAOImpl = new StoreDAOImpl(_db);
        }

        [Route("/Common/Product/List")]
        public IActionResult ListAll()
        {
            var products = productDAOImpl.findAll();
            var categories = categoryDAOImpl.findAll();

            string username = HttpContext.Session.GetString("accountUserName");
            if (username != null)
            {
                int accountId = accountDAOImpl.findAccountId(username);
                ViewData["AccountId"] = accountId;

                foreach (ProductModel product in products)
                {
                    if (wishListDAOImpl.isInWishList(product.ProductId, accountId))
                        product.IsWished = true;
                    else
                        product.IsWished = false;
                }
            }
            ViewData["Products"] = products;
            ViewData["Categories"] = categories;
            return View("/Views/Common/ProductList.cshtml");
        }

        [Route("/Common/Product/Detail")]
        public IActionResult Detail(int productId)
        {
            var product = productDAOImpl.find(productId);
            int allReviewsCount = reviewDAOImpl.loadAllByProduct(productId).Count;
            List<ReviewModel> reviews = reviewDAOImpl.loadInitTenByProduct(productId);

            int productAmountInInventory = inventoryDAOImpl.findAmount(productId);
            if (productAmountInInventory == -1)
                productAmountInInventory = 0;

            List<CartItemModel> cart = null;
            string sessionCart = HttpContext.Session.GetString("cart");
            if (sessionCart != null)
                cart = JsonConvert.DeserializeObject<List<CartItemModel>>(sessionCart);

            int productQuantityInCart;
            if (cart != null)
            {
                int productIndexInCart = isInCart(productId, cart);
                //chỉ lấy quantity ra chứa không thay đổi quantity product trong cart
                if (productIndexInCart == -1)
                    productQuantityInCart = 0;
                else
                    productQuantityInCart = cart[productIndexInCart].CartItemQuantity;
            }
            else
                productQuantityInCart = 0;


            string username = HttpContext.Session.GetString("accountUserName");
            if (username != null)
            {
                int accountId = accountDAOImpl.findAccountId(username);
                ViewData["AccountId"] = accountId;
                string accountImage = accountDAOImpl.findById(accountDAOImpl.findAccountId(username)).AccountImage;
                ViewData["AccountImage"] = accountImage;
            }
            ViewData["ProductAmountInInventory"] = productAmountInInventory;
            ViewData["ProductQuantityInCart"] = productQuantityInCart;
            ViewData["Product"] = product;
            ViewData["Reviews"] = reviews;
            ViewData["ReviewsCount"] = allReviewsCount;
            return View("Views/Common/ProductDetail.cshtml");
        }

        [Route("/Common/Product/Search")]
        [HttpPost]
        public IActionResult Search()
        {
            if(ModelState.IsValid)
            {
                string searchPhrase = Request.Form["searchPhrase"];
                var productsSearched = productDAOImpl.findBySearch(searchPhrase);
                ViewData["Products"] = productsSearched;

                string username = HttpContext.Session.GetString("accountUserName");
                if (username != null)
                {
                    int accountId = accountDAOImpl.findAccountId(username);
                    ViewData["AccountId"] = accountId;

                    foreach (ProductModel product in productsSearched)
                    {
                        if (wishListDAOImpl.isInWishList(product.ProductId, accountId))
                            product.IsWished = true;
                        else
                            product.IsWished = false;
                    }
                }
            }    
            var categories = categoryDAOImpl.findAll();
            ViewData["Categories"] = categories;
            return View("/Views/Common/ProductList.cshtml");

            //boolean accountDisabled = false;
            //boolean orderSuccess = false;
            //if (req.getAttribute("accountDisabled") != null)
            //{
            //    accountDisabled = (boolean)req.getAttribute("accountDisabled");
            //}
            //if (req.getAttribute("orderSuccess") != null)
            //{
            //    orderSuccess = (boolean)req.getAttribute("orderSuccess");
            //}
            //req.setAttribute("accountDisabled", accountDisabled);
            //req.setAttribute("orderSuccess", orderSuccess);
        }

        [Route("/Common/Product/FilterByCategory")]
        [HttpGet]
        public IActionResult FilterByCategory(int categoryId,string categoryName)
        {
            List<ProductModel> productsOfCategory = productDAOImpl.findByCategory(categoryId);            
            ViewData["CategoryName"] = categoryName;
            return View("Views/Common/ProductFilterByCategory.cshtml",productsOfCategory);
        }

        [Route("/Common/Product/FilterByStore")]
        [HttpGet]
        public IActionResult FilterByStore(int storeId)
        {
            StoreModel store = storeDAOImpl.findStore(storeId);
            List<ProductModel> products = storeDAOImpl.findAllProduct(storeId);
            if (Global.GlobalVar.IsLogin)
            {
                foreach(ProductModel product in products)
                {
                    if (wishListDAOImpl.isInWishList(product.ProductId, Global.GlobalVar.AccountId))
                        product.IsWished = true;
                    else
                        product.IsWished = false;
                }
            }
            ViewData["Store"] = store;
            ViewData["Products"] = products;
            return View("/Views/Common/ProductFilterByStore.cshtml");
        }

        //tuy là thuộc controller product nhưng lại dùng cartDAO chứ ko sử dụng productDAO
        [Route("/Common/Product/BuyNow")]
        [HttpGet]
        public IActionResult BuyNow(int productId)
        {
            List<CartItemModel> cart = new List<CartItemModel>();
            int productAmountInInventory = inventoryDAOImpl.findAmount(productId);
            if (productAmountInInventory > 0) //bao gồm cả khác -1
            {
                cart.Add(new CartItemModel(productDAOImpl.find(productId), 1));

                //xóa cart cũ trong session 
                HttpContext.Session.Remove("cart");
                //cart mới là có duy nhất sp mua ngay số lượng là 1
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
                return Redirect("/Common/Order/Insert");
            }
            else
            {
                ViewData["OutOfProduct"] = true;
                return Redirect("/Common/Product/List");
            }    

        }

        #region Seller 's product controller

        [Route("/Seller/Product/List")]
        [HttpGet]
        public IActionResult ListOfShop(int categoryId, string categoryName)
        {            
            int sellerId = Global.GlobalVar.SellerId;
            List<ProductModel> productListOfSeller = productDAOImpl.findAllBySellerId(sellerId);
            ViewData["ProductListOfSeller"] = productListOfSeller;
            List<CategoryModel> categories = categoryDAOImpl.findAll();
            ViewData["Categories"] = categories;
            return View("/Views/Seller/ProductList.cshtml");
        }

        [Route("/Seller/Product/Insert")]
        [HttpGet]
        public IActionResult InsertGet()
        {
            List<CategoryModel> categories = categoryDAOImpl.findAll();
            ViewData["Categories"] = categories;
            return View("/Views/Seller/ProductInsert.cshtml");
        }

        [Route("/Seller/Product/Insert")]
        [HttpPost]
        public IActionResult InsertPost()
        {
            bool isValidated = false;
            ProductModel product = new ProductModel();
            try {
                product.ProductName = HttpContext.Request.Form["productName"].ToString();
                product.ProductDescription = HttpContext.Request.Form["productDescription"];
                product.ProductPrice = Convert.ToDecimal(HttpContext.Request.Form["productPrice"]);
                product.ProductImage = HttpContext.Request.Form["productImage"].ToString();
                product.ProductModifiedDate = DateTime.Now.ToLocalTime();
                product.SellerId = Global.GlobalVar.SellerId;
                product.CategoryId = Convert.ToInt32(HttpContext.Request.Form["categoryId"]);
                productDAOImpl.insertProduct(product);

                int productInsertedId = productDAOImpl.findProductId(product);
                int stock = Convert.ToInt32(HttpContext.Request.Form["productStock"]);
                int storeId = Global.GlobalVar.StoreId;

                inventoryDAOImpl.insertInventory(productInsertedId, storeId, stock);
                isValidated = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isValidated = false;
            }
            if (isValidated)
                return Redirect("/Seller/Product/List");
            else
                //vẫn đúng là get
                return Redirect("/Seller/Product/Insert");
        }


        [Route("/Seller/Product/Update")]
        [HttpGet]
        public IActionResult UpdateGet(int productId)
        {
            ProductModel product = new ProductModel();
            product = productDAOImpl.find(productId);

            List<CategoryModel> categories = categoryDAOImpl.findAll();
            int productStock = inventoryDAOImpl.findAmount(productId);
            ViewData["ProductStock"] = productStock;
            ViewData["Product"] = product;
            ViewData["Categories"] = categories;
            return View("/Views/Seller/ProductUpdate.cshtml");
        }

        [Route("/Seller/Product/Update")]
        [HttpPost]
        public IActionResult UpdatePost()
        {
            bool isValidated = false;
            ProductModel product = new ProductModel();
            try
            {
                int productId = Convert.ToInt32(HttpContext.Request.Form["productId"]);
                product.ProductId = productId;
                product.ProductName = HttpContext.Request.Form["productName"];
                product.ProductDescription = HttpContext.Request.Form["productDescription"];
                product.ProductPrice = Convert.ToDecimal(HttpContext.Request.Form["productPrice"]);
                product.ProductImage = HttpContext.Request.Form["productImage"];
                product.ProductStatus = Convert.ToInt32(HttpContext.Request.Form["productStatus"]);
                product.ProductModifiedDate = DateTime.Now.ToLocalTime();
                product.SellerId = Global.GlobalVar.SellerId;
                product.CategoryId = Convert.ToInt32(HttpContext.Request.Form["categoryId"]);
                productDAOImpl.editProduct(product);

                int newProductStock = Convert.ToInt32(HttpContext.Request.Form["productStock"]);
                inventoryDAOImpl.updateInventory(productId, newProductStock);
                isValidated = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isValidated = false;
            }
            if (isValidated)
                return Redirect("/Seller/Product/List");
            else
                return View("/Views/Seller/ProductInsert.cshtml");
        }

        #endregion


        #region Admin 's product controller
        [Route("/Admin/Product/ChangeStatus")]
        [HttpGet]
        public IActionResult ChangeStatus(int productId)
        {
            ProductModel product = productDAOImpl.find(productId);
            int productOldStatus = product.ProductStatus;
            if (productOldStatus == 0)
                //inactive
                product.ProductStatus = 1;
            else if (productOldStatus == 1)
                //active
                product.ProductStatus = 0;
            productDAOImpl.editProduct(product);
            return Redirect("/Admin/Account/List");
        }
        #endregion

        #region Util Methods
        private int isInCart(int productId, List<CartItemModel> cart)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].CartItemProduct.ProductId == productId)
                    return i;
            }
            return -1;
        }
        #endregion
    }
}
