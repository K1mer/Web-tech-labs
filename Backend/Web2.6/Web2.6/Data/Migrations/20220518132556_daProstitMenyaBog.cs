using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web2._6.Data.Migrations
{
    public partial class daProstitMenyaBog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttachedFiles_Replies_ReplyId",
                table: "AttachedFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Topics_TopicId",
                table: "Replies");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Forums_ForumCategoryId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_ForumCategoryId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Replies_TopicId",
                table: "Replies");

            migrationBuilder.DropIndex(
                name: "IX_AttachedFiles_ReplyId",
                table: "AttachedFiles");

            migrationBuilder.DropColumn(
                name: "ForumCategoryId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "ReplyId",
                table: "AttachedFiles");

            migrationBuilder.AddColumn<int>(
                name: "ParentForumId",
                table: "Topics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentTopicId",
                table: "Replies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentReplyId",
                table: "AttachedFiles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentForumId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "ParentTopicId",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "ParentReplyId",
                table: "AttachedFiles");

            migrationBuilder.AddColumn<int>(
                name: "ForumCategoryId",
                table: "Topics",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Replies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReplyId",
                table: "AttachedFiles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topics_ForumCategoryId",
                table: "Topics",
                column: "ForumCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_TopicId",
                table: "Replies",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_AttachedFiles_ReplyId",
                table: "AttachedFiles",
                column: "ReplyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttachedFiles_Replies_ReplyId",
                table: "AttachedFiles",
                column: "ReplyId",
                principalTable: "Replies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Topics_TopicId",
                table: "Replies",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Forums_ForumCategoryId",
                table: "Topics",
                column: "ForumCategoryId",
                principalTable: "Forums",
                principalColumn: "Id");
        }
    }
}
