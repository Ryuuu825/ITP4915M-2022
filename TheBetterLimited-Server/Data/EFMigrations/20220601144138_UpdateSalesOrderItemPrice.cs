using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class UpdateSalesOrderItemPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "SalesOrderItem",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "SalesOrderItem");
        }
    }
}
