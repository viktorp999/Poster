using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poster.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedUniqueIndexInNameColumnInPermissionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IXPermissionName",
                table: "Permissions",
                column: "Name",
                unique: true)
                .Annotation("SqlServer:Clustered", false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IXPermissionName",
                table: "Permissions");
        }
    }
}
