﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models
{
    [Table("Product")]
    public class ProductModel
    {
        [Key]
        [Column("productId")]
        public int ProductId { get; set; }

        [Required]
        [Column("productName")]
        public string ProductName { get; set; }

        [Column("productCode")]
        public string? ProductCode { get; set; }


        [ForeignKey("CategoryId")]
        public CategoryModel ProductCategory { get; set; }

        [Column("id_Product_Category")]
        public int? CategoryId { get; set; }

        [Required]
        [Column("productDescription")]
        public string ProductDescription { get; set; }

        [Required]
        [Column("productPrice", TypeName = "decimal(18, 6)")]
        public decimal ProductPrice { get; set; }

        [Column("productImage")]
        public string? ProductImage { get; set; }

        [Column("productStatus")]
        public int ProductStatus { get; set; } = 1;

        [Column("productModifiedDate")]
        [DataType(DataType.DateTime)]
        public DateTime ProductModifiedDate { get; set; } = DateTime.Now.ToLocalTime();

        [Column("productRevenue")]
        public int ProductRevenue { get; set; } = 0;

        [NotMapped]
        public bool IsWished { get; set; } = false;
    }
}
