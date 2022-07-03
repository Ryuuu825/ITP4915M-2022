using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class dkfjsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestockRequest_Location__storeId",
                table: "RestockRequest");

            migrationBuilder.RenameColumn(
                name: "_storeId",
                table: "RestockRequest",
                newName: "_locationId");

            migrationBuilder.RenameIndex(
                name: "IX_RestockRequest__storeId",
                table: "RestockRequest",
                newName: "IX_RestockRequest__locationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestockRequest_Location__locationId",
                table: "RestockRequest",
                column: "_locationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestockRequest_Location__locationId",
                table: "RestockRequest");

            migrationBuilder.RenameColumn(
                name: "_locationId",
                table: "RestockRequest",
                newName: "_storeId");

            migrationBuilder.RenameIndex(
                name: "IX_RestockRequest__locationId",
                table: "RestockRequest",
                newName: "IX_RestockRequest__storeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestockRequest_Location__storeId",
                table: "RestockRequest",
                column: "_storeId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
