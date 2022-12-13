using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models
{
    [Table("Seller")]
    public class SellerModel
    {
        [Key]
        [Column("sellerId")]
        public int SellerId { get; set; }

        [Required]
        [Column("sellerName")]
        public string SellerName { get; set; }

        [Column("sellerImage")]
        public string? SellerImage { get; set; }

        [Column("sellerStatus")]
        //thay đổi file migration để giá trị mặc định là 1
        public int sellerStatus { get; set; } = 1;

        [ForeignKey("StoreId")]
        public StoreModel SellerStore { get; set; }

        [Column("id_Seller_Store")]
        [Required]
        public int StoreId { get; set; }
    }
}
