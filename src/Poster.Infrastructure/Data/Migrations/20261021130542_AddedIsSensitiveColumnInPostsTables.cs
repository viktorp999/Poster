using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poster.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsSensitiveColumnInPostsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSensitive",
                table: "VideoPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSensitive",
                table: "StandardPosts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSensitive",
                table: "VideoPosts");

            migrationBuilder.DropColumn(
                name: "IsSensitive",
                table: "StandardPosts");
        }
    }
}
