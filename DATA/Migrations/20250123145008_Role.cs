using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DATA.Migrations
{
    /// <inheritdoc />
    public partial class Role : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25c814b1-16ef-46a6-8dc0-74325130da69", null, "Admin", "ADMIN" },
                    { "cec042c2-0f73-401c-9900-869116cc939c", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1558f1c0-5418-49ab-9158-ea7135ffa5cc", 0, "b4761146-13e5-4e09-b68a-542b4dab7d0e", null, false, false, null, null, "FIZARET", "AQAAAAIAAYagAAAAEKuQW7CBmgHb9qImZT7dOm06Kmn/JOiXpMo8YVJBMYniJsC1JjL08eJMyk7hZuGHMA==", null, false, "5e7b4ecb-ffed-4c61-8568-e113ab61514b", false, "fizaret" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "25c814b1-16ef-46a6-8dc0-74325130da69", "1558f1c0-5418-49ab-9158-ea7135ffa5cc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cec042c2-0f73-401c-9900-869116cc939c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "25c814b1-16ef-46a6-8dc0-74325130da69", "1558f1c0-5418-49ab-9158-ea7135ffa5cc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25c814b1-16ef-46a6-8dc0-74325130da69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1558f1c0-5418-49ab-9158-ea7135ffa5cc");
        }
    }
}
