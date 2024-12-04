using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pancake_Final.Migrations
{
    /// <inheritdoc />
    public partial class AdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 3, 19, 13, 0, 454, DateTimeKind.Local).AddTicks(2780), new DateTime(2024, 12, 3, 19, 13, 0, 454, DateTimeKind.Local).AddTicks(2791) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 3, 1, 15, 27, 816, DateTimeKind.Local).AddTicks(8119), new DateTime(2024, 12, 3, 1, 15, 27, 816, DateTimeKind.Local).AddTicks(8128) });
        }
    }
}
