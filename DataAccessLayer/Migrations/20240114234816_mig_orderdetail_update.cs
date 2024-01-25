using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_orderdetail_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Procducts_ProcductProductID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProcductProductID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ProcductProductID",
                table: "OrderDetails");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Procducts_ProductID",
                table: "OrderDetails",
                column: "ProductID",
                principalTable: "Procducts",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Procducts_ProductID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "ProcductProductID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProcductProductID",
                table: "OrderDetails",
                column: "ProcductProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Procducts_ProcductProductID",
                table: "OrderDetails",
                column: "ProcductProductID",
                principalTable: "Procducts",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
