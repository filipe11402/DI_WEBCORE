using Microsoft.EntityFrameworkCore.Migrations;

namespace Product_CQRS.Migrations
{
    public partial class FixedAutoMapper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Productname",
                table: "Orders",
                newName: "ProductName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Orders",
                newName: "Productname");
        }
    }
}
