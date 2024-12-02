using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pancake_Final.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 3, 0, 41, 5, 873, DateTimeKind.Local).AddTicks(360), new DateTime(2024, 12, 3, 0, 41, 5, 873, DateTimeKind.Local).AddTicks(371) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 3, 0, 38, 38, 568, DateTimeKind.Local).AddTicks(2938), new DateTime(2024, 12, 3, 0, 38, 38, 568, DateTimeKind.Local).AddTicks(2947) });
        }
    }
}
