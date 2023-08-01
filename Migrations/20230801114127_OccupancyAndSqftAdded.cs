using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_API.Migrations
{
    /// <inheritdoc />
    public partial class OccupancyAndSqftAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Occupancy",
                table: "villas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Sqft",
                table: "villas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Occupancy", "Sqft" },
                values: new object[] { new DateTime(2023, 8, 1, 17, 11, 27, 678, DateTimeKind.Local).AddTicks(5294), 10, 1200 });

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Occupancy", "Sqft" },
                values: new object[] { new DateTime(2023, 8, 1, 17, 11, 27, 678, DateTimeKind.Local).AddTicks(5311), 10, 1200 });

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Occupancy", "Sqft" },
                values: new object[] { new DateTime(2023, 8, 1, 17, 11, 27, 678, DateTimeKind.Local).AddTicks(5313), 10, 1200 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Occupancy",
                table: "villas");

            migrationBuilder.DropColumn(
                name: "Sqft",
                table: "villas");

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 8, 1, 16, 32, 0, 139, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 8, 1, 16, 32, 0, 139, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 8, 1, 16, 32, 0, 139, DateTimeKind.Local).AddTicks(2601));
        }
    }
}
