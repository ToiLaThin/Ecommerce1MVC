using Microsoft.EntityFrameworkCore;
//install EntityFramework package to use System.Data.Entity
//using System.Data.Entity;
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

        //fluent API to configure composite key on WishListModel
        protected override void OnModelCreating(ModelBuilder builder)
        {           
            builder.Entity<WishListModel>().HasKey(wl => new { wl.AccountId, wl.ProductId });
        }
        public DbSet<ProductModel> Products{ get; set; }
        public DbSet<CategoryModel> Categories{ get; set; }
        public DbSet<RoleModel> Roles{ get; set; }
        public DbSet<AccountModel> Accounts{ get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }
        public DbSet<WishListModel> WishLists { get; set; }
    }
}
