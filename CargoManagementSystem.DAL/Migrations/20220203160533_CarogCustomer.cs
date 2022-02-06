using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoManagementSystem.DAL.Migrations
{
    public partial class CarogCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customerDetails",
                columns: table => new
                {
                    CustId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustPincode = table.Column<int>(type: "int", nullable: false),
                    CustPhoneNum = table.Column<int>(type: "int", nullable: false),
                    ReceiverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiverId = table.Column<int>(type: "int", nullable: false),
                    ReceiverAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivertCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiverPincode = table.Column<int>(type: "int", nullable: false),
                    ReceiverPhoneNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerDetails", x => x.CustId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customerDetails");
        }
    }
}
