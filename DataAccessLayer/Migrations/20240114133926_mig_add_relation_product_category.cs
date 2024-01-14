using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_relation_product_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Procducts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Procducts_CategoryID",
                table: "Procducts",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Procducts_Categories_CategoryID",
                table: "Procducts",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Procducts_Categories_CategoryID",
                table: "Procducts");

            migrationBuilder.DropIndex(
                name: "IX_Procducts_CategoryID",
                table: "Procducts");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Procducts");
        }
    }
}
