using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pancake_Final.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPlaylistDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    AlbumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistID = table.Column<int>(type: "int", nullable: false),
                    GenID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlbumImage = table.Column<byte>(type: "tinyint", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.AlbumID);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "ListeningHistory",
                columns: table => new
                {
                    HistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListeningHistory", x => x.HistoryId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playlist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaylistID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PlaylistName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubStatus = table.Column<int>(type: "int", nullable: false),
                    SubPlans = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ASPNetUserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlayListID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_AspNetUsers_ASPNetUserID",
                        column: x => x.ASPNetUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    AlbumID = table.Column<int>(type: "int", nullable: false),
                    GenID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LikedS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    ArtistsArtistID = table.Column<int>(type: "int", nullable: true),
                    PlaylistId = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Song_Artists_ArtistsArtistID",
                        column: x => x.ArtistsArtistID,
                        principalTable: "Artists",
                        principalColumn: "ArtistID");
                    table.ForeignKey(
                        name: "FK_Song_Playlist_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlist",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c5549082-86f9-4891-9f90-fb288ab76e70", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPM4fTBJYPGzajsdLp8mJGPDD+KzSmARppHJyzGkfj6j2NOjisJ4lWRsVlm4peVuvA==", null, false, "19debf91-f480-4f4c-920a-62585822afc1", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumID", "ArtistId", "ArtistsArtistID", "CreatedBy", "DateCreated", "DateUpdated", "Duration", "FilePath", "GenID", "Id", "LikedS", "Name", "PlaylistId", "UpdateBy" },
                values: new object[,]
                {
                    { 1, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2130), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2140), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Don Toliver - No Pole", null, "Seeder" },
                    { 2, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2148), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2148), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人", null, "Seeder" },
                    { 3, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2150), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2150), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Goblin Slayer - Rightfully _ Mili [Full]", null, "Seeder" },
                    { 4, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2152), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2153), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Goblins from Mars  - Put Your Love In Dreamz", null, "Seeder" },
                    { 5, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2154), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2154), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Goblins from Mars - Cold Blooded Love (ft. Krista Marina)", null, "Seeder" },
                    { 6, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2157), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2157), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Goblins from Mars - Heart Afire When The Bassjumps", null, "Seeder" },
                    { 7, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2159), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2159), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC]", null, "Seeder" },
                    { 8, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2160), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2161), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC]", null, "Seeder" },
                    { 9, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2162), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2163), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "grandson - Despicable", null, "Seeder" },
                    { 10, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2164), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2165), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Greatest Battle Music Of All Times Saijaku Muhai", null, "Seeder" },
                    { 11, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2166), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2166), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Gundam - OP1 HD", null, "Seeder" },
                    { 12, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2167), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2168), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Gundam - Seed", null, "Seeder" },
                    { 13, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2169), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2169), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Hans Zimmer - Flight", null, "Seeder" },
                    { 14, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2171), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2171), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music", null, "Seeder" },
                    { 15, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2172), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2173), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Hiroyuki Sawano Impure King Suite Epic Battle Music", null, "Seeder" },
                    { 16, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2174), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2174), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "HOPE", null, "Seeder" },
                    { 17, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2176), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2176), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "HOTD - Pentakill ", null, "Seeder" },
                    { 18, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2178), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2179), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "i feel like i did too much Don Toliver - No Idea (Lyrics)", null, "Seeder" },
                    { 19, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2180), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2180), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "I NEED U (Official MV)", null, "Seeder" },
                    { 20, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2182), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2182), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "IDOL Official MV", null, "Seeder" },
                    { 21, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2183), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2184), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix]", null, "Seeder" },
                    { 22, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2185), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2185), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Imagine Dragons - Believer", null, "Seeder" },
                    { 23, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2187), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2187), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "ISLAND OST - Island Opening Full「Eien no Hitotsu」", null, "Seeder" },
                    { 24, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2188), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "ISLAND OST - Lasting Memories FULL", null, "Seeder" },
                    { 25, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2190), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2190), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "J.Fla  - Havana", null, "Seeder" },
                    { 26, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2192), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2192), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Jacob Lee - Demons", null, "Seeder" },
                    { 27, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2220), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2220), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Jaden - GOKU", null, "Seeder" },
                    { 28, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2222), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2223), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Justin Stone - Lungs (Prod. Alex Collins)", null, "Seeder" },
                    { 29, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2224), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2224), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kaguya-Sama - Love is war (feat. Masayuki Suzuki) ", null, "Seeder" },
                    { 30, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2226), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2226), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki", null, "Seeder" },
                    { 31, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2227), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2228), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kakusei [Awakening]", null, "Seeder" },
                    { 32, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2229), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2229), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kamikaze Feat. Lox Chatterbox", null, "Seeder" },
                    { 33, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2230), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2231), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KANA-BOON - Silhouette", null, "Seeder" },
                    { 34, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2233), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2233), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends", null, "Seeder" },
                    { 35, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2235), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2235), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP", null, "Seeder" },
                    { 36, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2236), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2237), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "khai dreams - sunkissed", null, "Seeder" },
                    { 37, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2240), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2240), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kibou No Uta Lyrics", null, "Seeder" },
                    { 38, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2241), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2242), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Krewella - Calm Down (SKAN Remix)", null, "Seeder" },
                    { 39, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2243), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2244), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KSI & Randolph - Champagne (Official Audio)", null, "Seeder" },
                    { 40, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2245), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2246), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KUURO - Afraid of the Dark (feat. Sophiya) ", null, "Seeder" },
                    { 41, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2248), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2248), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KUURO - What U Wanna Do", null, "Seeder" },
                    { 42, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2249), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2250), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LAYTO - Little Poor Me", null, "Seeder" },
                    { 43, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2252), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2252), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends", null, "Seeder" },
                    { 44, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2254), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2255), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST - Hope", null, "Seeder" },
                    { 45, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2256), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2257), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST", null, "Seeder" },
                    { 46, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2258), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2259), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Liam Ferrari - I Like The Way", null, "Seeder" },
                    { 47, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2260), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2261), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Lil Nas X Billy Ray Cyrus - Old Town Road (Remix)", null, "Seeder" },
                    { 48, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2262), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2263), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LIL SKIES - Boss Up", null, "Seeder" },
                    { 49, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2264), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2265), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LIL SKIES - Lust", null, "Seeder" },
                    { 50, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2266), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2267), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Lil Uzi Vert - XO Tour Llif3 ", null, "Seeder" },
                    { 51, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2269), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2269), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Lilianna Wilde - Grind Me Down (Jawster Remix)", null, "Seeder" },
                    { 52, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2271), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2271), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LiSA - Catch the Moment", null, "Seeder" },
                    { 53, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2273), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2273), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LiSA - Crossing Field", null, "Seeder" },
                    { 54, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2275), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2275), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Look Alive [BASS BOOSTED]", null, "Seeder" },
                    { 55, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2277), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2277), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Lyrics Owari no Seraph OST - 108", null, "Seeder" },
                    { 56, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2279), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2279), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ", null, "Seeder" },
                    { 57, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2281), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2281), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Magnolia", null, "Seeder" },
                    { 58, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2283), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2283), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Maroon 5 - Sugar", null, "Seeder" },
                    { 59, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2284), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2285), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Maroon 5 Ft. Wiz Khalifa", null, "Seeder" },
                    { 60, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2287), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2287), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "MHW ICEBORNE Safi Jiiva Battle Theme OST", null, "Seeder" },
                    { 61, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2289), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2289), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "MIC Drop (Steve Aoki Remix) Official MV", null, "Seeder" },
                    { 62, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2291), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2291), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Migos - Get Right Witcha (G-REX X TOP $HELF Remix)", null, "Seeder" },
                    { 63, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2293), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2293), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura", null, "Seeder" },
                    { 64, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2295), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Moonlight", null, "Seeder" },
                    { 65, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2327), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2327), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records", null, "Seeder" },
                    { 66, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2332), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2332), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Mrs. GREEN APPLE - インフェルノInferno", null, "Seeder" },
                    { 67, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2334), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2334), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2)", null, "Seeder" },
                    { 68, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2336), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2336), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version)", null, "Seeder" },
                    { 69, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2338), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2339), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Namirin  - Renai Circulation「恋愛サーキュレーショ", null, "Seeder" },
                    { 70, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2341), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2341), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Nanatsu no Taizai S2 - Escanor Theme (Rearrangement)", null, "Seeder" },
                    { 71, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2343), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2343), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "NEFFEX - Fight Back", null, "Seeder" },
                    { 72, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2345), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2346), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "NEFFEX - Myself", null, "Seeder" },
                    { 73, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2347), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2347), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro)", null, "Seeder" },
                    { 74, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2349), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2349), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Nightcore - Control", null, "Seeder" },
                    { 75, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2351), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2351), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Nightcore - Rockefeller Street", null, "Seeder" },
                    { 76, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2353), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2354), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "No Game No Life Opening Full", null, "Seeder" },
                    { 77, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2355), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2356), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Not Today Official MV", null, "Seeder" },
                    { 78, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2358), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2358), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Nto - Trauma (Worakls Remix)", null, "Seeder" },
                    { 79, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2360), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2360), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Owari no Seraph OST - 1hundredknight M [終わりのセラフ]", null, "Seeder" },
                    { 80, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2362), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2363), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack", null, "Seeder" },
                    { 81, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2365), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2365), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Post Malone - Better Now", null, "Seeder" },
                    { 82, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2367), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2367), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Post Malone_ 21 Savage - Rockstar", null, "Seeder" },
                    { 83, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2369), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2369), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Reverse feat. G-Eazy", null, "Seeder" },
                    { 84, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2371), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2371), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Rich The Kid - Plug Walk (Audio)", null, "Seeder" },
                    { 85, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2373), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2374), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Right Now", null, "Seeder" },
                    { 86, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2376), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2376), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends", null, "Seeder" },
                    { 87, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2378), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2379), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST", null, "Seeder" },
                    { 88, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2380), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2381), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SAD!", null, "Seeder" },
                    { 89, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2382), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2383), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut  - Saijaku Muhai OST", null, "Seeder" },
                    { 90, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2385), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2385), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only)", null, "Seeder" },
                    { 91, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2387), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2388), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sakura - 落ち着いて冷やす", null, "Seeder" },
                    { 92, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2389), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2390), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SAMAHTA - graffiti (feat. Melody Federer)", null, "Seeder" },
                    { 93, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2392), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2392), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte", null, "Seeder" },
                    { 94, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2394), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2394), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shawn Mendes - Mercy", null, "Seeder" },
                    { 95, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2396), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2396), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shawn Mendes - Stitches", null, "Seeder" },
                    { 96, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2398), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2399), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shawn Mendes - Theres Nothing Holdin Me Back", null, "Seeder" },
                    { 97, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2400), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2401), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shawn Mendes - Treat You Better", null, "Seeder" },
                    { 98, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2403), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2403), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sheck Wes - Mo Bamba", null, "Seeder" },
                    { 99, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2441), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2442), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte", null, "Seeder" },
                    { 100, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2444), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2444), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sickick - Infected", null, "Seeder" },
                    { 101, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2445), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sickick - Mind Games", null, "Seeder" },
                    { 102, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2447), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2447), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SickickMusic - Lost My Way", null, "Seeder" },
                    { 103, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2448), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2449), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Skan & Krale - No Glory (feat. M.I.M.E & Drama B)", null, "Seeder" },
                    { 104, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2450), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2450), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW", null, "Seeder" },
                    { 105, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2452), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2452), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SKRILLEX - Bangarang feat. Sirah", null, "Seeder" },
                    { 106, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2453), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2453), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix)", null, "Seeder" },
                    { 107, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2455), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2455), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Soredemo sekai wa utsukushii - Beautiful rain full ver.", null, "Seeder" },
                    { 108, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2457), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2457), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna]", null, "Seeder" },
                    { 109, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2458), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2459), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "STéLOUSE - Sociopath (feat. Bryce Fox)", null, "Seeder" },
                    { 110, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2460), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2460), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sufian Suhaimi - Di Matamu", null, "Seeder" },
                    { 111, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2461), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2462), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting", null, "Seeder" },
                    { 112, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2463), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2463), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub", null, "Seeder" },
                    { 113, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2465), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2465), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION", null, "Seeder" },
                    { 114, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2466), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2467), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TETRA-FANG - Supernova", null, "Seeder" },
                    { 115, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2468), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2468), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "The Mirza - Lelah Mengalah", null, "Seeder" },
                    { 116, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2469), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2470), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "The Soul of Wind -  🗻 The Mountains 🗻", null, "Seeder" },
                    { 117, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2471), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2471), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TheFatRat - Fly Away feat. Anjulie", null, "Seeder" },
                    { 118, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2472), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2473), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TheFatRat - Monody (feat. Laura Brehm)", null, "Seeder" },
                    { 119, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2474), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2474), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TheFatRat - Time Lapse", null, "Seeder" },
                    { 120, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2475), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2476), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TheFatRat - Unity", null, "Seeder" },
                    { 121, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2477), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2477), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TIIMO - Bangin In the Club", null, "Seeder" },
                    { 122, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2479), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2479), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-]", null, "Seeder" },
                    { 123, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2480), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2481), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (Marco B. Remix)", null, "Seeder" },
                    { 124, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2482), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2482), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (OP Piano) ", null, "Seeder" },
                    { 125, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2483), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2484), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel 2", null, "Seeder" },
                    { 126, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2485), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2485), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel", null, "Seeder" },
                    { 127, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2487), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2487), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Machine - FLY [Monstercat Release]", null, "Seeder" },
                    { 128, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2489), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2489), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Trapcity - Dead To Me (feat. Lox Chatterbox)", null, "Seeder" },
                    { 129, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2490), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2490), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Trapcity - Samurai☯ Lofi", null, "Seeder" },
                    { 130, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2508), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2509), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Trapcity - Trap Queen (Crankdat Remix)", null, "Seeder" },
                    { 131, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2510), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2510), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Travis Scott - SICKO MODE", null, "Seeder" },
                    { 132, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2511), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2512), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Two Feet - I Feel Like Im Drowning", null, "Seeder" },
                    { 133, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2513), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2513), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Unlike Pluto ft. Mike Taylor - Everything Black", null, "Seeder" },
                    { 134, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2515), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2515), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Wishing Lyrics Rem(minase inori) ReZero", null, "Seeder" },
                    { 135, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2516), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2517), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "XXXTENTACION - BAD!", null, "Seeder" },
                    { 136, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2518), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2518), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics]", null, "Seeder" },
                    { 137, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2519), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2520), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Yasuha - Flyday Chinatown", null, "Seeder" },
                    { 138, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2521), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2521), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "YOASOBI 夜に駆ける English & Romanji Lyrics", null, "Seeder" },
                    { 139, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2522), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2523), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "YOASOBIハルジオンOfficial Music Video", null, "Seeder" },
                    { 140, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2524), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2524), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Yuna - Longing", null, "Seeder" },
                    { 141, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2525), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2526), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Yuna - Smile for you ", null, "Seeder" },
                    { 142, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2527), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2527), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "タイニーリトルアシアンタム", null, "Seeder" },
                    { 143, 0, 1, null, "Seeder", new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2529), new DateTime(2025, 1, 30, 15, 27, 39, 886, DateTimeKind.Local).AddTicks(2529), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "レペゼン地球66thシングルO2MEN", null, "Seeder" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Song_ArtistsArtistID",
                table: "Song",
                column: "ArtistsArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_Song_PlaylistId",
                table: "Song",
                column: "PlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ASPNetUserID",
                table: "User",
                column: "ASPNetUserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "ListeningHistory");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Playlist");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
