using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class ChangeTableNames2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_MegaCategories_MegaCategoryId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStock_Colors_ColorId",
                table: "ProductStock");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Reviews_ParentId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategoryToProducts_SubCategories_SubCategoryId",
                table: "SubCategoryToProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MegaCategories",
                table: "MegaCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colors",
                table: "Colors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "SubCategories",
                newName: "ProductSubCategories");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "ProductReviews");

            migrationBuilder.RenameTable(
                name: "MegaCategories",
                newName: "ProductMegaCategories");

            migrationBuilder.RenameTable(
                name: "Colors",
                newName: "ProductColors");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "ProductCategories");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategories_Name",
                table: "ProductSubCategories",
                newName: "IX_ProductSubCategories_Name");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategories_CategoryId",
                table: "ProductSubCategories",
                newName: "IX_ProductSubCategories_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_UserId",
                table: "ProductReviews",
                newName: "IX_ProductReviews_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_ProductId",
                table: "ProductReviews",
                newName: "IX_ProductReviews_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_ParentId",
                table: "ProductReviews",
                newName: "IX_ProductReviews_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_MegaCategories_Name",
                table: "ProductMegaCategories",
                newName: "IX_ProductMegaCategories_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Colors_Name",
                table: "ProductColors",
                newName: "IX_ProductColors_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_Name",
                table: "ProductCategories",
                newName: "IX_ProductCategories_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_MegaCategoryId",
                table: "ProductCategories",
                newName: "IX_ProductCategories_MegaCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSubCategories",
                table: "ProductSubCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductReviews",
                table: "ProductReviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductMegaCategories",
                table: "ProductMegaCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_ProductMegaCategories_MegaCategoryId",
                table: "ProductCategories",
                column: "MegaCategoryId",
                principalTable: "ProductMegaCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_AspNetUsers_UserId",
                table: "ProductReviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_ProductReviews_ParentId",
                table: "ProductReviews",
                column: "ParentId",
                principalTable: "ProductReviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_Products_ProductId",
                table: "ProductReviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStock_ProductColors_ColorId",
                table: "ProductStock",
                column: "ColorId",
                principalTable: "ProductColors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategories_ProductCategories_CategoryId",
                table: "ProductSubCategories",
                column: "CategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategoryToProducts_ProductSubCategories_SubCategoryId",
                table: "SubCategoryToProducts",
                column: "SubCategoryId",
                principalTable: "ProductSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_ProductMegaCategories_MegaCategoryId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_AspNetUsers_UserId",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_ProductReviews_ParentId",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_Products_ProductId",
                table: "ProductReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStock_ProductColors_ColorId",
                table: "ProductStock");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategories_ProductCategories_CategoryId",
                table: "ProductSubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategoryToProducts_ProductSubCategories_SubCategoryId",
                table: "SubCategoryToProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSubCategories",
                table: "ProductSubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductReviews",
                table: "ProductReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductMegaCategories",
                table: "ProductMegaCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductColors",
                table: "ProductColors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories");

            migrationBuilder.RenameTable(
                name: "ProductSubCategories",
                newName: "SubCategories");

            migrationBuilder.RenameTable(
                name: "ProductReviews",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "ProductMegaCategories",
                newName: "MegaCategories");

            migrationBuilder.RenameTable(
                name: "ProductColors",
                newName: "Colors");

            migrationBuilder.RenameTable(
                name: "ProductCategories",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategories_Name",
                table: "SubCategories",
                newName: "IX_SubCategories_Name");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategories_CategoryId",
                table: "SubCategories",
                newName: "IX_SubCategories_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReviews_UserId",
                table: "Reviews",
                newName: "IX_Reviews_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReviews_ProductId",
                table: "Reviews",
                newName: "IX_Reviews_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductReviews_ParentId",
                table: "Reviews",
                newName: "IX_Reviews_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductMegaCategories_Name",
                table: "MegaCategories",
                newName: "IX_MegaCategories_Name");

            migrationBuilder.RenameIndex(
                name: "IX_ProductColors_Name",
                table: "Colors",
                newName: "IX_Colors_Name");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_Name",
                table: "Categories",
                newName: "IX_Categories_Name");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_MegaCategoryId",
                table: "Categories",
                newName: "IX_Categories_MegaCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MegaCategories",
                table: "MegaCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colors",
                table: "Colors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_MegaCategories_MegaCategoryId",
                table: "Categories",
                column: "MegaCategoryId",
                principalTable: "MegaCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStock_Colors_ColorId",
                table: "ProductStock",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Reviews_ParentId",
                table: "Reviews",
                column: "ParentId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategoryToProducts_SubCategories_SubCategoryId",
                table: "SubCategoryToProducts",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
