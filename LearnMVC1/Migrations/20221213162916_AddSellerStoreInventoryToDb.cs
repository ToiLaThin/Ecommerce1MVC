using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnMVC1.Migrations
{
    public partial class AddSellerStoreInventoryToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    storeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    storeName = table.Column<string>(nullable: false),
                    storeCreateDate = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now.ToLocalTime())
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.storeId);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    inventoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Inventory_Store = table.Column<int>(nullable: false),
                    id_Inventory_Product = table.Column<int>(nullable: false),
                    inventoryProductAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.inventoryId);
                    table.ForeignKey(
                        name: "FK_Inventory_Product_id_Inventory_Product",
                        column: x => x.id_Inventory_Product,
                        principalTable: "Product",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventory_Store_id_Inventory_Store",
                        column: x => x.id_Inventory_Store,
                        principalTable: "Store",
                        principalColumn: "storeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seller",
                columns: table => new
                {
                    sellerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sellerName = table.Column<string>(nullable: false),
                    sellerImage = table.Column<string>(nullable: true),
                    sellerStatus = table.Column<int>(nullable: false, defaultValue: 1),
                    id_Seller_Store = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller", x => x.sellerId);
                    table.ForeignKey(
                        name: "FK_Seller_Store_id_Seller_Store",
                        column: x => x.id_Seller_Store,
                        principalTable: "Store",
                        principalColumn: "storeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_id_Inventory_Product",
                table: "Inventory",
                column: "id_Inventory_Product");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_id_Inventory_Store",
                table: "Inventory",
                column: "id_Inventory_Store");

            migrationBuilder.CreateIndex(
                name: "IX_Seller_id_Seller_Store",
                table: "Seller",
                column: "id_Seller_Store");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Seller");

            migrationBuilder.DropTable(
                name: "Store");
        }
    }
}
