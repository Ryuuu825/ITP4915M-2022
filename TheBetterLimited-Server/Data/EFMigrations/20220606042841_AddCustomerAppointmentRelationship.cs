using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class AddCustomerAppointmentRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "_customerId",
                table: "Appointment",
                type: "char(10)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment__customerId",
                table: "Appointment",
                column: "_customerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Customer__customerId",
                table: "Appointment",
                column: "_customerId",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Customer__customerId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment__customerId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "_customerId",
                table: "Appointment");
        }
    }
}
