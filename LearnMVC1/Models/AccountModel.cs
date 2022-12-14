using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models
{
    [Table("Account")]
    public class AccountModel
    {
        [Key]
        [Column("accountId")]
        public int AccountId { get; set; }

        [Required]   
        [Column("accountUserName", TypeName = "nvarchar(450)")]
        //sửa trong file migration để unique
        public string AccountUserName { get; set; }

        [Column("accountEmail")]
        public string? AccountEmail { get; set; }

        [Column("accountFullName")]
        public string? AccountFullName { get; set; }

        [Required]
        [Column("accountPassword")]
        [DataType(DataType.Password)]
        public string AccountPassword{ get; set; }

        [Column("accountImage")]
        public string? AccountImage { get; set; }

        [Column("accountPhone")]
        [DataType(DataType.PhoneNumber)]
        public string? AccountPhone { get; set; }

        [Required]
        [Column("accountStatus")]
        //sửa trong file migration để giá trị mặc định là 0
        public int AccountStatus { get; set; } = 0;

        [Column("accountCode")]
        public string? AccountCode{ get; set; }


        [ForeignKey("RoleId")]
        public RoleModel AccountRole { get; set; }

        [Required]
        [Column("id_Account_Role")]
        public int RoleId { get; set; }

        //[ForeignKey("SellerId")]
        //public SellerModel AccountSeller { get; set; }

        //[Column("id_Account_Seller")]
        //public int? SellerId { get; set; }
    }
}
