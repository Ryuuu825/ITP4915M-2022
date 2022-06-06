using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class CleanUp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_saleOrderItem_Appointment_Appointment__appointmentId",
                table: "saleOrderItem_Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_saleOrderItem_Appointment_SalesOrderItem__salesOrderItemId",
                table: "saleOrderItem_Appointment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_saleOrderItem_Appointment",
                table: "saleOrderItem_Appointment");

            migrationBuilder.RenameTable(
                name: "saleOrderItem_Appointment",
                newName: "SaleOrderItem_Appointment");

            migrationBuilder.RenameIndex(
                name: "IX_saleOrderItem_Appointment__salesOrderItemId",
                table: "SaleOrderItem_Appointment",
                newName: "IX_SaleOrderItem_Appointment__salesOrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_saleOrderItem_Appointment__appointmentId",
                table: "SaleOrderItem_Appointment",
                newName: "IX_SaleOrderItem_Appointment__appointmentId");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "SalesOrderItem",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "_salesOrderItemId",
                table: "SaleOrderItem_Appointment",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleOrderItem_Appointment",
                table: "SaleOrderItem_Appointment",
                columns: new[] { "_salesOrderItemId", "_appointmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrderItem_Appointment_Appointment__appointmentId",
                table: "SaleOrderItem_Appointment",
                column: "_appointmentId",
                principalTable: "Appointment",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrderItem_Appointment_SalesOrderItem__salesOrderItemId",
                table: "SaleOrderItem_Appointment",
                column: "_salesOrderItemId",
                principalTable: "SalesOrderItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrderItem_Appointment_Appointment__appointmentId",
                table: "SaleOrderItem_Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrderItem_Appointment_SalesOrderItem__salesOrderItemId",
                table: "SaleOrderItem_Appointment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleOrderItem_Appointment",
                table: "SaleOrderItem_Appointment");

            migrationBuilder.RenameTable(
                name: "SaleOrderItem_Appointment",
                newName: "saleOrderItem_Appointment");

            migrationBuilder.RenameIndex(
                name: "IX_SaleOrderItem_Appointment__salesOrderItemId",
                table: "saleOrderItem_Appointment",
                newName: "IX_saleOrderItem_Appointment__salesOrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleOrderItem_Appointment__appointmentId",
                table: "saleOrderItem_Appointment",
                newName: "IX_saleOrderItem_Appointment__appointmentId");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "SalesOrderItem",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "_salesOrderItemId",
                table: "saleOrderItem_Appointment",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_saleOrderItem_Appointment",
                table: "saleOrderItem_Appointment",
                columns: new[] { "_salesOrderItemId", "_appointmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_saleOrderItem_Appointment_Appointment__appointmentId",
                table: "saleOrderItem_Appointment",
                column: "_appointmentId",
                principalTable: "Appointment",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_saleOrderItem_Appointment_SalesOrderItem__salesOrderItemId",
                table: "saleOrderItem_Appointment",
                column: "_salesOrderItemId",
                principalTable: "SalesOrderItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
