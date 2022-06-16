using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class DefectItem1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DefectItemRecord_SalesOrder__salesOrderId",
                table: "DefectItemRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DefectItemRecord",
                table: "DefectItemRecord");

            migrationBuilder.DropIndex(
                name: "IX_DefectItemRecord__salesOrderId",
                table: "DefectItemRecord");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "DefectItemRecord");

            migrationBuilder.UpdateData(
                table: "DefectItemRecord",
                keyColumn: "_salesOrderId",
                keyValue: null,
                column: "_salesOrderId",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "_salesOrderId",
                table: "DefectItemRecord",
                type: "char(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(10)",
                oldMaxLength: 10,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DefectItemRecord",
                table: "DefectItemRecord",
                columns: new[] { "_salesOrderId", "_supplierGoodsStockId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DefectItemRecord_SalesOrder__salesOrderId",
                table: "DefectItemRecord",
                column: "_salesOrderId",
                principalTable: "SalesOrder",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DefectItemRecord_SalesOrder__salesOrderId",
                table: "DefectItemRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DefectItemRecord",
                table: "DefectItemRecord");

            migrationBuilder.AlterColumn<string>(
                name: "_salesOrderId",
                table: "DefectItemRecord",
                type: "char(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(10)",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ID",
                table: "DefectItemRecord",
                type: "char(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DefectItemRecord",
                table: "DefectItemRecord",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_DefectItemRecord__salesOrderId",
                table: "DefectItemRecord",
                column: "_salesOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_DefectItemRecord_SalesOrder__salesOrderId",
                table: "DefectItemRecord",
                column: "_salesOrderId",
                principalTable: "SalesOrder",
                principalColumn: "ID");
        }
    }
}
