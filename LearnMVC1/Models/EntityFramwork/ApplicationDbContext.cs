using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnMVC1.Models.EntityFramwork
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ProductModel> Products{ get; set; }
        public DbSet<CategoryModel> Categories{ get; set; }
        public DbSet<RoleModel> Roles{ get; set; }
        public DbSet<AccountModel> Accounts{ get; set; }
    }
}
