using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class UpdateDataType1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Goods",
                type: "int(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Goods",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(1)")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
