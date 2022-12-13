using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnMVC1.Migrations
{
    public partial class AddWishListReviewToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    reviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reviewContent = table.Column<string>(nullable: false),
                    reviewDateCreated = table.Column<DateTime>(nullable: false , defaultValue: DateTime.Now.ToLocalTime()),
                    id_Review_Account = table.Column<int>(nullable: false),
                    id_Review_Product = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.reviewId);
                    table.ForeignKey(
                        name: "FK_Review_Account_id_Review_Account",
                        column: x => x.id_Review_Account,
                        principalTable: "Account",
                        principalColumn: "accountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_Product_id_Review_Product",
                        column: x => x.id_Review_Product,
                        principalTable: "Product",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishList",
                columns: table => new
                {
                    id_WishList_Account = table.Column<int>(nullable: false),
                    id_WishList_Product = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    //composite key using fluent api
                    table.PrimaryKey("PK_WishList", x => new { x.id_WishList_Account, x.id_WishList_Product });
                    table.ForeignKey(
                        name: "FK_WishList_Account_id_WishList_Account",
                        column: x => x.id_WishList_Account,
                        principalTable: "Account",
                        principalColumn: "accountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishList_Product_id_WishList_Product",
                        column: x => x.id_WishList_Product,
                        principalTable: "Product",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_id_Review_Account",
                table: "Review",
                column: "id_Review_Account");

            migrationBuilder.CreateIndex(
                name: "IX_Review_id_Review_Product",
                table: "Review",
                column: "id_Review_Product");

            migrationBuilder.CreateIndex(
                name: "IX_WishList_id_WishList_Product",
                table: "WishList",
                column: "id_WishList_Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "WishList");
        }
    }
}
