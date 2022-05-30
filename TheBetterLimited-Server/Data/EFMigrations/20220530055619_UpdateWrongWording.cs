using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class UpdateWrongWording : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GTINNode",
                table: "Goods",
                newName: "GTINCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GTINCode",
                table: "Goods",
                newName: "GTINNode");
        }
    }
}
