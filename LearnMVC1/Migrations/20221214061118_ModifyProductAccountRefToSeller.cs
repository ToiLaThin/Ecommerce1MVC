using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnMVC1.Migrations
{
    public partial class ModifyProductAccountRefToSeller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_Product_Seller",
                table: "Product",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_Account_Seller",
                table: "Account",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_id_Product_Seller",
                table: "Product",
                column: "id_Product_Seller");

            migrationBuilder.CreateIndex(
                name: "IX_Account_id_Account_Seller",
                table: "Account",
                column: "id_Account_Seller");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Seller_id_Account_Seller",
                table: "Account",
                column: "id_Account_Seller",
                principalTable: "Seller",
                principalColumn: "sellerId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Seller_id_Product_Seller",
                table: "Product",
                column: "id_Product_Seller",
                principalTable: "Seller",
                principalColumn: "sellerId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Seller_id_Account_Seller",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Seller_id_Product_Seller",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_id_Product_Seller",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Account_id_Account_Seller",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "id_Product_Seller",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "id_Account_Seller",
                table: "Account");
        }
    }
}
