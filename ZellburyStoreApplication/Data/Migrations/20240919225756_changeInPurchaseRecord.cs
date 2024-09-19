using Microsoft.EntityFrameworkCore.Migrations;

namespace ZellburyStoreApplication.Data.Migrations
{
    public partial class changeInPurchaseRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_purchaseRecords_ProductId",
                table: "purchaseRecords",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_purchaseRecords_Products_ProductId",
                table: "purchaseRecords",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_purchaseRecords_Products_ProductId",
                table: "purchaseRecords");

            migrationBuilder.DropIndex(
                name: "IX_purchaseRecords_ProductId",
                table: "purchaseRecords");
        }
    }
}
