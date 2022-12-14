using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models
{
    [Table("Store")]
    public class StoreModel
    {
        [Key]
        [Column("storeId")]
        public int StoreId { get; set; }

        [Column("storeName")]
        [Required]
        //phaỉ unique để có thể findStoreId qua storeName
        //chưa chỉnh trong file migration => To Do
        public string StoreName { get; set; }

        [Column("storeCreateDate")]
        [Required]
        [DataType(DataType.DateTime)]
        //thay đổi file migration để giá trị mặc định là DateTime.Now.
        public DateTime StoreCreateDate { get; set; } = DateTime.Now.ToLocalTime();
    }
}
