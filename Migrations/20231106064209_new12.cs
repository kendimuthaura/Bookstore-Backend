using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore__Management_system.Migrations
{
    /// <inheritdoc />
    public partial class new12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookName",
                table: "Books",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Availability",
                table: "Books",
                newName: "AccountNumber");

            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Books",
                newName: "AccountName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Books",
                newName: "BookName");

            migrationBuilder.RenameColumn(
                name: "AccountNumber",
                table: "Books",
                newName: "Availability");

            migrationBuilder.RenameColumn(
                name: "AccountName",
                table: "Books",
                newName: "AuthorName");
        }
    }
}
