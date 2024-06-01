using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreApp.Migrations
{
    /// <inheritdoc />
    public partial class IdentityRoleSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "956a89d2-519e-4deb-9a23-d5798dd90d7f", null, "Editor", "EDİTOR" },
                    { "c674f5fd-8afb-4029-ba04-77eda2a28322", null, "Admin", "ADMIN" },
                    { "f1425e37-4cf7-475f-8dc6-8754b3785a8e", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "956a89d2-519e-4deb-9a23-d5798dd90d7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c674f5fd-8afb-4029-ba04-77eda2a28322");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1425e37-4cf7-475f-8dc6-8754b3785a8e");
        }
    }
}
