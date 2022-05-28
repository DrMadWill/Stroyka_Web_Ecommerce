using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class CreateProcedure_us_MaterialByMegaCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                create procedure us_MaterialByMegaCategory
                @id int
                as
                select DISTINCT(m.Id),m.Name
                from dbo.SubCategoryToProducts p
	                Join dbo.ProductSubCategories s on s.Id = p.SubCategoryId
	                Join dbo.ProductCategories ca on ca.Id =  s.CategoryId
	                Join dbo.ProductStock sto on sto.ProductId = p.ProductId
	                Join dbo.ProductMaterials m on m.Id = sto.MaterialId
                Where ca.MegaCategoryId = @id
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop Procedure us_MaterialByMegaCategory");
        }
    }
}
