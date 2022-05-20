using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class ChangeTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Statuses_StatusId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStock_Materials_MaterialId",
                table: "ProductStock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materials",
                table: "Materials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brands",
                table: "Brands");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "ProductStatuses");

            migrationBuilder.RenameTable(
                name: "Materials",
                newName: "ProductMaterials");

            migrationBuilder.RenameTable(
                name: "Brands",
                newName: "ProductBrands");

            migrationBuilder.RenameIndex(
                name: "IX_Statuses_Name",
                table: "ProductStatuses",
                newName: "IX_ProductStatuses_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Materials_Name",
                table: "ProductMaterials",
                newName: "IX_ProductMaterials_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Brands_Name",
                table: "ProductBrands",
                newName: "IX_ProductBrands_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductStatuses",
                table: "ProductStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductMaterials",
                table: "ProductMaterials",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductBrands",
                table: "ProductBrands",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductBrands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "ProductBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductStatuses_StatusId",
                table: "Products",
                column: "StatusId",
                principalTable: "ProductStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStock_ProductMaterials_MaterialId",
                table: "ProductStock",
                column: "MaterialId",
                principalTable: "ProductMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductBrands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductStatuses_StatusId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStock_ProductMaterials_MaterialId",
                table: "ProductStock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductStatuses",
                table: "ProductStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductMaterials",
                table: "ProductMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductBrands",
                table: "ProductBrands");

            migrationBuilder.RenameTable(
                name: "ProductStatuses",
                newName: "Statuses");

            migrationBuilder.RenameTable(
                name: "ProductMaterials",
                newName: "Materials");

            migrationBuilder.RenameTable(
                name: "ProductBrands",
                newName: "Brands");

            migrationBuilder.RenameIndex(
                name: "IX_ProductStatuses_Name",
                table: "Statuses",
                newName: "IX_Statuses_Name");

            migrationBuilder.RenameIndex(
                name: "IX_ProductMaterials_Name",
                table: "Materials",
                newName: "IX_Materials_Name");

            migrationBuilder.RenameIndex(
                name: "IX_ProductBrands_Name",
                table: "Brands",
                newName: "IX_Brands_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materials",
                table: "Materials",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brands",
                table: "Brands",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Statuses_StatusId",
                table: "Products",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStock_Materials_MaterialId",
                table: "ProductStock",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
