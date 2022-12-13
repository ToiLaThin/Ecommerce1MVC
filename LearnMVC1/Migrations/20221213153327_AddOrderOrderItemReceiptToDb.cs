using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnMVC1.Migrations
{
    public partial class AddOrderOrderItemReceiptToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "productPrice",
                table: "Product",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 6)");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    orderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Order_Account = table.Column<int>(nullable: false),
                    orderBuyDate = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now.ToLocalTime()),
                    orderStatus = table.Column<int>(nullable: false, defaultValue: 0),
                    orderPhone = table.Column<string>(nullable: false),
                    orderAddress = table.Column<string>(nullable: false),
                    orderTotalPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.orderId);
                    table.ForeignKey(
                        name: "FK_Order_Account_id_Order_Account",
                        column: x => x.id_Order_Account,
                        principalTable: "Account",
                        principalColumn: "accountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    orderItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_OrderItem_Order = table.Column<int>(nullable: false),
                    id_OrderItem_Product = table.Column<int>(nullable: false),
                    orderItemQuantity = table.Column<int>(nullable: false),
                    orderItemUnitPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.orderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_id_OrderItem_Order",
                        column: x => x.id_OrderItem_Order,
                        principalTable: "Order",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_id_OrderItem_Product",
                        column: x => x.id_OrderItem_Product,
                        principalTable: "Product",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    receiptId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Receipt_Order = table.Column<int>(nullable: false),
                    receiptReleaseDate = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now.ToLocalTime())
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.receiptId);
                    table.ForeignKey(
                        name: "FK_Receipt_Order_id_Receipt_Order",
                        column: x => x.id_Receipt_Order,
                        principalTable: "Order",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_id_Order_Account",
                table: "Order",
                column: "id_Order_Account");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_id_OrderItem_Order",
                table: "OrderItem",
                column: "id_OrderItem_Order");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_id_OrderItem_Product",
                table: "OrderItem",
                column: "id_OrderItem_Product");

            migrationBuilder.CreateIndex(
                name: "IX_Receipt_id_Receipt_Order",
                table: "Receipt",
                column: "id_Receipt_Order");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Receipt");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.AlterColumn<decimal>(
                name: "productPrice",
                table: "Product",
                type: "decimal(18, 6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }
    }
}
