using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models
{
    [Table("Category")]
    public class CategoryModel
    {
        [Key]
        [Column("categoryId")]
        public int CategoryId { get; set; }

        [Required]
        [Column("categoryName")]
        public string CategoryName { get; set; }

        [Column("categoryImage")]
        public string? CategoryImage { get; set; }

        [Column("categoryStatus")]
        public int CategoryStatus { get; set; } = 1;
    }
}
