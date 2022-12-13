using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models
{
    [Table("Inventory")]
    public class InventoryModel
    {
        [Key]
        [Column("inventoryId")]
        public int InventoryId { get; set; }

        [ForeignKey("StoreId")]
        public StoreModel InventoryStore { get; set; }

        [Column("id_Inventory_Store")]
        [Required]
        public int StoreId { get; set; }

        [ForeignKey("ProductId")]
        public ProductModel InventoryProduct { get; set; }

        [Column("id_Inventory_Product")]
        [Required]
        public int ProductId { get; set; }

        [Column("inventoryProductAmount")]
        [Required]
        public int InventoryProductAmount { get; set; }
    }
}
