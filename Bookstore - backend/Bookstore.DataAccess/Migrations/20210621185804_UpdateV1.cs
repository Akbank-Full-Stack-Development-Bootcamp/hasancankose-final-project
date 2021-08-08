using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.DataAccess.Migrations
{
    public partial class UpdateV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
