using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class DefectItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HandleStatus",
                table: "DefectItemRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "_customerId",
                table: "DefectItemRecord",
                type: "char(10)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_DefectItemRecord__customerId",
                table: "DefectItemRecord",
                column: "_customerId");

            migrationBuilder.AddForeignKey(
                name: "FK_DefectItemRecord_Customer__customerId",
                table: "DefectItemRecord",
                column: "_customerId",
                principalTable: "Customer",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DefectItemRecord_Customer__customerId",
                table: "DefectItemRecord");

            migrationBuilder.DropIndex(
                name: "IX_DefectItemRecord__customerId",
                table: "DefectItemRecord");

            migrationBuilder.DropColumn(
                name: "HandleStatus",
                table: "DefectItemRecord");

            migrationBuilder.DropColumn(
                name: "_customerId",
                table: "DefectItemRecord");
        }
    }
}
