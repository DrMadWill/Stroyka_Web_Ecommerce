using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class ChangeConstraintKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_ProductDetails_ProductDetailId",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "ProductDetailId",
                table: "Reviews",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_ProductDetailId",
                table: "Reviews",
                newName: "IX_Reviews_ProductId");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Stars",
                table: "Products",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Stars",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Reviews",
                newName: "ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                newName: "IX_Reviews_ProductDetailId");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_ProductDetails_ProductDetailId",
                table: "Reviews",
                column: "ProductDetailId",
                principalTable: "ProductDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
