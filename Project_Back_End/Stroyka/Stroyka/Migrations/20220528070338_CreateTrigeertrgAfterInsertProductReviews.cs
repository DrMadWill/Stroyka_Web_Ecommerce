using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class CreateTrigeertrgAfterInsertProductReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                    create trigger trgAfterInsertProductReviews on 
                    dbo.ProductReviews
                    AFTER insert
                    as 
                    declare @productId int;
                    declare @revCount int;
                    select @productId=y.ProductId from inserted y
                    select @revCount=COUNT(r.Id) from dbo.ProductReviews r where r.ProductId = @productId
                    update Products set ReviewCount = (@revCount) where Id =@productId
                    print('Ater Insert Trigger Review Count Add')
                    go
                ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop Trigger trgAfterInsertProductReviews");
        }
    }
}
