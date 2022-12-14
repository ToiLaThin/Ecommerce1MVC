using LearnMVC1.DAO.DAO.Impl;
using LearnMVC1.Models;
using LearnMVC1.Global;
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
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _db;
        ProductDAOImpl productDAOImpl;
        InventoryDAOImpl inventoryDAOImpl;

        public CartController(ApplicationDbContext db)
        {
            _db = db;
            productDAOImpl = new ProductDAOImpl(_db);
            inventoryDAOImpl = new InventoryDAOImpl(_db);
        }

        [Route("/Common/Cart/Add")]
		[HttpGet]
        public IActionResult AddProductToCart(int productId)
        {
			List<CartItemModel> cart = new List<CartItemModel>();
			string sessionCart = HttpContext.Session.GetString("cart");
            if(sessionCart == null)
            {
                int productAmountInInventory = inventoryDAOImpl.findAmount(productId);
				if (productAmountInInventory > 0) //bao gồm cả khác -1
				{
					cart.Add(new CartItemModel(productDAOImpl.find(productId), 1));
				}
				else
					ViewData["OutOfProduct"] = true;

			}
			else
			{
				cart = JsonConvert.DeserializeObject<List<CartItemModel>>(sessionCart);
				//dù thêm 1 hay thêm nhiều cũng cần kiểm tra với lượng tồn kho
				int productAmountInInventory = inventoryDAOImpl.findAmount(productId);
				int productIndexInCart = isInCart(productId, cart);
				if (productIndexInCart == -1)
				{
					if (productAmountInInventory > 0)
						cart.Add(new CartItemModel(productDAOImpl.find(productId), 1));
					else
						ViewData["OutOfProduct"] = true;
				}
				else
				{
					ProductModel product = cart[productIndexInCart].CartItemProduct;
					//lam service lay so luong hang trong kho
					int quantity = cart[productIndexInCart].CartItemQuantity + 1;
					if (quantity <= productAmountInInventory)
					{
						cart[productIndexInCart].CartItemQuantity = quantity;
					}
					else
					{
						ViewData["OutOfProduct"] = true;
						quantity -= 1;
						cart[productIndexInCart].CartItemQuantity = quantity;
					}

				}
			}
			HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
			return View("/Views/Common/Cart.cshtml");
		}

		[Route("/Common/Cart/Update")]
		[HttpGet]
		public IActionResult UpdateProductInCart(int productId, int productQuantity)
		{

			List<CartItemModel> cart = new List<CartItemModel>();
			string sessionCart = HttpContext.Session.GetString("cart");
			if (sessionCart == null)
			{ //tạo cart mới có 1 product duy nhất
				cart.Add(new CartItemModel(productDAOImpl.find(productId), productQuantity));
			}
			else
			{ //ép kiểu
				cart = JsonConvert.DeserializeObject<List<CartItemModel>>(sessionCart);
				int productIndexInCart = isInCart(productId, cart);
				if (productIndexInCart == -1)
				{
					cart.Add(new CartItemModel(productDAOImpl.find(productId), productQuantity));
				}
				else
					cart[productIndexInCart].CartItemQuantity = productQuantity;
			}
			HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
			return View("/Views/Common/Cart.cshtml");
		}

		[Route("/Common/Cart/Remove")]
		[HttpGet]
		public IActionResult RemoveProductFromCart(int productId)
		{
			string sessionCart = HttpContext.Session.GetString("cart");
			List<CartItemModel> cart = JsonConvert.DeserializeObject<List<CartItemModel>>(sessionCart);
			int productIndexInCart = isInCart(productId, cart);
			if(productIndexInCart != -1)
				cart.RemoveAt(productIndexInCart);
			HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
			return View("/Views/Common/Cart.cshtml");
		}

		[Route("/Common/Cart/List")]
		[HttpGet]
		public IActionResult ListAllProductInCart()
		{
			List<CartItemModel> cart = new List<CartItemModel>();
			string sessionCart = HttpContext.Session.GetString("cart");
			if(sessionCart != null)
				cart = JsonConvert.DeserializeObject<List<CartItemModel>>(sessionCart);
			HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
			return View("/Views/Common/Cart.cshtml");
		}


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
