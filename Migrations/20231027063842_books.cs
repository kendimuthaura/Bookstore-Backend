using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore__Management_system.Migrations
{
    /// <inheritdoc />
    public partial class books : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Books",
                newName: "BookName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Books",
                newName: "Availability");

            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "BookName",
                table: "Books",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Availability",
                table: "Books",
                newName: "Description");
        }
    }
}
