using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoManagementSystem.DAL.Migrations
{
    public partial class CargoCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Register",
                columns: table => new
                {
                    CustMailId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilNum = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register", x => x.CustMailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Register");
        }
    }
}
