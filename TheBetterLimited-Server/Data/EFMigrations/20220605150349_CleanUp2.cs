using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class CleanUp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SaleOrderItem_Appointment__salesOrderItemId",
                table: "SaleOrderItem_Appointment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderItem_Appointment__salesOrderItemId",
                table: "SaleOrderItem_Appointment",
                column: "_salesOrderItemId");
        }
    }
}
