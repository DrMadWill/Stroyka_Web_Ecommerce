using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class AddSoteredProcedur__us_MaxMinPriceForMegaCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                create PROCEDURE us_MaxMinPriceForMegaCategory
                @id int
                as
                select  Max(prod.CurrentPrice) as CurrentPrice, MIN(prod.CurrentPrice) as OldPrice
                from dbo.SubCategoryToProducts p
	                Join dbo.ProductSubCategories s on s.Id = p.SubCategoryId
	                Join dbo.ProductCategories ca on ca.Id =  s.CategoryId
	                Join dbo.Products prod on prod.Id = p.ProductId
                WHERE 
                     ca.MegaCategoryId = @id
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE us_MaxMinPriceForMegaCategory");
        }
    }
}
