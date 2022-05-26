using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class AddSoteredProcedur__us_ColorForMegaCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                create PROCEDURE us_ColorForMegaCategory
                @id int
                as
                select  Distinct(c.Id),c.Name, c.Code
                from dbo.SubCategoryToProducts p
	                Join dbo.ProductSubCategories s on s.Id = p.SubCategoryId
	                Join dbo.ProductCategories ca on ca.Id =  s.CategoryId
	                Join dbo.ProductStock f on f.ProductId = p.ProductId
	                join dbo.ProductColors c on c.Id = f.ColorId
                WHERE 
                     ca.MegaCategoryId = @id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(" DROP PROCEDURE us_ColorForMegaCategory");
        }
    }
}
