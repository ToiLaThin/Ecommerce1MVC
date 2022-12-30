using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnMVC1.Migrations
{
    public partial class AddStatusToOrderItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Seller_id_Account_Seller",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Seller_id_Product_Seller",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "id_Product_Seller",
                table: "Product",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "orderItemStatus",
                table: "OrderItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "id_Account_Seller",
                table: "Account",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Seller_id_Account_Seller",
                table: "Account",
                column: "id_Account_Seller",
                principalTable: "Seller",
                principalColumn: "sellerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Seller_id_Product_Seller",
                table: "Product",
                column: "id_Product_Seller",
                principalTable: "Seller",
                principalColumn: "sellerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Seller_id_Account_Seller",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Seller_id_Product_Seller",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "orderItemStatus",
                table: "OrderItem");

            migrationBuilder.AlterColumn<int>(
                name: "id_Product_Seller",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id_Account_Seller",
                table: "Account",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Seller_id_Account_Seller",
                table: "Account",
                column: "id_Account_Seller",
                principalTable: "Seller",
                principalColumn: "sellerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Seller_id_Product_Seller",
                table: "Product",
                column: "id_Product_Seller",
                principalTable: "Seller",
                principalColumn: "sellerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
