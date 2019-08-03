using Microsoft.EntityFrameworkCore.Migrations;

namespace blog.Migrations
{
    public partial class Firs1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "profilePhotoName",
                table: "Commentstbl",
                newName: "PhotoName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoName",
                table: "Commentstbl",
                newName: "profilePhotoName");
        }
    }
}
