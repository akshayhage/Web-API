using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web_API.Migrations
{
    /// <inheritdoc />
    public partial class DateAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "villas",
                columns: new[] { "Id", "CreatedTime", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 1, 16, 32, 0, 139, DateTimeKind.Local).AddTicks(2579), "Royal Home" },
                    { 2, new DateTime(2023, 8, 1, 16, 32, 0, 139, DateTimeKind.Local).AddTicks(2597), "Shree Home" },
                    { 3, new DateTime(2023, 8, 1, 16, 32, 0, 139, DateTimeKind.Local).AddTicks(2601), "Sprash Home" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
