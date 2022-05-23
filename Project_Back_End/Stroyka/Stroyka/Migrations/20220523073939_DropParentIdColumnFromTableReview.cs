using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class DropParentIdColumnFromTableReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReviews_ProductReviews_ParentId",
                table: "ProductReviews");

            migrationBuilder.DropIndex(
                name: "IX_ProductReviews_ParentId",
                table: "ProductReviews");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "ProductReviews");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "ProductReviews",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ParentId",
                table: "ProductReviews",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReviews_ProductReviews_ParentId",
                table: "ProductReviews",
                column: "ParentId",
                principalTable: "ProductReviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
