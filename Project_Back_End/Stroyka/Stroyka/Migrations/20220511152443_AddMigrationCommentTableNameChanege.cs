using Microsoft.EntityFrameworkCore.Migrations;

namespace Stroyka.Migrations
{
    public partial class AddMigrationCommentTableNameChanege : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Comments_ParentId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "BlogComments");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserId",
                table: "BlogComments",
                newName: "IX_BlogComments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ParentId",
                table: "BlogComments",
                newName: "IX_BlogComments_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_BlogId",
                table: "BlogComments",
                newName: "IX_BlogComments_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogComments",
                table: "BlogComments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_AspNetUsers_UserId",
                table: "BlogComments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_BlogComments_ParentId",
                table: "BlogComments",
                column: "ParentId",
                principalTable: "BlogComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComments_Blogs_BlogId",
                table: "BlogComments",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_AspNetUsers_UserId",
                table: "BlogComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_BlogComments_ParentId",
                table: "BlogComments");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogComments_Blogs_BlogId",
                table: "BlogComments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogComments",
                table: "BlogComments");

            migrationBuilder.RenameTable(
                name: "BlogComments",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_BlogComments_UserId",
                table: "Comments",
                newName: "IX_Comments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogComments_ParentId",
                table: "Comments",
                newName: "IX_Comments_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogComments_BlogId",
                table: "Comments",
                newName: "IX_Comments_BlogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Comments_ParentId",
                table: "Comments",
                column: "ParentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
