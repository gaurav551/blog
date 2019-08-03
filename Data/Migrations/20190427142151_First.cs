using Microsoft.EntityFrameworkCore.Migrations;

namespace blog.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentstbl_Profiles_profileId",
                table: "Commentstbl");

            migrationBuilder.DropIndex(
                name: "IX_Commentstbl_profileId",
                table: "Commentstbl");

            migrationBuilder.DropColumn(
                name: "CommentsId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "profileId",
                table: "Commentstbl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentsId",
                table: "Profiles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "profileId",
                table: "Commentstbl",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Commentstbl_profileId",
                table: "Commentstbl",
                column: "profileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentstbl_Profiles_profileId",
                table: "Commentstbl",
                column: "profileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
