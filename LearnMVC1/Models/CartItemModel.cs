using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models
{
    //model này để lưu giữ liệu trong session
    //không lưu trong database
    public class CartItemModel
    {
        public int CartItemId { get; set; }
        public ProductModel CartItemProduct { get; set; }
        public int CartItemQuantity { get; set; }
        public decimal CartItemUnitPrice { get; set; }
        public int CartItemProductId { get; set; }

        public CartItemModel()
        {

        }

        public CartItemModel(ProductModel product, int quantity)
        {           
            this.CartItemProduct = product;
            this.CartItemQuantity = quantity;
            this.CartItemUnitPrice = product.ProductPrice;
            this.CartItemProductId = product.ProductId;
        }
    }
}
