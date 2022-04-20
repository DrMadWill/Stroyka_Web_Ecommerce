using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class MegaCategoryAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorToProductDetail_Color_ColorId",
                table: "ColorToProductDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorToProductDetail_ProductDetail_ProductDetailId",
                table: "ColorToProductDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetail_Products_Id",
                table: "ProductDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_ProductDetail_ProductDetailId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Review_ParentId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_Category_CategoryId",
                table: "SubCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategoryToProduct_Products_ProductId",
                table: "SubCategoryToProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategoryToProduct_SubCategory_SubCategoryId",
                table: "SubCategoryToProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategoryToProduct",
                table: "SubCategoryToProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductDetail",
                table: "ProductDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorToProductDetail",
                table: "ColorToProductDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Color",
                table: "Color");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "SubCategoryToProduct",
                newName: "SubCategoryToProducts");

            migrationBuilder.RenameTable(
                name: "SubCategory",
                newName: "SubCategories");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "ProductDetail",
                newName: "ProductDetails");

            migrationBuilder.RenameTable(
                name: "ColorToProductDetail",
                newName: "ColorToProductDetails");

            migrationBuilder.RenameTable(
                name: "Color",
                newName: "Colors");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategoryToProduct_ProductId",
                table: "SubCategoryToProducts",
                newName: "IX_SubCategoryToProducts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategory_Name",
                table: "SubCategories",
                newName: "IX_SubCategories_Name");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategories",
                newName: "IX_SubCategories_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_ProductDetailId",
                table: "Reviews",
                newName: "IX_Reviews_ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_ParentId",
                table: "Reviews",
                newName: "IX_Reviews_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_ColorToProductDetail_ProductDetailId",
                table: "ColorToProductDetails",
                newName: "IX_ColorToProductDetails_ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Color_Name",
                table: "Colors",
                newName: "IX_Colors_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Category_Name",
                table: "Categories",
                newName: "IX_Categories_Name");

            migrationBuilder.AddColumn<int>(
                name: "MegaCategoryId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategoryToProducts",
                table: "SubCategoryToProducts",
                columns: new[] { "SubCategoryId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductDetails",
                table: "ProductDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorToProductDetails",
                table: "ColorToProductDetails",
                columns: new[] { "ColorId", "ProductDetailId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colors",
                table: "Colors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MegaCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MegaCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ProductDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_ProductDetails_ProductDetailId",
                        column: x => x.ProductDetailId,
                        principalTable: "ProductDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MegaCategoryId",
                table: "Categories",
                column: "MegaCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MegaCategories_Name",
                table: "MegaCategories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductDetailId",
                table: "ProductImages",
                column: "ProductDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_MegaCategories_MegaCategoryId",
                table: "Categories",
                column: "MegaCategoryId",
                principalTable: "MegaCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ColorToProductDetails_Colors_ColorId",
                table: "ColorToProductDetails",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColorToProductDetails_ProductDetails_ProductDetailId",
                table: "ColorToProductDetails",
                column: "ProductDetailId",
                principalTable: "ProductDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_Id",
                table: "ProductDetails",
                column: "Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_ProductDetails_ProductDetailId",
                table: "Reviews",
                column: "ProductDetailId",
                principalTable: "ProductDetails",
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
                name: "FK_SubCategoryToProducts_Products_ProductId",
                table: "SubCategoryToProducts",
                column: "ProductId",
                principalTable: "Products",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_MegaCategories_MegaCategoryId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorToProductDetails_Colors_ColorId",
                table: "ColorToProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorToProductDetails_ProductDetails_ProductDetailId",
                table: "ColorToProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_Id",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_ProductDetails_ProductDetailId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Reviews_ParentId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategoryToProducts_Products_ProductId",
                table: "SubCategoryToProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategoryToProducts_SubCategories_SubCategoryId",
                table: "SubCategoryToProducts");

            migrationBuilder.DropTable(
                name: "MegaCategories");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategoryToProducts",
                table: "SubCategoryToProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductDetails",
                table: "ProductDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorToProductDetails",
                table: "ColorToProductDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colors",
                table: "Colors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_MegaCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "MegaCategoryId",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "SubCategoryToProducts",
                newName: "SubCategoryToProduct");

            migrationBuilder.RenameTable(
                name: "SubCategories",
                newName: "SubCategory");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "ProductDetails",
                newName: "ProductDetail");

            migrationBuilder.RenameTable(
                name: "ColorToProductDetails",
                newName: "ColorToProductDetail");

            migrationBuilder.RenameTable(
                name: "Colors",
                newName: "Color");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategoryToProducts_ProductId",
                table: "SubCategoryToProduct",
                newName: "IX_SubCategoryToProduct_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategories_Name",
                table: "SubCategory",
                newName: "IX_SubCategory_Name");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategory",
                newName: "IX_SubCategory_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_ProductDetailId",
                table: "Review",
                newName: "IX_Review_ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_ParentId",
                table: "Review",
                newName: "IX_Review_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_ColorToProductDetails_ProductDetailId",
                table: "ColorToProductDetail",
                newName: "IX_ColorToProductDetail_ProductDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Colors_Name",
                table: "Color",
                newName: "IX_Color_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_Name",
                table: "Category",
                newName: "IX_Category_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategoryToProduct",
                table: "SubCategoryToProduct",
                columns: new[] { "SubCategoryId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductDetail",
                table: "ProductDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorToProductDetail",
                table: "ColorToProductDetail",
                columns: new[] { "ColorId", "ProductDetailId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Color",
                table: "Color",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ColorToProductDetail_Color_ColorId",
                table: "ColorToProductDetail",
                column: "ColorId",
                principalTable: "Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColorToProductDetail_ProductDetail_ProductDetailId",
                table: "ColorToProductDetail",
                column: "ProductDetailId",
                principalTable: "ProductDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetail_Products_Id",
                table: "ProductDetail",
                column: "Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_ProductDetail_ProductDetailId",
                table: "Review",
                column: "ProductDetailId",
                principalTable: "ProductDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Review_ParentId",
                table: "Review",
                column: "ParentId",
                principalTable: "Review",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_Category_CategoryId",
                table: "SubCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategoryToProduct_Products_ProductId",
                table: "SubCategoryToProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategoryToProduct_SubCategory_SubCategoryId",
                table: "SubCategoryToProduct",
                column: "SubCategoryId",
                principalTable: "SubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
