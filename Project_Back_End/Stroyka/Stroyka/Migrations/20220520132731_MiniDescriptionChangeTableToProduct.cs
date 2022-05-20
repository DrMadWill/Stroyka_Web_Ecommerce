using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class MiniDescriptionChangeTableToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MiniDecription",
                table: "ProductDetails");

            migrationBuilder.AddColumn<string>(
                name: "MiniDecription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MiniDecription",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "MiniDecription",
                table: "ProductDetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
