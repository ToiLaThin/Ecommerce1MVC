using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models
{
    [Table("Review")]
    public class ReviewModel
    {
        [Key]
        [Column("reviewId")]
        public int ReviewId { get; set; }

        [Required]
        [Column("reviewContent")]
        public string ReviewContent { get; set; }

        [Column("reviewDateCreated")]
        [DataType(DataType.DateTime)]
        //chỉnh file migration để có giá trị mặc định là DateTime.Now
        public DateTime ReviewDateCreated { get; set; } = DateTime.Now.ToLocalTime();

        [ForeignKey("AccountId")]
        public AccountModel ReviewAccount { get; set; }

        [Required]
        [Column("id_Review_Account")]
        public int AccountId { get; set; }


        [ForeignKey("ProductId")]
        public ProductModel ReviewProduct { get; set; }

        [Required]
        [Column("id_Review_Product")]
        public int ProductId { get; set; }
    }
}
