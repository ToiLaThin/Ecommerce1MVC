﻿// <auto-generated />
using System;
using LearnMVC1.Models.EntityFramwork;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LearnMVC1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221230025937_AddStatusToOrderItem")]
    partial class AddStatusToOrderItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LearnMVC1.Models.AccountModel", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("accountId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountCode")
                        .HasColumnName("accountCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountEmail")
                        .HasColumnName("accountEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountFullName")
                        .HasColumnName("accountFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountImage")
                        .HasColumnName("accountImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountPassword")
                        .IsRequired()
                        .HasColumnName("accountPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountPhone")
                        .HasColumnName("accountPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccountStatus")
                        .HasColumnName("accountStatus")
                        .HasColumnType("int");

                    b.Property<string>("AccountUserName")
                        .IsRequired()
                        .HasColumnName("accountUserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RoleId")
                        .HasColumnName("id_Account_Role")
                        .HasColumnType("int");

                    b.Property<int?>("SellerId")
                        .HasColumnName("id_Account_Seller")
                        .HasColumnType("int");

                    b.HasKey("AccountId");

                    b.HasIndex("RoleId");

                    b.HasIndex("SellerId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("LearnMVC1.Models.CategoryModel", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("categoryId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryImage")
                        .HasColumnName("categoryImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnName("categoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryStatus")
                        .HasColumnName("categoryStatus")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("LearnMVC1.Models.InventoryModel", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("inventoryId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InventoryProductAmount")
                        .HasColumnName("inventoryProductAmount")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnName("id_Inventory_Product")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnName("id_Inventory_Store")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("LearnMVC1.Models.OrderItemModel", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("orderItemId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnName("id_OrderItem_Order")
                        .HasColumnType("int");

                    b.Property<int>("OrderItemQuantity")
                        .HasColumnName("orderItemQuantity")
                        .HasColumnType("int");

                    b.Property<int>("OrderItemStatus")
                        .HasColumnName("orderItemStatus")
                        .HasColumnType("int");

                    b.Property<decimal>("OrderItemUnitPrice")
                        .HasColumnName("orderItemUnitPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProductId")
                        .HasColumnName("id_OrderItem_Product")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("LearnMVC1.Models.OrderModel", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("orderId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnName("id_Order_Account")
                        .HasColumnType("int");

                    b.Property<string>("OrderAddress")
                        .IsRequired()
                        .HasColumnName("orderAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderBuyDate")
                        .HasColumnName("orderBuyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderPhone")
                        .IsRequired()
                        .HasColumnName("orderPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderStatus")
                        .HasColumnName("orderStatus")
                        .HasColumnType("int");

                    b.Property<decimal>("OrderTotalPrice")
                        .HasColumnName("orderTotalPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("OrderId");

                    b.HasIndex("AccountId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("LearnMVC1.Models.ProductModel", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("productId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnName("id_Product_Category")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .HasColumnName("productCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnName("productDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImage")
                        .HasColumnName("productImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProductModifiedDate")
                        .HasColumnName("productModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnName("productName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnName("productPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProductRevenue")
                        .HasColumnName("productRevenue")
                        .HasColumnType("int");

                    b.Property<int>("ProductStatus")
                        .HasColumnName("productStatus")
                        .HasColumnType("int");

                    b.Property<int?>("SellerId")
                        .HasColumnName("id_Product_Seller")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SellerId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("LearnMVC1.Models.ReceiptModel", b =>
                {
                    b.Property<int>("ReceiptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("receiptId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnName("id_Receipt_Order")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceiptReleaseDate")
                        .HasColumnName("receiptReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ReceiptId");

                    b.HasIndex("OrderId");

                    b.ToTable("Receipt");
                });

            modelBuilder.Entity("LearnMVC1.Models.ReviewModel", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("reviewId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnName("id_Review_Account")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnName("id_Review_Product")
                        .HasColumnType("int");

                    b.Property<string>("ReviewContent")
                        .IsRequired()
                        .HasColumnName("reviewContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReviewDateCreated")
                        .HasColumnName("reviewDateCreated")
                        .HasColumnType("datetime2");

                    b.HasKey("ReviewId");

                    b.HasIndex("AccountId");

                    b.HasIndex("ProductId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("LearnMVC1.Models.RoleModel", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("roleId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnName("roleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("LearnMVC1.Models.SellerModel", b =>
                {
                    b.Property<int>("SellerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("sellerId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SellerImage")
                        .HasColumnName("sellerImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerName")
                        .IsRequired()
                        .HasColumnName("sellerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoreId")
                        .HasColumnName("id_Seller_Store")
                        .HasColumnType("int");

                    b.Property<int>("sellerStatus")
                        .HasColumnName("sellerStatus")
                        .HasColumnType("int");

                    b.HasKey("SellerId");

                    b.HasIndex("StoreId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("LearnMVC1.Models.StoreModel", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("storeId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("StoreCreateDate")
                        .HasColumnName("storeCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnName("storeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoreId");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("LearnMVC1.Models.WishListModel", b =>
                {
                    b.Property<int>("AccountId")
                        .HasColumnName("id_WishList_Account")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnName("id_WishList_Product")
                        .HasColumnType("int");

                    b.HasKey("AccountId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("WishList");
                });

            modelBuilder.Entity("LearnMVC1.Models.AccountModel", b =>
                {
                    b.HasOne("LearnMVC1.Models.RoleModel", "AccountRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearnMVC1.Models.SellerModel", "AccountSeller")
                        .WithMany()
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("LearnMVC1.Models.InventoryModel", b =>
                {
                    b.HasOne("LearnMVC1.Models.ProductModel", "InventoryProduct")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearnMVC1.Models.StoreModel", "InventoryStore")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LearnMVC1.Models.OrderItemModel", b =>
                {
                    b.HasOne("LearnMVC1.Models.OrderModel", "OrderItemOrder")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearnMVC1.Models.ProductModel", "OrderItemProduct")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LearnMVC1.Models.OrderModel", b =>
                {
                    b.HasOne("LearnMVC1.Models.AccountModel", "OrderAccount")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LearnMVC1.Models.ProductModel", b =>
                {
                    b.HasOne("LearnMVC1.Models.CategoryModel", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("LearnMVC1.Models.SellerModel", "ProductSeller")
                        .WithMany()
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("LearnMVC1.Models.ReceiptModel", b =>
                {
                    b.HasOne("LearnMVC1.Models.OrderModel", "ReceiptOrder")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LearnMVC1.Models.ReviewModel", b =>
                {
                    b.HasOne("LearnMVC1.Models.AccountModel", "ReviewAccount")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearnMVC1.Models.ProductModel", "ReviewProduct")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LearnMVC1.Models.SellerModel", b =>
                {
                    b.HasOne("LearnMVC1.Models.StoreModel", "SellerStore")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LearnMVC1.Models.WishListModel", b =>
                {
                    b.HasOne("LearnMVC1.Models.AccountModel", "WishListAccount")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearnMVC1.Models.ProductModel", "WishListProduct")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
