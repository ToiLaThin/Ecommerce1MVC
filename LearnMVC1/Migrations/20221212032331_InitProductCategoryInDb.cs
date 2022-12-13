using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnMVC1.Migrations
{
    public partial class InitProductCategoryInDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    categoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(nullable: false),
                    categoryImage = table.Column<string>(nullable: true),
                    categoryStatus = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    productId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(nullable: false),
                    productCode = table.Column<string>(nullable: true),
                    id_Product_Category = table.Column<int>(nullable: true),
                    productDescription = table.Column<string>(nullable: false),
                    productPrice = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    productImage = table.Column<string>(nullable: true),
                    productStatus = table.Column<int>(nullable: false, defaultValue: 0),
                    productModifiedDate = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now.ToLocalTime()),
                    productRevenue = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.productId);
                    table.ForeignKey(
                        name: "FK_Product_Category_id_Product_Category",
                        column: x => x.id_Product_Category,
                        principalTable: "Category",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_id_Product_Category",
                table: "Product",
                column: "id_Product_Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
