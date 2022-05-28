using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class UpdateGoodsPrice1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Goods",
                type: "MEDIUMINT",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "SMALLINT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Price",
                table: "Goods",
                type: "SMALLINT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "MEDIUMINT");
        }
    }
}
