using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class CreatViewBrandStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                Create View BrandStock as
                select  b.Id,Max(b.Name) as 'Name',Max(b.Image) as 'Image',Sum(prod.StockCount) as 'StockCount' 
                from dbo.Products prod
	                Join dbo.ProductBrands b on b.Id = prod.BrandId
                Group By b.Id
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop View BrandStock");
        }
    }
}
