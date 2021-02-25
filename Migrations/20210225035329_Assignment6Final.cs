using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment5.Migrations
{
    public partial class Assignment6Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Books",
                newName: "AuthorLast");

            migrationBuilder.AddColumn<string>(
                name: "AuthorFirst",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorFirst",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "AuthorLast",
                table: "Books",
                newName: "Author");
        }
    }
}
