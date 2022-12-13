using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models
{
    [Table("WishList")]
    public class WishListModel
    {
        [ForeignKey("AccountId")]
        public AccountModel WishListAccount { get; set; }

        //fluent API in ApplicationDbContext to create composite key
        [Column("id_WishList_Account")]
        public int AccountId { get; set; }


        [ForeignKey("ProductId")]
        public ProductModel WishListProduct{ get; set; }

        [Column("id_WishList_Product")]
        public int ProductId { get; set; }
    }
}
