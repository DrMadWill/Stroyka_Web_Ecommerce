using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class AddContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_SubCategory_SubCategoryId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_BlogCategories_BlogCategoryId",
                table: "SubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory");

            migrationBuilder.RenameTable(
                name: "SubCategory",
                newName: "BlogSubCategories");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategory_BlogCategoryId",
                table: "BlogSubCategories",
                newName: "IX_BlogSubCategories_BlogCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogSubCategories",
                table: "BlogSubCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogSubCategories_SubCategoryId",
                table: "Blogs",
                column: "SubCategoryId",
                principalTable: "BlogSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogSubCategories_BlogCategories_BlogCategoryId",
                table: "BlogSubCategories",
                column: "BlogCategoryId",
                principalTable: "BlogCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogSubCategories_SubCategoryId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogSubCategories_BlogCategories_BlogCategoryId",
                table: "BlogSubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogSubCategories",
                table: "BlogSubCategories");

            migrationBuilder.RenameTable(
                name: "BlogSubCategories",
                newName: "SubCategory");

            migrationBuilder.RenameIndex(
                name: "IX_BlogSubCategories_BlogCategoryId",
                table: "SubCategory",
                newName: "IX_SubCategory_BlogCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_SubCategory_SubCategoryId",
                table: "Blogs",
                column: "SubCategoryId",
                principalTable: "SubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_BlogCategories_BlogCategoryId",
                table: "SubCategory",
                column: "BlogCategoryId",
                principalTable: "BlogCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
