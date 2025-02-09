using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pancake_Final.Migrations
{
    /// <inheritdoc />
    public partial class FixingAuthorityissue : Migration
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
                    SubStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    GenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    UserId = table.Column<int>(type: "int", nullable: true),
                    SongId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatePlayed = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ASPNetUserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlayListID = table.Column<int>(type: "int", nullable: false),
                    SubId = table.Column<int>(type: "int", nullable: false),
                    SubStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_AspNetUsers_ASPNetUserID",
                        column: x => x.ASPNetUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Playlist",
                columns: table => new
                {
                    PlaylistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    GenreID = table.Column<int>(type: "int", nullable: false),
                    PlaylistName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewGenreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlist", x => x.PlaylistId);
                    table.ForeignKey(
                        name: "FK_Playlist_Genre_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genre",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: true),
                    AlbumID = table.Column<int>(type: "int", nullable: true),
                    GenID = table.Column<int>(type: "int", nullable: true),
                    PlaylistId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LikedS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArtistsArtistID = table.Column<int>(type: "int", nullable: true),
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
                        principalColumn: "PlaylistId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubStatus", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "30f01c03-6b69-4bf0-95ba-72ac6e7e4773", 0, "ad1d1655-47f3-44f2-950d-d2e9ffdaa976", "ghostreaper740@gmail.com", true, "Test", "user", false, null, "GHOSTREAPER740@GMAIL.COM", "GHOSTREAPER740@GMAIL.COM", "AQAAAAIAAYagAAAAEHgNOfQFPfCXIIS8esffq+2yurq+dbnkTJdalmv9hwzkNEElm0in9RdeLxut6HsA4w==", null, false, "03f48a7c-6724-448b-aa29-5b1227ebb071", "free", false, "Amsul Shamry" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "ce2ba749-d0da-413b-9d2e-2dea4b19993b", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGyg5UgH44t1J75aDX1awtJCjmkL0F1rTWpYAW06vpGqeDblpr062DrfnIcGheoI9A==", null, false, "e347b831-5130-4f21-b563-1652530b483a", "Premium", false, "admin@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreID", "CreatedBy", "DateCreated", "DateUpdated", "GenreName", "Id", "UpdateBy" },
                values: new object[] { 1, "System", new DateTime(2025, 2, 9, 12, 26, 27, 619, DateTimeKind.Utc).AddTicks(4323), new DateTime(2025, 2, 9, 12, 26, 27, 619, DateTimeKind.Utc).AddTicks(4328), "Liked Songs", 1, "System" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumID", "ArtistId", "ArtistsArtistID", "CreatedBy", "DateAdded", "DateCreated", "DateUpdated", "Duration", "FilePath", "GenID", "Id", "LikedS", "Name", "PlaylistId", "UpdateBy" },
                values: new object[,]
                {
                    { 1, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 520, DateTimeKind.Local).AddTicks(6077), new DateTime(2025, 2, 9, 20, 26, 27, 520, DateTimeKind.Local).AddTicks(6089), new TimeSpan(1877739166), "/music/Don Toliver - No Pole.mp3", 1, 0, "NotLiked", "Don Toliver - No Pole", null, "Seeder" },
                    { 2, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 520, DateTimeKind.Local).AddTicks(7384), new DateTime(2025, 2, 9, 20, 26, 27, 520, DateTimeKind.Local).AddTicks(7388), new TimeSpan(1297645833), "/music/Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人.mp3", 1, 0, "NotLiked", "Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人", null, "Seeder" },
                    { 3, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 520, DateTimeKind.Local).AddTicks(8905), new DateTime(2025, 2, 9, 20, 26, 27, 520, DateTimeKind.Local).AddTicks(8906), new TimeSpan(2111185000), "/music/Goblin Slayer - Rightfully _ Mili [Full].mp3", 1, 0, "NotLiked", "Goblin Slayer - Rightfully _ Mili [Full]", null, "Seeder" },
                    { 4, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 520, DateTimeKind.Local).AddTicks(9703), new DateTime(2025, 2, 9, 20, 26, 27, 520, DateTimeKind.Local).AddTicks(9704), new TimeSpan(1873305000), "/music/Goblins from Mars  - Put Your Love In Dreamz.mp3", 1, 0, "NotLiked", "Goblins from Mars  - Put Your Love In Dreamz", null, "Seeder" },
                    { 5, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(795), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(796), new TimeSpan(1812530833), "/music/Goblins from Mars - Cold Blooded Love (ft. Krista Marina).mp3", 1, 0, "NotLiked", "Goblins from Mars - Cold Blooded Love (ft. Krista Marina)", null, "Seeder" },
                    { 6, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(1521), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(1522), new TimeSpan(2091100833), "/music/Goblins from Mars - Heart Afire When The Bassjumps.mp3", 1, 0, "NotLiked", "Goblins from Mars - Heart Afire When The Bassjumps", null, "Seeder" },
                    { 7, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(2225), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(2225), new TimeSpan(2760920833), "/music/Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC].mp3", 1, 0, "NotLiked", "Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC]", null, "Seeder" },
                    { 8, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(2938), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(2939), new TimeSpan(2822477500), "/music/Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC].mp3", 1, 0, "NotLiked", "Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC]", null, "Seeder" },
                    { 9, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(3825), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(3825), new TimeSpan(2235863333), "/music/grandson - Despicable.mp3", 1, 0, "NotLiked", "grandson - Despicable", null, "Seeder" },
                    { 10, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(4506), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(4507), new TimeSpan(1464057500), "/music/Greatest Battle Music Of All Times Saijaku Muhai.mp3", 1, 0, "NotLiked", "Greatest Battle Music Of All Times Saijaku Muhai", null, "Seeder" },
                    { 11, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(5356), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(5357), new TimeSpan(916307500), "/music/Gundam - OP1 HD.mp3", 1, 0, "NotLiked", "Gundam - OP1 HD", null, "Seeder" },
                    { 12, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(6115), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(6115), new TimeSpan(0, 0, 3, 57, 567), "/music/Gundam - Seed.mp3", 1, 0, "NotLiked", "Gundam - Seed", null, "Seeder" },
                    { 13, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(6819), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(6819), new TimeSpan(2539995000), "/music/Hans Zimmer - Flight.mp3", 1, 0, "NotLiked", "Hans Zimmer - Flight", null, "Seeder" },
                    { 14, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(7503), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(7504), new TimeSpan(5451416666), "/music/Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music", null, "Seeder" },
                    { 15, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(8151), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(8151), new TimeSpan(0, 0, 8, 25, 182), "/music/Hiroyuki Sawano Impure King Suite Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano Impure King Suite Epic Battle Music", null, "Seeder" },
                    { 16, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(8934), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(8934), new TimeSpan(1010207500), "/music/HOPE.mp3", 1, 0, "NotLiked", "HOPE", null, "Seeder" },
                    { 17, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(9744), new DateTime(2025, 2, 9, 20, 26, 27, 521, DateTimeKind.Local).AddTicks(9745), new TimeSpan(2029805000), "/music/HOTD - Pentakill .mp3", 1, 0, "NotLiked", "HOTD - Pentakill ", null, "Seeder" },
                    { 18, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(465), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(465), new TimeSpan(1892867500), "/music/i feel like i did too much Don Toliver - No Idea (Lyrics).mp3", 1, 0, "NotLiked", "i feel like i did too much Don Toliver - No Idea (Lyrics)", null, "Seeder" },
                    { 19, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(1928), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(1930), new TimeSpan(2197520833), "/music/I NEED U (Official MV).mp3", 1, 0, "NotLiked", "I NEED U (Official MV)", null, "Seeder" },
                    { 20, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(3074), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(3074), new TimeSpan(2315417500), "/music/IDOL Official MV.mp3", 1, 0, "NotLiked", "IDOL Official MV", null, "Seeder" },
                    { 21, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(4243), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(4243), new TimeSpan(0, 0, 2, 43, 73), "/music/Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix].mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix]", null, "Seeder" },
                    { 22, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(5084), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(5085), new TimeSpan(2166742500), "/music/Imagine Dragons - Believer.mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer", null, "Seeder" },
                    { 23, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(6011), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(6012), new TimeSpan(0, 0, 5, 23, 329), "/music/ISLAND OST - Island Opening Full「Eien no Hitotsu」.mp3", 1, 0, "NotLiked", "ISLAND OST - Island Opening Full「Eien no Hitotsu」", null, "Seeder" },
                    { 24, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(6784), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(6784), new TimeSpan(3018363333), "/music/ISLAND OST - Lasting Memories FULL.mp3", 1, 0, "NotLiked", "ISLAND OST - Lasting Memories FULL", null, "Seeder" },
                    { 25, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(8167), new DateTime(2025, 2, 9, 20, 26, 27, 522, DateTimeKind.Local).AddTicks(8169), new TimeSpan(1347204166), "/music/J.Fla  - Havana.mp3", 1, 0, "NotLiked", "J.Fla  - Havana", null, "Seeder" },
                    { 26, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(684), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(696), new TimeSpan(0, 0, 4, 11, 652), "/music/Jacob Lee - Demons.mp3", 1, 0, "NotLiked", "Jacob Lee - Demons", null, "Seeder" },
                    { 27, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(2083), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(2084), new TimeSpan(0, 0, 3, 25, 641), "/music/Jaden - GOKU.mp3", 1, 0, "NotLiked", "Jaden - GOKU", null, "Seeder" },
                    { 28, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(3126), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(3127), new TimeSpan(0, 0, 2, 50, 898), "/music/Justin Stone - Lungs (Prod. Alex Collins).mp3", 1, 0, "NotLiked", "Justin Stone - Lungs (Prod. Alex Collins)", null, "Seeder" },
                    { 29, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(4308), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(4308), new TimeSpan(2634677500), "/music/Kaguya-Sama - Love is war (feat. Masayuki Suzuki) .mp3", 1, 0, "NotLiked", "Kaguya-Sama - Love is war (feat. Masayuki Suzuki) ", null, "Seeder" },
                    { 30, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(5040), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(5041), new TimeSpan(2541299166), "/music/Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki.mp3", 1, 0, "NotLiked", "Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki", null, "Seeder" },
                    { 31, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(5712), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(5713), new TimeSpan(2771615000), "/music/Kakusei [Awakening].mp3", 1, 0, "NotLiked", "Kakusei [Awakening]", null, "Seeder" },
                    { 32, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(6535), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(6536), new TimeSpan(1819312500), "/music/Kamikaze Feat. Lox Chatterbox.mp3", 1, 0, "NotLiked", "Kamikaze Feat. Lox Chatterbox", null, "Seeder" },
                    { 33, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(7153), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(7154), new TimeSpan(2651631666), "/music/KANA-BOON - Silhouette.mp3", 1, 0, "NotLiked", "KANA-BOON - Silhouette", null, "Seeder" },
                    { 34, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(8023), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(8027), new TimeSpan(2030065833), "/music/KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends.mp3", 1, 0, "NotLiked", "KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends", null, "Seeder" },
                    { 35, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(9085), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(9086), new TimeSpan(2423924166), "/music/Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP.mp3", 1, 0, "NotLiked", "Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP", null, "Seeder" },
                    { 36, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(9733), new DateTime(2025, 2, 9, 20, 26, 27, 523, DateTimeKind.Local).AddTicks(9734), new TimeSpan(1273127500), "/music/khai dreams - sunkissed.mp3", 1, 0, "NotLiked", "khai dreams - sunkissed", null, "Seeder" },
                    { 37, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(1249), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(1252), new TimeSpan(2328198333), "/music/Kibou No Uta Lyrics.mp3", 1, 0, "NotLiked", "Kibou No Uta Lyrics", null, "Seeder" },
                    { 38, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(2508), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(2510), new TimeSpan(2271597500), "/music/Krewella - Calm Down (SKAN Remix).mp3", 1, 0, "NotLiked", "Krewella - Calm Down (SKAN Remix)", null, "Seeder" },
                    { 39, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(3186), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(3187), new TimeSpan(2126574166), "/music/KSI & Randolph - Champagne (Official Audio).mp3", 1, 0, "NotLiked", "KSI & Randolph - Champagne (Official Audio)", null, "Seeder" },
                    { 40, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(4447), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(4447), new TimeSpan(2101273333), "/music/KUURO - Afraid of the Dark (feat. Sophiya) .mp3", 1, 0, "NotLiked", "KUURO - Afraid of the Dark (feat. Sophiya) ", null, "Seeder" },
                    { 41, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(5324), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(5324), new TimeSpan(1921298333), "/music/KUURO - What U Wanna Do.mp3", 1, 0, "NotLiked", "KUURO - What U Wanna Do", null, "Seeder" },
                    { 42, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(6603), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(6604), new TimeSpan(0, 0, 3, 19, 381), "/music/LAYTO - Little Poor Me.mp3", 1, 0, "NotLiked", "LAYTO - Little Poor Me", null, "Seeder" },
                    { 43, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(7485), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(7488), new TimeSpan(2351934166), "/music/Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends.mp3", 1, 0, "NotLiked", "Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends", null, "Seeder" },
                    { 44, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(8636), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(8637), new TimeSpan(1406674166), "/music/Leonhart - Grancrest Senki OST - Hope.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST - Hope", null, "Seeder" },
                    { 45, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(9807), new DateTime(2025, 2, 9, 20, 26, 27, 524, DateTimeKind.Local).AddTicks(9808), new TimeSpan(3110176666), "/music/Leonhart - Grancrest Senki OST.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST", null, "Seeder" },
                    { 46, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(575), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(575), new TimeSpan(1668811666), "/music/Liam Ferrari - I Like The Way.mp3", 1, 0, "NotLiked", "Liam Ferrari - I Like The Way", null, "Seeder" },
                    { 47, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(1570), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(1571), new TimeSpan(1570999166), "/music/Lil Nas X Billy Ray Cyrus - Old Town Road (Remix).mp3", 1, 0, "NotLiked", "Lil Nas X Billy Ray Cyrus - Old Town Road (Remix)", null, "Seeder" },
                    { 48, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(2351), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(2352), new TimeSpan(0, 0, 2, 44, 638), "/music/LIL SKIES - Boss Up.mp3", 1, 0, "NotLiked", "LIL SKIES - Boss Up", null, "Seeder" },
                    { 49, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(3014), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(3015), new TimeSpan(1561087499), "/music/LIL SKIES - Lust.mp3", 1, 0, "NotLiked", "LIL SKIES - Lust", null, "Seeder" },
                    { 50, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(3799), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(3799), new TimeSpan(1803140833), "/music/Lil Uzi Vert - XO Tour Llif3 .mp3", 1, 0, "NotLiked", "Lil Uzi Vert - XO Tour Llif3 ", null, "Seeder" },
                    { 51, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(4674), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(4675), new TimeSpan(2002939166), "/music/Lilianna Wilde - Grind Me Down (Jawster Remix).mp3", 1, 0, "NotLiked", "Lilianna Wilde - Grind Me Down (Jawster Remix)", null, "Seeder" },
                    { 52, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(5279), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(5279), new TimeSpan(0, 0, 4, 44, 204), "/music/LiSA - Catch the Moment.mp3", 1, 0, "NotLiked", "LiSA - Catch the Moment", null, "Seeder" },
                    { 53, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(5919), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(5919), new TimeSpan(2477916666), "/music/LiSA - Crossing Field.mp3", 1, 0, "NotLiked", "LiSA - Crossing Field", null, "Seeder" },
                    { 54, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(6619), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(6619), new TimeSpan(1852177500), "/music/Look Alive [BASS BOOSTED].mp3", 1, 0, "NotLiked", "Look Alive [BASS BOOSTED]", null, "Seeder" },
                    { 55, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(7258), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(7258), new TimeSpan(2581989166), "/music/Lyrics Owari no Seraph OST - 108.mp3", 1, 0, "NotLiked", "Lyrics Owari no Seraph OST - 108", null, "Seeder" },
                    { 56, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(7905), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(7906), new TimeSpan(2420794166), "/music/MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ.mp3", 1, 0, "NotLiked", "MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ", null, "Seeder" },
                    { 57, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(8659), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(8660), new TimeSpan(2044411666), "/music/Magnolia.mp3", 1, 0, "NotLiked", "Magnolia", null, "Seeder" },
                    { 58, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(9273), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(9274), new TimeSpan(2660760833), "/music/Maroon 5 - Sugar.mp3", 1, 0, "NotLiked", "Maroon 5 - Sugar", null, "Seeder" },
                    { 59, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(9858), new DateTime(2025, 2, 9, 20, 26, 27, 525, DateTimeKind.Local).AddTicks(9859), new TimeSpan(2326633333), "/music/Maroon 5 Ft. Wiz Khalifa.mp3", 1, 0, "NotLiked", "Maroon 5 Ft. Wiz Khalifa", null, "Seeder" },
                    { 60, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(472), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(473), new TimeSpan(3914847500), "/music/MHW ICEBORNE Safi Jiiva Battle Theme OST.mp3", 1, 0, "NotLiked", "MHW ICEBORNE Safi Jiiva Battle Theme OST", null, "Seeder" },
                    { 61, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(1334), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(1335), new TimeSpan(2741097500), "/music/MIC Drop (Steve Aoki Remix) Official MV.mp3", 1, 0, "NotLiked", "MIC Drop (Steve Aoki Remix) Official MV", null, "Seeder" },
                    { 62, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(1946), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(1946), new TimeSpan(2436444166), "/music/Migos - Get Right Witcha (G-REX X TOP $HELF Remix).mp3", 1, 0, "NotLiked", "Migos - Get Right Witcha (G-REX X TOP $HELF Remix)", null, "Seeder" },
                    { 63, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(2552), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(2552), new TimeSpan(2220995833), "/music/MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura.mp3", 1, 0, "NotLiked", "MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura", null, "Seeder" },
                    { 64, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(4114), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(4117), new TimeSpan(1660986666), "/music/Moonlight.mp3", 1, 0, "NotLiked", "Moonlight", null, "Seeder" },
                    { 65, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(4945), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(4945), new TimeSpan(2153700833), "/music/Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records.mp3", 1, 0, "NotLiked", "Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records", null, "Seeder" },
                    { 66, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(5642), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(5643), new TimeSpan(2213692500), "/music/Mrs. GREEN APPLE - インフェルノInferno.mp3", 1, 0, "NotLiked", "Mrs. GREEN APPLE - インフェルノInferno", null, "Seeder" },
                    { 67, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(6344), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(6345), new TimeSpan(4549455000), "/music/My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2).mp3", 1, 0, "NotLiked", "My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2)", null, "Seeder" },
                    { 68, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(7048), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(7048), new TimeSpan(1672463333), "/music/My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version).mp3", 1, 0, "NotLiked", "My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version)", null, "Seeder" },
                    { 69, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(7956), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(7958), new TimeSpan(2548863333), "/music/Namirin  - Renai Circulation「恋愛サーキュレーショ.mp3", 1, 0, "NotLiked", "Namirin  - Renai Circulation「恋愛サーキュレーショ", null, "Seeder" },
                    { 70, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(8712), new DateTime(2025, 2, 9, 20, 26, 27, 526, DateTimeKind.Local).AddTicks(8713), new TimeSpan(2596074166), "/music/Nanatsu no Taizai S2 - Escanor Theme (Rearrangement).mp3", 1, 0, "NotLiked", "Nanatsu no Taizai S2 - Escanor Theme (Rearrangement)", null, "Seeder" },
                    { 71, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(116), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(117), new TimeSpan(2005025833), "/music/NEFFEX - Fight Back.mp3", 1, 0, "NotLiked", "NEFFEX - Fight Back", null, "Seeder" },
                    { 72, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(907), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(907), new TimeSpan(1951815833), "/music/NEFFEX - Myself.mp3", 1, 0, "NotLiked", "NEFFEX - Myself", null, "Seeder" },
                    { 73, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(1622), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(1623), new TimeSpan(2091622500), "/music/Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro).mp3", 1, 0, "NotLiked", "Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro)", null, "Seeder" },
                    { 74, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(2641), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(2642), new TimeSpan(1901735833), "/music/Nightcore - Control.mp3", 1, 0, "NotLiked", "Nightcore - Control", null, "Seeder" },
                    { 75, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(3486), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(3487), new TimeSpan(1472925833), "/music/Nightcore - Rockefeller Street.mp3", 1, 0, "NotLiked", "Nightcore - Rockefeller Street", null, "Seeder" },
                    { 76, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(4099), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(4100), new TimeSpan(2801871666), "/music/No Game No Life Opening Full.mp3", 1, 0, "NotLiked", "No Game No Life Opening Full", null, "Seeder" },
                    { 77, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(5284), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(5284), new TimeSpan(2905161666), "/music/Not Today Official MV.mp3", 1, 0, "NotLiked", "Not Today Official MV", null, "Seeder" },
                    { 78, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(6070), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(6071), new TimeSpan(6001253333), "/music/Nto - Trauma (Worakls Remix).mp3", 1, 0, "NotLiked", "Nto - Trauma (Worakls Remix)", null, "Seeder" },
                    { 79, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(6683), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(6684), new TimeSpan(1710023333), "/music/Owari no Seraph OST - 1hundredknight M [終わりのセラフ].mp3", 1, 0, "NotLiked", "Owari no Seraph OST - 1hundredknight M [終わりのセラフ]", null, "Seeder" },
                    { 80, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(7162), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(7162), new TimeSpan(0, 0, 2, 52, 584), "/music/Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack.mp3", 1, 0, "NotLiked", "Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack", null, "Seeder" },
                    { 81, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(7792), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(7792), new TimeSpan(2321677500), "/music/Post Malone - Better Now.mp3", 1, 0, "NotLiked", "Post Malone - Better Now", null, "Seeder" },
                    { 82, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(8571), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(8572), new TimeSpan(2181349166), "/music/Post Malone_ 21 Savage - Rockstar.mp3", 1, 0, "NotLiked", "Post Malone_ 21 Savage - Rockstar", null, "Seeder" },
                    { 83, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(9225), new DateTime(2025, 2, 9, 20, 26, 27, 527, DateTimeKind.Local).AddTicks(9226), new TimeSpan(2120575000), "/music/Reverse feat. G-Eazy.mp3", 1, 0, "NotLiked", "Reverse feat. G-Eazy", null, "Seeder" },
                    { 84, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(165), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(166), new TimeSpan(1755408333), "/music/Rich The Kid - Plug Walk (Audio).mp3", 1, 0, "NotLiked", "Rich The Kid - Plug Walk (Audio)", null, "Seeder" },
                    { 85, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(904), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(905), new TimeSpan(1948425000), "/music/Right Now.mp3", 1, 0, "NotLiked", "Right Now", null, "Seeder" },
                    { 86, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(1624), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(1625), new TimeSpan(2102838333), "/music/RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends.mp3", 1, 0, "NotLiked", "RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends", null, "Seeder" },
                    { 87, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(2253), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(2254), new TimeSpan(3396832500), "/music/Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST.mp3", 1, 0, "NotLiked", "Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST", null, "Seeder" },
                    { 88, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(2888), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(2889), new TimeSpan(1666725000), "/music/SAD!.mp3", 1, 0, "NotLiked", "SAD!", null, "Seeder" },
                    { 89, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(3853), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(3853), new TimeSpan(1602038333), "/music/Saijaku Muhai no Bahamut  - Saijaku Muhai OST.mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut  - Saijaku Muhai OST", null, "Seeder" },
                    { 90, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(4458), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(4459), new TimeSpan(0, 0, 4, 13, 217), "/music/Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only).mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only)", null, "Seeder" },
                    { 91, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(5170), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(5170), new TimeSpan(0, 0, 36, 46, 337), "/music/Sakura - 落ち着いて冷やす.mp3", 1, 0, "NotLiked", "Sakura - 落ち着いて冷やす", null, "Seeder" },
                    { 92, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(5993), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(5994), new TimeSpan(2224647500), "/music/SAMAHTA - graffiti (feat. Melody Federer).mp3", 1, 0, "NotLiked", "SAMAHTA - graffiti (feat. Melody Federer)", null, "Seeder" },
                    { 93, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(6700), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(6701), new TimeSpan(0, 0, 3, 59, 445), "/music/Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte", null, "Seeder" },
                    { 94, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(7557), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(7559), new TimeSpan(2497479166), "/music/Shawn Mendes - Mercy.mp3", 1, 0, "NotLiked", "Shawn Mendes - Mercy", null, "Seeder" },
                    { 95, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(8297), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(8298), new TimeSpan(2398884166), "/music/Shawn Mendes - Stitches.mp3", 1, 0, "NotLiked", "Shawn Mendes - Stitches", null, "Seeder" },
                    { 96, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(8976), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(8976), new TimeSpan(2375148333), "/music/Shawn Mendes - Theres Nothing Holdin Me Back.mp3", 1, 0, "NotLiked", "Shawn Mendes - Theres Nothing Holdin Me Back", null, "Seeder" },
                    { 97, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(9638), new DateTime(2025, 2, 9, 20, 26, 27, 528, DateTimeKind.Local).AddTicks(9639), new TimeSpan(2564513333), "/music/Shawn Mendes - Treat You Better.mp3", 1, 0, "NotLiked", "Shawn Mendes - Treat You Better", null, "Seeder" },
                    { 98, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(292), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(293), new TimeSpan(1860263333), "/music/Sheck Wes - Mo Bamba.mp3", 1, 0, "NotLiked", "Sheck Wes - Mo Bamba", null, "Seeder" },
                    { 99, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(950), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(951), new TimeSpan(2367323333), "/music/Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte", null, "Seeder" },
                    { 100, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(1754), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(1755), new TimeSpan(2032152500), "/music/Sickick - Infected.mp3", 1, 0, "NotLiked", "Sickick - Infected", null, "Seeder" },
                    { 101, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(2508), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(2509), new TimeSpan(2551732500), "/music/Sickick - Mind Games.mp3", 1, 0, "NotLiked", "Sickick - Mind Games", null, "Seeder" },
                    { 102, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(3464), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(3465), new TimeSpan(2362106666), "/music/SickickMusic - Lost My Way.mp3", 1, 0, "NotLiked", "SickickMusic - Lost My Way", null, "Seeder" },
                    { 103, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(4426), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(4427), new TimeSpan(2763268333), "/music/Skan & Krale - No Glory (feat. M.I.M.E & Drama B).mp3", 1, 0, "NotLiked", "Skan & Krale - No Glory (feat. M.I.M.E & Drama B)", null, "Seeder" },
                    { 104, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(5051), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(5052), new TimeSpan(861010833), "/music/SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW.mp3", 1, 0, "NotLiked", "SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW", null, "Seeder" },
                    { 105, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(5834), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(5835), new TimeSpan(2190739166), "/music/SKRILLEX - Bangarang feat. Sirah.mp3", 1, 0, "NotLiked", "SKRILLEX - Bangarang feat. Sirah", null, "Seeder" },
                    { 106, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(6533), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(6533), new TimeSpan(1666725000), "/music/Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix).mp3", 1, 0, "NotLiked", "Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix)", null, "Seeder" },
                    { 107, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(7371), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(7371), new TimeSpan(3572112500), "/music/Soredemo sekai wa utsukushii - Beautiful rain full ver..mp3", 1, 0, "NotLiked", "Soredemo sekai wa utsukushii - Beautiful rain full ver.", null, "Seeder" },
                    { 108, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(8355), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(8356), new TimeSpan(2411404166), "/music/Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna].mp3", 1, 0, "NotLiked", "Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna]", null, "Seeder" },
                    { 109, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(9068), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(9069), new TimeSpan(2046237500), "/music/STéLOUSE - Sociopath (feat. Bryce Fox).mp3", 1, 0, "NotLiked", "STéLOUSE - Sociopath (feat. Bryce Fox)", null, "Seeder" },
                    { 110, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(9891), new DateTime(2025, 2, 9, 20, 26, 27, 529, DateTimeKind.Local).AddTicks(9891), new TimeSpan(2646415000), "/music/Sufian Suhaimi - Di Matamu.mp3", 1, 0, "NotLiked", "Sufian Suhaimi - Di Matamu", null, "Seeder" },
                    { 111, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(515), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(515), new TimeSpan(2951329166), "/music/Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting", null, "Seeder" },
                    { 112, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(1176), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(1176), new TimeSpan(2231429166), "/music/Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub", null, "Seeder" },
                    { 113, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(1759), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(1760), new TimeSpan(3378313333), "/music/Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION.mp3", 1, 0, "NotLiked", "Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION", null, "Seeder" },
                    { 114, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(2357), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(2358), new TimeSpan(2818565000), "/music/TETRA-FANG - Supernova.mp3", 1, 0, "NotLiked", "TETRA-FANG - Supernova", null, "Seeder" },
                    { 115, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(3347), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(3348), new TimeSpan(2359498333), "/music/The Mirza - Lelah Mengalah.mp3", 1, 0, "NotLiked", "The Mirza - Lelah Mengalah", null, "Seeder" },
                    { 116, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(4064), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(4065), new TimeSpan(37452797500), "/music/The Soul of Wind -  🗻 The Mountains 🗻.mp3", 1, 0, "NotLiked", "The Soul of Wind -  🗻 The Mountains 🗻", null, "Seeder" },
                    { 117, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(4940), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(4941), new TimeSpan(1943990833), "/music/TheFatRat - Fly Away feat. Anjulie.mp3", 1, 0, "NotLiked", "TheFatRat - Fly Away feat. Anjulie", null, "Seeder" },
                    { 118, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(5639), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(5639), new TimeSpan(2910639166), "/music/TheFatRat - Monody (feat. Laura Brehm).mp3", 1, 0, "NotLiked", "TheFatRat - Monody (feat. Laura Brehm)", null, "Seeder" },
                    { 119, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(6693), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(6693), new TimeSpan(0, 0, 3, 1, 227), "/music/TheFatRat - Time Lapse.mp3", 1, 0, "NotLiked", "TheFatRat - Time Lapse", null, "Seeder" },
                    { 120, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(7591), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(7594), new TimeSpan(2491740833), "/music/TheFatRat - Unity.mp3", 1, 0, "NotLiked", "TheFatRat - Unity", null, "Seeder" },
                    { 121, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(8375), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(8375), new TimeSpan(2474786666), "/music/TIIMO - Bangin In the Club.mp3", 1, 0, "NotLiked", "TIIMO - Bangin In the Club", null, "Seeder" },
                    { 122, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(9086), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(9087), new TimeSpan(2949764166), "/music/Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-].mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-]", null, "Seeder" },
                    { 123, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(9987), new DateTime(2025, 2, 9, 20, 26, 27, 530, DateTimeKind.Local).AddTicks(9988), new TimeSpan(1978420833), "/music/Tokyo Ghoul - Unravel (Marco B. Remix).mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (Marco B. Remix)", null, "Seeder" },
                    { 124, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(819), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(820), new TimeSpan(2481307500), "/music/Tokyo Ghoul - Unravel (OP Piano) .mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (OP Piano) ", null, "Seeder" },
                    { 125, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(1843), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(1844), new TimeSpan(2621635833), "/music/Tokyo Ghoul - Unravel 2.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel 2", null, "Seeder" },
                    { 126, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(2653), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(2653), new TimeSpan(0, 0, 4, 1, 323), "/music/Tokyo Ghoul - Unravel.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel", null, "Seeder" },
                    { 127, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(3652), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(3653), new TimeSpan(1975551666), "/music/Tokyo Machine - FLY [Monstercat Release].mp3", 1, 0, "NotLiked", "Tokyo Machine - FLY [Monstercat Release]", null, "Seeder" },
                    { 128, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(4369), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(4370), new TimeSpan(2304201666), "/music/Trapcity - Dead To Me (feat. Lox Chatterbox).mp3", 1, 0, "NotLiked", "Trapcity - Dead To Me (feat. Lox Chatterbox)", null, "Seeder" },
                    { 129, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(5223), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(5223), new TimeSpan(37651552500), "/music/Trapcity - Samurai☯ Lofi.mp3", 1, 0, "NotLiked", "Trapcity - Samurai☯ Lofi", null, "Seeder" },
                    { 130, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(6088), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(6088), new TimeSpan(2689713333), "/music/Trapcity - Trap Queen (Crankdat Remix).mp3", 1, 0, "NotLiked", "Trapcity - Trap Queen (Crankdat Remix)", null, "Seeder" },
                    { 131, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(7044), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(7044), new TimeSpan(3144867499), "/music/Travis Scott - SICKO MODE.mp3", 1, 0, "NotLiked", "Travis Scott - SICKO MODE", null, "Seeder" },
                    { 132, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(7873), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(7874), new TimeSpan(1863132500), "/music/Two Feet - I Feel Like Im Drowning.mp3", 1, 0, "NotLiked", "Two Feet - I Feel Like Im Drowning", null, "Seeder" },
                    { 133, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(8696), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(8696), new TimeSpan(2292203333), "/music/Unlike Pluto ft. Mike Taylor - Everything Black.mp3", 1, 0, "NotLiked", "Unlike Pluto ft. Mike Taylor - Everything Black", null, "Seeder" },
                    { 134, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(9332), new DateTime(2025, 2, 9, 20, 26, 27, 531, DateTimeKind.Local).AddTicks(9333), new TimeSpan(3559853333), "/music/Wishing Lyrics Rem(minase inori) ReZero.mp3", 1, 0, "NotLiked", "Wishing Lyrics Rem(minase inori) ReZero", null, "Seeder" },
                    { 135, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(6), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(7), new TimeSpan(949433333), "/music/XXXTENTACION - BAD!.mp3", 1, 0, "NotLiked", "XXXTENTACION - BAD!", null, "Seeder" },
                    { 136, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(762), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(762), new TimeSpan(1945555833), "/music/Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics].mp3", 1, 0, "NotLiked", "Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics]", null, "Seeder" },
                    { 137, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(1367), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(1367), new TimeSpan(2141441666), "/music/Yasuha - Flyday Chinatown.mp3", 1, 0, "NotLiked", "Yasuha - Flyday Chinatown", null, "Seeder" },
                    { 138, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(1961), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(1961), new TimeSpan(2595291666), "/music/YOASOBI 夜に駆ける English & Romanji Lyrics.mp3", 1, 0, "NotLiked", "YOASOBI 夜に駆ける English & Romanji Lyrics", null, "Seeder" },
                    { 139, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(2546), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(2546), new TimeSpan(2042846666), "/music/YOASOBIハルジオンOfficial Music Video.mp3", 1, 0, "NotLiked", "YOASOBIハルジオンOfficial Music Video", null, "Seeder" },
                    { 140, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(3480), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(3480), new TimeSpan(2276553333), "/music/Yuna - Longing.mp3", 1, 0, "NotLiked", "Yuna - Longing", null, "Seeder" },
                    { 141, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(5540), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(5542), new TimeSpan(1973986666), "/music/Yuna - Smile for you .mp3", 1, 0, "NotLiked", "Yuna - Smile for you ", null, "Seeder" },
                    { 142, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(6218), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(6219), new TimeSpan(3511077500), "/music/タイニーリトルアシアンタム.mp3", 1, 0, "NotLiked", "タイニーリトルアシアンタム", null, "Seeder" },
                    { 143, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(6834), new DateTime(2025, 2, 9, 20, 26, 27, 532, DateTimeKind.Local).AddTicks(6835), new TimeSpan(0, 0, 3, 6, 548), "/music/レペゼン地球66thシングルO2MEN.mp3", 1, 0, "NotLiked", "レペゼン地球66thシングルO2MEN", null, "Seeder" }
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
                name: "IX_Playlist_GenreID",
                table: "Playlist",
                column: "GenreID");

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

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
