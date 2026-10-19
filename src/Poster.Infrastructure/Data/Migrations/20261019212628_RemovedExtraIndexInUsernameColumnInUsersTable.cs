using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poster.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedExtraIndexInUsernameColumnInUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IXUsername",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IXUsername",
                table: "Users",
                column: "Username",
                unique: true);
        }
    }
}
