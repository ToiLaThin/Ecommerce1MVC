using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models
{
    [Table("Receipt")]
    public class ReceiptModel
    {
        [Key]
        [Column("receiptId")]
        public int ReceiptId { get; set; }

        [ForeignKey("OrderId")]
        public OrderModel ReceiptOrder { get; set; }

        [Column("id_Receipt_Order")]
        [Required]
        public int OrderId { get; set; }

        [Column("receiptReleaseDate")]
        [Required]
        [DataType(DataType.DateTime)]
        //thay đổi file migration để giá trị mặc định là DateTime.Now.
        public DateTime ReceiptReleaseDate { get; set; } = DateTime.Now.ToLocalTime();        
    }
}
