using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models
{
    [Table("Role")]
    public class RoleModel
    {
        [Key]
        [Column("roleId")]
        public int RoleId { get; set; }

        [Required]
        [Column("roleName")]
        public string RoleName { get; set; }
    }
}
