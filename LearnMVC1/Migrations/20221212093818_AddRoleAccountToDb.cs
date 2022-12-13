using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnMVC1.Migrations
{
    public partial class AddRoleAccountToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    roleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    accountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountUserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    accountEmail = table.Column<string>(nullable: true),
                    accountFullName = table.Column<string>(nullable: true),
                    accountPassword = table.Column<string>(nullable: false),
                    accountImage = table.Column<string>(nullable: true),
                    accountPhone = table.Column<string>(nullable: true),
                    accountStatus = table.Column<int>(nullable: false, defaultValue: 0),
                    accountCode = table.Column<string>(nullable: true),
                    id_Account_Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.accountId);
                    table.ForeignKey(
                        name: "FK_Account_Role_id_Account_Role",
                        column: x => x.id_Account_Role,
                        principalTable: "Role",
                        principalColumn: "roleId",
                        onDelete: ReferentialAction.Cascade);
                    table.UniqueConstraint("UNIQUE_accountUserName", acc => acc.accountUserName);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_id_Account_Role",
                table: "Account",
                column: "id_Account_Role");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
