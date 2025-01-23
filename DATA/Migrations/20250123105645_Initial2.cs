using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DATA.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "Profession",
                table: "Services",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Members",
                newName: "Profession");

            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "Members");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Services",
                newName: "Profession");

            migrationBuilder.RenameColumn(
                name: "Profession",
                table: "Members",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
