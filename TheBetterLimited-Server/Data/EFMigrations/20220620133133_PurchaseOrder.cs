using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class PurchaseOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "_supplierId",
                table: "PurchaseOrder",
                type: "char(5)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder__supplierId",
                table: "PurchaseOrder",
                column: "_supplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrder_Supplier__supplierId",
                table: "PurchaseOrder",
                column: "_supplierId",
                principalTable: "Supplier",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrder_Supplier__supplierId",
                table: "PurchaseOrder");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrder__supplierId",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "_supplierId",
                table: "PurchaseOrder");
        }
    }
}
