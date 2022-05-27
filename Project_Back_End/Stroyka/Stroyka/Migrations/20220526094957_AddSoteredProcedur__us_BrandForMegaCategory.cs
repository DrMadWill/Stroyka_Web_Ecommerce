using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class AddSoteredProcedur__us_BrandForMegaCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE FUNCTION udfBrandByMegaCategory( @id INT )
                RETURNS TABLE
                AS
                RETURN
                select  DISTINCT(prod.Id) as 'ProductId',b.Name as 'Name', b.Image as 'Image',prod.StockCount,b.Id 
                from dbo.SubCategoryToProducts p
	                Join dbo.ProductSubCategories s on s.Id = p.SubCategoryId
	                Join dbo.ProductCategories ca on ca.Id =  s.CategoryId
	                Join dbo.Products prod on prod.Id = p.ProductId
	                Join dbo.ProductBrands b on b.Id = prod.BrandId
                WHERE 
                     ca.MegaCategoryId = @id

                create PROCEDURE us_BrandForMegaCategory
                @id int
                as
                select Id, Max(Name) as 'Name',Max(Image) as 'Image', Count(StockCount) as 'StockCount' 
                from udfBrandByMegaCategory(@id) 
                Group By Id

            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE us_BrandForMegaCategory
                                   DROP FUNCTION dbo.udfBrandByMegaCategory");
        }
    }
}
