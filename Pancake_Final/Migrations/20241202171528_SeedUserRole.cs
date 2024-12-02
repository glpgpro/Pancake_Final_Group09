using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pancake_Final.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 3, 1, 15, 27, 816, DateTimeKind.Local).AddTicks(8119), new DateTime(2024, 12, 3, 1, 15, 27, 816, DateTimeKind.Local).AddTicks(8128) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Song",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 3, 0, 51, 46, 412, DateTimeKind.Local).AddTicks(6159), new DateTime(2024, 12, 3, 0, 51, 46, 412, DateTimeKind.Local).AddTicks(6176) });
        }
    }
}
