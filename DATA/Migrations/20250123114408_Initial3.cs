using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DATA.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Members_ServiceId",
                table: "Members",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Services_ServiceId",
                table: "Members",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Services_ServiceId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_ServiceId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Members");
        }
    }
}
