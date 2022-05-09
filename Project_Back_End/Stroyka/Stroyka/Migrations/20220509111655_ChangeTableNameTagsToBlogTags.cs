using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class ChangeTableNameTagsToBlogTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogToTags_Tags_TagId",
                table: "BlogToTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "BlogTags");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_Name",
                table: "BlogTags",
                newName: "IX_BlogTags_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogTags",
                table: "BlogTags",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogToTags_BlogTags_TagId",
                table: "BlogToTags",
                column: "TagId",
                principalTable: "BlogTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogToTags_BlogTags_TagId",
                table: "BlogToTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogTags",
                table: "BlogTags");

            migrationBuilder.RenameTable(
                name: "BlogTags",
                newName: "Tags");

            migrationBuilder.RenameIndex(
                name: "IX_BlogTags_Name",
                table: "Tags",
                newName: "IX_Tags_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogToTags_Tags_TagId",
                table: "BlogToTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
