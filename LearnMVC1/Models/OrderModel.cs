using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models
{
    [Table("Order")]
    public class OrderModel
    {
        [Key]
        [Column("orderId")]
        public int OrderId { get; set; }

        [ForeignKey("AccountId")]
        public AccountModel OrderAccount { get; set; }

        [Column("id_Order_Account")]
        [Required]
        public int AccountId { get; set; }

        [Column("orderBuyDate")]
        [Required]
        [DataType(DataType.DateTime)]
        //thay đổi file migration để giá trị mặc định là DateTime.Now.ToLocalTime()
        public DateTime OrderBuyDate { get; set; } = DateTime.Now.ToLocalTime();

        [Column("orderStatus")]
        [Required]
        //thay đổi file migration để giá trị mặc định là 0
        public int OrderStatus { get; set; }

        [Column("orderPhone")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string OrderPhone { get; set; }

        [Column("orderAddress")]
        [Required]
        public string OrderAddress { get; set; }        

        [Column("orderTotalPrice", TypeName = "decimal(18, 2)")]
        [Required]
        public decimal OrderTotalPrice { get; set; }

        [NotMapped]
        public bool CanChangeStatus { get; set; } = false;

        //thay đổi file migration để giá trị mặc định là directcheck
        [Column("orderPaymentMethod")]
        [Required]
        public string OrderPaymentMethod { get; set; }
    }
}
