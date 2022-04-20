using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class CreateTableCategoryType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryTypeId",
                table: "MegaCategories",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MegaCategories_CategoryTypeId",
                table: "MegaCategories",
                column: "CategoryTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MegaCategories_CategoryType_CategoryTypeId",
                table: "MegaCategories",
                column: "CategoryTypeId",
                principalTable: "CategoryType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MegaCategories_CategoryType_CategoryTypeId",
                table: "MegaCategories");

            migrationBuilder.DropTable(
                name: "CategoryType");

            migrationBuilder.DropIndex(
                name: "IX_MegaCategories_CategoryTypeId",
                table: "MegaCategories");

            migrationBuilder.DropColumn(
                name: "CategoryTypeId",
                table: "MegaCategories");
        }
    }
}
