using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class AddStoreName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StoreName",
                table: "Store",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StoreName",
                table: "Store");
        }
    }
}
