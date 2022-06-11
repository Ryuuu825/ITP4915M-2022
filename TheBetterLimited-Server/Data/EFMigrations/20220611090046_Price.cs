using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class Price : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Supplier_Goods",
                type: "DECIMAL(8,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(7,2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Supplier_Goods",
                type: "DECIMAL(7,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(8,2)",
                oldNullable: true);
        }
    }
}
