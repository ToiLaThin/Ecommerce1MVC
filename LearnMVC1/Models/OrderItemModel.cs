using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models
{
    [Table("OrderItem")]
    public class OrderItemModel
    {
        [Key]
        [Column("orderItemId")]
        public int OrderItemId { get; set; }

        [ForeignKey("OrderId")]
        public OrderModel OrderItemOrder{ get; set; }

        [Column("id_OrderItem_Order")]
        [Required]
        public int OrderId { get; set; }

        [ForeignKey("ProductId")]
        public ProductModel OrderItemProduct { get; set; }

        [Column("id_OrderItem_Product")]
        [Required]
        public int ProductId { get; set; }

        [Column("orderItemQuantity")]
        [Required]
        public int OrderItemQuantity { get; set; }

        [Column("orderItemUnitPrice", TypeName = "decimal(18, 2)")]
        [Required]
        public decimal OrderItemUnitPrice { get; set; }

        [Column("orderItemStatus")]
        [Required]
        //thay đổi file migration để giá trị mặc định là 0: chưa duyệt, 1 là đã duyệt
        public int OrderItemStatus { get; set; }
        public OrderItemModel()
        {

        }

        public OrderItemModel(CartItemModel cartItem)
        {
            this.OrderItemUnitPrice = cartItem.CartItemUnitPrice;
            this.OrderItemQuantity = cartItem.CartItemQuantity;
            this.ProductId = cartItem.CartItemProductId;
            //phải set thêm OrderId trước khi insert vào database
        }
    }
}
