using Microsoft.EntityFrameworkCore.Migrations;

namespace blog.Migrations
{
    public partial class tablenamechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentstbl_Posts_PostId",
                table: "Commentstbl");

            migrationBuilder.DropForeignKey(
                name: "FK_Repliestbl_Commentstbl_CommentId",
                table: "Repliestbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Repliestbl",
                table: "Repliestbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Commentstbl",
                table: "Commentstbl");

            migrationBuilder.RenameTable(
                name: "Repliestbl",
                newName: "Replies");

            migrationBuilder.RenameTable(
                name: "Commentstbl",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Repliestbl_CommentId",
                table: "Replies",
                newName: "IX_Replies_CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_Commentstbl_PostId",
                table: "Comments",
                newName: "IX_Comments_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Replies",
                table: "Replies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Comments_CommentId",
                table: "Replies",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Comments_CommentId",
                table: "Replies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Replies",
                table: "Replies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Replies",
                newName: "Repliestbl");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Commentstbl");

            migrationBuilder.RenameIndex(
                name: "IX_Replies_CommentId",
                table: "Repliestbl",
                newName: "IX_Repliestbl_CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostId",
                table: "Commentstbl",
                newName: "IX_Commentstbl_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Repliestbl",
                table: "Repliestbl",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commentstbl",
                table: "Commentstbl",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentstbl_Posts_PostId",
                table: "Commentstbl",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Repliestbl_Commentstbl_CommentId",
                table: "Repliestbl",
                column: "CommentId",
                principalTable: "Commentstbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
