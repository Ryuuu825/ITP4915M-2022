using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBetterLimited_Server.Data.EFMigrations
{
    public partial class CleanUP1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestockRequest_Supplier_Goods_Supplier_Goods__supplierGoodsId",
                table: "RestockRequest_Supplier_Goods");

            migrationBuilder.RenameColumn(
                name: "_supplierGoodsId",
                table: "RestockRequest_Supplier_Goods",
                newName: "_supplierGoodsStockId");

            migrationBuilder.RenameIndex(
                name: "IX_RestockRequest_Supplier_Goods__supplierGoodsId",
                table: "RestockRequest_Supplier_Goods",
                newName: "IX_RestockRequest_Supplier_Goods__supplierGoodsStockId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestockRequest_Supplier_Goods_Supplier_Goods_Stock__supplier~",
                table: "RestockRequest_Supplier_Goods",
                column: "_supplierGoodsStockId",
                principalTable: "Supplier_Goods_Stock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestockRequest_Supplier_Goods_Supplier_Goods_Stock__supplier~",
                table: "RestockRequest_Supplier_Goods");

            migrationBuilder.RenameColumn(
                name: "_supplierGoodsStockId",
                table: "RestockRequest_Supplier_Goods",
                newName: "_supplierGoodsId");

            migrationBuilder.RenameIndex(
                name: "IX_RestockRequest_Supplier_Goods__supplierGoodsStockId",
                table: "RestockRequest_Supplier_Goods",
                newName: "IX_RestockRequest_Supplier_Goods__supplierGoodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestockRequest_Supplier_Goods_Supplier_Goods__supplierGoodsId",
                table: "RestockRequest_Supplier_Goods",
                column: "_supplierGoodsId",
                principalTable: "Supplier_Goods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
