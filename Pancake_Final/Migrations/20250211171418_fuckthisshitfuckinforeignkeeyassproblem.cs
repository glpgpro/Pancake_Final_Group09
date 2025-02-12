using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pancake_Final.Migrations
{
    /// <inheritdoc />
    public partial class fuckthisshitfuckinforeignkeeyassproblem : Migration
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
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayListID = table.Column<int>(type: "int", nullable: false),
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubStatus", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", 0, "b25719d3-b97a-473c-9d2d-42ec4df41661", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDu8Dt2gsCfEVhAmbEk3bp0+Md/leEFuXZG/Ib9NIYnfS2uDqTAXo9VdQ9HJj8mzjQ==", null, false, "40830700-4780-426c-8dac-414556b6396b", "Admin", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreID", "CreatedBy", "DateCreated", "DateUpdated", "GenreName", "Id", "UpdateBy" },
                values: new object[] { 1, "System", new DateTime(2025, 2, 11, 17, 14, 17, 127, DateTimeKind.Utc).AddTicks(1087), new DateTime(2025, 2, 11, 17, 14, 17, 127, DateTimeKind.Utc).AddTicks(1089), "Liked Songs", 1, "System" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumID", "ArtistId", "ArtistsArtistID", "CreatedBy", "DateAdded", "DateCreated", "DateUpdated", "Duration", "FilePath", "GenID", "Id", "LikedS", "Name", "PlaylistId", "UpdateBy" },
                values: new object[,]
                {
                    { 1, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 70, DateTimeKind.Local).AddTicks(4045), new DateTime(2025, 2, 12, 1, 14, 17, 70, DateTimeKind.Local).AddTicks(4057), new TimeSpan(3634973333), "/music/(Blood Sweat & Tears) Official MV.mp3", 1, 0, "NotLiked", "(Blood Sweat & Tears) Official MV", null, "Seeder" },
                    { 2, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 70, DateTimeKind.Local).AddTicks(8872), new DateTime(2025, 2, 12, 1, 14, 17, 70, DateTimeKind.Local).AddTicks(8878), new TimeSpan(2491219166), "/music/(FREE) Lo-fi Type Beat - I Need a Girl.mp3", 1, 0, "NotLiked", "(FREE) Lo-fi Type Beat - I Need a Girl", null, "Seeder" },
                    { 3, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 71, DateTimeKind.Local).AddTicks(4146), new DateTime(2025, 2, 12, 1, 14, 17, 71, DateTimeKind.Local).AddTicks(4150), new TimeSpan(3286239166), "/music/(Spring Day) Official MV.mp3", 1, 0, "NotLiked", "(Spring Day) Official MV", null, "Seeder" },
                    { 4, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 71, DateTimeKind.Local).AddTicks(9708), new DateTime(2025, 2, 12, 1, 14, 17, 71, DateTimeKind.Local).AddTicks(9712), new TimeSpan(1577780833), "/music/6IX9INE - GUMMO (Official Audio) .mp3", 1, 0, "NotLiked", "6IX9INE - GUMMO (Official Audio) ", null, "Seeder" },
                    { 5, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 72, DateTimeKind.Local).AddTicks(4163), new DateTime(2025, 2, 12, 1, 14, 17, 72, DateTimeKind.Local).AddTicks(4167), new TimeSpan(1584823333), "/music/6IX9INE - Kooda.mp3", 1, 0, "NotLiked", "6IX9INE - Kooda", null, "Seeder" },
                    { 6, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 72, DateTimeKind.Local).AddTicks(7211), new DateTime(2025, 2, 12, 1, 14, 17, 72, DateTimeKind.Local).AddTicks(7215), new TimeSpan(2012329166), "/music/88GLAM - Lil Boat (Lyrics).mp3", 1, 0, "NotLiked", "88GLAM - Lil Boat (Lyrics)", null, "Seeder" },
                    { 7, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 73, DateTimeKind.Local).AddTicks(786), new DateTime(2025, 2, 12, 1, 14, 17, 73, DateTimeKind.Local).AddTicks(790), new TimeSpan(2683975000), "/music/Aiman Tino - Permata Cinta .mp3", 1, 0, "NotLiked", "Aiman Tino - Permata Cinta ", null, "Seeder" },
                    { 8, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 73, DateTimeKind.Local).AddTicks(4937), new DateTime(2025, 2, 12, 1, 14, 17, 73, DateTimeKind.Local).AddTicks(4942), new TimeSpan(2091361666), "/music/Alan Walker - Darkside.mp3", 1, 0, "NotLiked", "Alan Walker - Darkside", null, "Seeder" },
                    { 9, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 73, DateTimeKind.Local).AddTicks(8360), new DateTime(2025, 2, 12, 1, 14, 17, 73, DateTimeKind.Local).AddTicks(8364), new TimeSpan(1814095833), "/music/Alec Benjamin - Boy In The Bubble.mp3", 1, 0, "NotLiked", "Alec Benjamin - Boy In The Bubble", null, "Seeder" },
                    { 10, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 74, DateTimeKind.Local).AddTicks(1466), new DateTime(2025, 2, 12, 1, 14, 17, 74, DateTimeKind.Local).AddTicks(1469), new TimeSpan(1842526666), "/music/Alec Benjamin - If We Have Each Other.mp3", 1, 0, "NotLiked", "Alec Benjamin - If We Have Each Other", null, "Seeder" },
                    { 11, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 74, DateTimeKind.Local).AddTicks(4441), new DateTime(2025, 2, 12, 1, 14, 17, 74, DateTimeKind.Local).AddTicks(4445), new TimeSpan(1873044166), "/music/Alec Benjamin - Let Me Down Slowly (Eastern Odyssey Remix).mp3", 1, 0, "NotLiked", "Alec Benjamin - Let Me Down Slowly (Eastern Odyssey Remix)", null, "Seeder" },
                    { 12, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 74, DateTimeKind.Local).AddTicks(8681), new DateTime(2025, 2, 12, 1, 14, 17, 74, DateTimeKind.Local).AddTicks(8685), new TimeSpan(1699068333), "/music/Alec Benjamin - Let Me Down Slowly.mp3", 1, 0, "NotLiked", "Alec Benjamin - Let Me Down Slowly", null, "Seeder" },
                    { 13, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 75, DateTimeKind.Local).AddTicks(1585), new DateTime(2025, 2, 12, 1, 14, 17, 75, DateTimeKind.Local).AddTicks(1589), new TimeSpan(2144571666), "/music/Ali Gatie - It's You (Official Lyrics Video).mp3", 1, 0, "NotLiked", "Ali Gatie - It's You (Official Lyrics Video)", null, "Seeder" },
                    { 14, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 75, DateTimeKind.Local).AddTicks(4611), new DateTime(2025, 2, 12, 1, 14, 17, 75, DateTimeKind.Local).AddTicks(4615), new TimeSpan(1995896666), "/music/Alone (Official Music Video).mp3", 1, 0, "NotLiked", "Alone (Official Music Video)", null, "Seeder" },
                    { 15, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 76, DateTimeKind.Local).AddTicks(1073), new DateTime(2025, 2, 12, 1, 14, 17, 76, DateTimeKind.Local).AddTicks(1077), new TimeSpan(1980768333), "/music/android52 - super anime groove 3d world.mp3", 1, 0, "NotLiked", "android52 - super anime groove 3d world", null, "Seeder" },
                    { 16, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 76, DateTimeKind.Local).AddTicks(4902), new DateTime(2025, 2, 12, 1, 14, 17, 76, DateTimeKind.Local).AddTicks(4907), new TimeSpan(1803140833), "/music/Ariana Grande -  7 rings.mp3", 1, 0, "NotLiked", "Ariana Grande -  7 rings", null, "Seeder" },
                    { 17, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 76, DateTimeKind.Local).AddTicks(8022), new DateTime(2025, 2, 12, 1, 14, 17, 76, DateTimeKind.Local).AddTicks(8026), new TimeSpan(2076755000), "/music/Ariana Grande - thank u next.mp3", 1, 0, "NotLiked", "Ariana Grande - thank u next", null, "Seeder" },
                    { 18, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 77, DateTimeKind.Local).AddTicks(1300), new DateTime(2025, 2, 12, 1, 14, 17, 77, DateTimeKind.Local).AddTicks(1304), new TimeSpan(1637772500), "/music/Arizona Zervas - ROXANNE (Prod. 94 Skrt).mp3", 1, 0, "NotLiked", "Arizona Zervas - ROXANNE (Prod. 94 Skrt)", null, "Seeder" },
                    { 19, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 77, DateTimeKind.Local).AddTicks(4275), new DateTime(2025, 2, 12, 1, 14, 17, 77, DateTimeKind.Local).AddTicks(4279), new TimeSpan(1861306666), "/music/Arman Cekin - California Dreaming (feat. Paul Rey).mp3", 1, 0, "NotLiked", "Arman Cekin - California Dreaming (feat. Paul Rey)", null, "Seeder" },
                    { 20, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 77, DateTimeKind.Local).AddTicks(7425), new DateTime(2025, 2, 12, 1, 14, 17, 77, DateTimeKind.Local).AddTicks(7429), new TimeSpan(5821799999), "/music/Art Blakey & the Jazz Messengers - Moanin.mp3", 1, 0, "NotLiked", "Art Blakey & the Jazz Messengers - Moanin", null, "Seeder" },
                    { 21, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 78, DateTimeKind.Local).AddTicks(601), new DateTime(2025, 2, 12, 1, 14, 17, 78, DateTimeKind.Local).AddTicks(605), new TimeSpan(2066843333), "/music/AsAP Rocky - Praise The Lord.mp3", 1, 0, "NotLiked", "AsAP Rocky - Praise The Lord", null, "Seeder" },
                    { 22, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 78, DateTimeKind.Local).AddTicks(5212), new DateTime(2025, 2, 12, 1, 14, 17, 78, DateTimeKind.Local).AddTicks(5215), new TimeSpan(2425489166), "/music/Attack On Titan - Vogel im Käfig Re-Mastered (Epic sound quality).mp3", 1, 0, "NotLiked", "Attack On Titan - Vogel im Käfig Re-Mastered (Epic sound quality)", null, "Seeder" },
                    { 23, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 78, DateTimeKind.Local).AddTicks(8497), new DateTime(2025, 2, 12, 1, 14, 17, 78, DateTimeKind.Local).AddTicks(8501), new TimeSpan(5775371666), "/music/Attack on Titan OST - Warriors Apple Seed + YouSeeBIGGIRLTT.mp3", 1, 0, "NotLiked", "Attack on Titan OST - Warriors Apple Seed + YouSeeBIGGIRLTT", null, "Seeder" },
                    { 24, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 79, DateTimeKind.Local).AddTicks(3660), new DateTime(2025, 2, 12, 1, 14, 17, 79, DateTimeKind.Local).AddTicks(3664), new TimeSpan(0, 0, 3, 39, 726), "/music/Attack on Titan S3 OST - ShingekiNoKyojin (The Owl Theme).mp3", 1, 0, "NotLiked", "Attack on Titan S3 OST - ShingekiNoKyojin (The Owl Theme)", null, "Seeder" },
                    { 25, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 79, DateTimeKind.Local).AddTicks(6932), new DateTime(2025, 2, 12, 1, 14, 17, 79, DateTimeKind.Local).AddTicks(6936), new TimeSpan(1891824166), "/music/Aywy. & EphRem - Adderall.mp3", 1, 0, "NotLiked", "Aywy. & EphRem - Adderall", null, "Seeder" },
                    { 26, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 80, DateTimeKind.Local).AddTicks(301), new DateTime(2025, 2, 12, 1, 14, 17, 80, DateTimeKind.Local).AddTicks(305), new TimeSpan(2202737500), "/music/Bank Account (BASS BOOSTED).mp3", 1, 0, "NotLiked", "Bank Account (BASS BOOSTED)", null, "Seeder" },
                    { 27, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 80, DateTimeKind.Local).AddTicks(5096), new DateTime(2025, 2, 12, 1, 14, 17, 80, DateTimeKind.Local).AddTicks(5100), new TimeSpan(2990454166), "/music/BLACKPINK & BTS - DDU-DU DDU-DU X FAKE LOVE (MASHUP).mp3", 1, 0, "NotLiked", "BLACKPINK & BTS - DDU-DU DDU-DU X FAKE LOVE (MASHUP)", null, "Seeder" },
                    { 28, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 80, DateTimeKind.Local).AddTicks(8977), new DateTime(2025, 2, 12, 1, 14, 17, 80, DateTimeKind.Local).AddTicks(8981), new TimeSpan(2440617500), "/music/BLACKPINK - BOOMBAYAH.mp3", 1, 0, "NotLiked", "BLACKPINK - BOOMBAYAH", null, "Seeder" },
                    { 29, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 81, DateTimeKind.Local).AddTicks(2973), new DateTime(2025, 2, 12, 1, 14, 17, 81, DateTimeKind.Local).AddTicks(2979), new TimeSpan(2153961666), "/music/BLACKPINK - DUDU-DUDU.mp3", 1, 0, "NotLiked", "BLACKPINK - DUDU-DUDU", null, "Seeder" },
                    { 30, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 81, DateTimeKind.Local).AddTicks(7310), new DateTime(2025, 2, 12, 1, 14, 17, 81, DateTimeKind.Local).AddTicks(7316), new TimeSpan(1937730833), "/music/BLACKPINK - Kill This Love .mp3", 1, 0, "NotLiked", "BLACKPINK - Kill This Love ", null, "Seeder" },
                    { 31, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 82, DateTimeKind.Local).AddTicks(895), new DateTime(2025, 2, 12, 1, 14, 17, 82, DateTimeKind.Local).AddTicks(900), new TimeSpan(2241340833), "/music/Boku no Hero Academia Season 4 Opening FullBLUE ENCOUNT - Polaris.mp3", 1, 0, "NotLiked", "Boku no Hero Academia Season 4 Opening FullBLUE ENCOUNT - Polaris", null, "Seeder" },
                    { 32, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 82, DateTimeKind.Local).AddTicks(4281), new DateTime(2025, 2, 12, 1, 14, 17, 82, DateTimeKind.Local).AddTicks(4285), new TimeSpan(2303158333), "/music/Bruno Mars - Marry You.mp3", 1, 0, "NotLiked", "Bruno Mars - Marry You", null, "Seeder" },
                    { 33, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 82, DateTimeKind.Local).AddTicks(9244), new DateTime(2025, 2, 12, 1, 14, 17, 82, DateTimeKind.Local).AddTicks(9248), new TimeSpan(2292985833), "/music/Bryan Mason & Karner H - Bassjump.mp3", 1, 0, "NotLiked", "Bryan Mason & Karner H - Bassjump", null, "Seeder" },
                    { 34, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 83, DateTimeKind.Local).AddTicks(4544), new DateTime(2025, 2, 12, 1, 14, 17, 83, DateTimeKind.Local).AddTicks(4547), new TimeSpan(2318547500), "/music/BTS  - BOY IN LUV.mp3", 1, 0, "NotLiked", "BTS  - BOY IN LUV", null, "Seeder" },
                    { 35, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 83, DateTimeKind.Local).AddTicks(7787), new DateTime(2025, 2, 12, 1, 14, 17, 83, DateTimeKind.Local).AddTicks(7791), new TimeSpan(2453659166), "/music/BTS  - Undelivered Truth  (1).mp3", 1, 0, "NotLiked", "BTS  - Undelivered Truth  (1)", null, "Seeder" },
                    { 36, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 84, DateTimeKind.Local).AddTicks(778), new DateTime(2025, 2, 12, 1, 14, 17, 84, DateTimeKind.Local).AddTicks(782), new TimeSpan(2240558333), "/music/BTS (방탄소년단) 'House of Cards' (Full Length Edition) Lyrics [Color Coded HanRomEng].mp3", 1, 0, "NotLiked", "BTS (방탄소년단) 'House of Cards' (Full Length Edition) Lyrics [Color Coded HanRomEng]", null, "Seeder" },
                    { 37, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 84, DateTimeKind.Local).AddTicks(3676), new DateTime(2025, 2, 12, 1, 14, 17, 84, DateTimeKind.Local).AddTicks(3680), new TimeSpan(2055627500), "/music/BTS (방탄소년단) 'N.O' Lyrics [Color CodedHanRomEng].mp3", 1, 0, "NotLiked", "BTS (방탄소년단) 'N.O' Lyrics [Color CodedHanRomEng]", null, "Seeder" },
                    { 38, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 84, DateTimeKind.Local).AddTicks(6488), new DateTime(2025, 2, 12, 1, 14, 17, 84, DateTimeKind.Local).AddTicks(6492), new TimeSpan(2193608333), "/music/BTS (방탄소년단) - 'AIRPLANE PT.2' Lyrics [Color CodedHanRomEng].mp3", 1, 0, "NotLiked", "BTS (방탄소년단) - 'AIRPLANE PT.2' Lyrics [Color CodedHanRomEng]", null, "Seeder" },
                    { 39, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 84, DateTimeKind.Local).AddTicks(9006), new DateTime(2025, 2, 12, 1, 14, 17, 84, DateTimeKind.Local).AddTicks(9009), new TimeSpan(2006851666), "/music/BTS (방탄소년단) - DimpleIllegal (보조개) Lyrics [Color CodedHanRomEng].mp3", 1, 0, "NotLiked", "BTS (방탄소년단) - DimpleIllegal (보조개) Lyrics [Color CodedHanRomEng]", null, "Seeder" },
                    { 40, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 85, DateTimeKind.Local).AddTicks(1948), new DateTime(2025, 2, 12, 1, 14, 17, 85, DateTimeKind.Local).AddTicks(1952), new TimeSpan(2954980833), "/music/BTS (방탄소년단)'CYPHER PT.4' Lyrics [Color CodedHanRomEng].mp3", 1, 0, "NotLiked", "BTS (방탄소년단)'CYPHER PT.4' Lyrics [Color CodedHanRomEng]", null, "Seeder" },
                    { 41, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 85, DateTimeKind.Local).AddTicks(4560), new DateTime(2025, 2, 12, 1, 14, 17, 85, DateTimeKind.Local).AddTicks(4564), new TimeSpan(2406709166), "/music/BTS -  MASHUP.mp3", 1, 0, "NotLiked", "BTS -  MASHUP", null, "Seeder" },
                    { 42, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 85, DateTimeKind.Local).AddTicks(7951), new DateTime(2025, 2, 12, 1, 14, 17, 85, DateTimeKind.Local).AddTicks(7956), new TimeSpan(2178219166), "/music/BTS - AIRPLANE PT.2.mp3", 1, 0, "NotLiked", "BTS - AIRPLANE PT.2", null, "Seeder" },
                    { 43, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 86, DateTimeKind.Local).AddTicks(1403), new DateTime(2025, 2, 12, 1, 14, 17, 86, DateTimeKind.Local).AddTicks(1408), new TimeSpan(2291942500), "/music/BTS - ANPANMAN.mp3", 1, 0, "NotLiked", "BTS - ANPANMAN", null, "Seeder" },
                    { 44, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 86, DateTimeKind.Local).AddTicks(4380), new DateTime(2025, 2, 12, 1, 14, 17, 86, DateTimeKind.Local).AddTicks(4384), new TimeSpan(0, 0, 3, 53, 811), "/music/BTS - Baepsae.mp3", 1, 0, "NotLiked", "BTS - Baepsae", null, "Seeder" },
                    { 45, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 86, DateTimeKind.Local).AddTicks(6906), new DateTime(2025, 2, 12, 1, 14, 17, 86, DateTimeKind.Local).AddTicks(6910), new TimeSpan(2526431666), "/music/BTS - Boy With Luv.mp3", 1, 0, "NotLiked", "BTS - Boy With Luv", null, "Seeder" },
                    { 46, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 86, DateTimeKind.Local).AddTicks(9394), new DateTime(2025, 2, 12, 1, 14, 17, 86, DateTimeKind.Local).AddTicks(9398), new TimeSpan(2916116666), "/music/BTS - Danger.mp3", 1, 0, "NotLiked", "BTS - Danger", null, "Seeder" },
                    { 47, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 87, DateTimeKind.Local).AddTicks(2810), new DateTime(2025, 2, 12, 1, 14, 17, 87, DateTimeKind.Local).AddTicks(2813), new TimeSpan(0, 0, 3, 47, 238), "/music/BTS - Dont Leave Me .mp3", 1, 0, "NotLiked", "BTS - Dont Leave Me ", null, "Seeder" },
                    { 48, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 87, DateTimeKind.Local).AddTicks(6213), new DateTime(2025, 2, 12, 1, 14, 17, 87, DateTimeKind.Local).AddTicks(6217), new TimeSpan(2205867500), "/music/BTS - LOVE MAZE.mp3", 1, 0, "NotLiked", "BTS - LOVE MAZE", null, "Seeder" },
                    { 49, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 88, DateTimeKind.Local).AddTicks(2197), new DateTime(2025, 2, 12, 1, 14, 17, 88, DateTimeKind.Local).AddTicks(2202), new TimeSpan(2803436666), "/music/BTS - Magic Shop .mp3", 1, 0, "NotLiked", "BTS - Magic Shop ", null, "Seeder" },
                    { 50, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 88, DateTimeKind.Local).AddTicks(6678), new DateTime(2025, 2, 12, 1, 14, 17, 88, DateTimeKind.Local).AddTicks(6682), new TimeSpan(2333415000), "/music/BTS - Make It Right.mp3", 1, 0, "NotLiked", "BTS - Make It Right", null, "Seeder" },
                    { 51, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 88, DateTimeKind.Local).AddTicks(9456), new DateTime(2025, 2, 12, 1, 14, 17, 88, DateTimeKind.Local).AddTicks(9460), new TimeSpan(33202257500), "/music/BTS - One Hour Piano .mp3", 1, 0, "NotLiked", "BTS - One Hour Piano ", null, "Seeder" },
                    { 52, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 89, DateTimeKind.Local).AddTicks(3416), new DateTime(2025, 2, 12, 1, 14, 17, 89, DateTimeKind.Local).AddTicks(3420), new TimeSpan(2507912500), "/music/BTS - Pied Piper.mp3", 1, 0, "NotLiked", "BTS - Pied Piper", null, "Seeder" },
                    { 53, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 89, DateTimeKind.Local).AddTicks(7717), new DateTime(2025, 2, 12, 1, 14, 17, 89, DateTimeKind.Local).AddTicks(7721), new TimeSpan(1514659166), "/music/BTS - Promise.mp3", 1, 0, "NotLiked", "BTS - Promise", null, "Seeder" },
                    { 54, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 90, DateTimeKind.Local).AddTicks(1196), new DateTime(2025, 2, 12, 1, 14, 17, 90, DateTimeKind.Local).AddTicks(1200), new TimeSpan(2121879166), "/music/BTS - Tear Singularity.mp3", 1, 0, "NotLiked", "BTS - Tear Singularity", null, "Seeder" },
                    { 55, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 90, DateTimeKind.Local).AddTicks(5131), new DateTime(2025, 2, 12, 1, 14, 17, 90, DateTimeKind.Local).AddTicks(5135), new TimeSpan(986471666), "/music/BTS - Youre so Beautiful.mp3", 1, 0, "NotLiked", "BTS - Youre so Beautiful", null, "Seeder" },
                    { 56, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 90, DateTimeKind.Local).AddTicks(8355), new DateTime(2025, 2, 12, 1, 14, 17, 90, DateTimeKind.Local).AddTicks(8359), new TimeSpan(4508243333), "/music/BTS - _RUN (Official MV) .mp3", 1, 0, "NotLiked", "BTS - _RUN (Official MV) ", null, "Seeder" },
                    { 57, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 91, DateTimeKind.Local).AddTicks(1737), new DateTime(2025, 2, 12, 1, 14, 17, 91, DateTimeKind.Local).AddTicks(1741), new TimeSpan(1978942500), "/music/BTS - _Save me .mp3", 1, 0, "NotLiked", "BTS - _Save me ", null, "Seeder" },
                    { 58, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 91, DateTimeKind.Local).AddTicks(4379), new DateTime(2025, 2, 12, 1, 14, 17, 91, DateTimeKind.Local).AddTicks(4383), new TimeSpan(3241375833), "/music/BTS - _Show Me Your BBA SAE (Official MV) .mp3", 1, 0, "NotLiked", "BTS - _Show Me Your BBA SAE (Official MV) ", null, "Seeder" },
                    { 59, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 91, DateTimeKind.Local).AddTicks(6901), new DateTime(2025, 2, 12, 1, 14, 17, 91, DateTimeKind.Local).AddTicks(6904), new TimeSpan(23501344166), "/music/BTS - 轉 Tear Piano Album.mp3", 1, 0, "NotLiked", "BTS - 轉 Tear Piano Album", null, "Seeder" },
                    { 60, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 91, DateTimeKind.Local).AddTicks(9388), new DateTime(2025, 2, 12, 1, 14, 17, 91, DateTimeKind.Local).AddTicks(9392), new TimeSpan(2251252500), "/music/BTS JUNGKOOK - Euphoria.mp3", 1, 0, "NotLiked", "BTS JUNGKOOK - Euphoria", null, "Seeder" },
                    { 61, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 92, DateTimeKind.Local).AddTicks(1743), new DateTime(2025, 2, 12, 1, 14, 17, 92, DateTimeKind.Local).AddTicks(1747), new TimeSpan(2301593333), "/music/BTS JUNGKOOK'EUPHORIA' Lyrics [Color CodedHanRomEng].mp3", 1, 0, "NotLiked", "BTS JUNGKOOK'EUPHORIA' Lyrics [Color CodedHanRomEng]", null, "Seeder" },
                    { 62, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 92, DateTimeKind.Local).AddTicks(4076), new DateTime(2025, 2, 12, 1, 14, 17, 92, DateTimeKind.Local).AddTicks(4079), new TimeSpan(2523301666), "/music/BTS PIANO  - Fake Love (Piano Cover) .mp3", 1, 0, "NotLiked", "BTS PIANO  - Fake Love (Piano Cover) ", null, "Seeder" },
                    { 63, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 92, DateTimeKind.Local).AddTicks(6307), new DateTime(2025, 2, 12, 1, 14, 17, 92, DateTimeKind.Local).AddTicks(6310), new TimeSpan(3030883333), "/music/BTS PIANO - Fake Love x Your Lie in April.mp3", 1, 0, "NotLiked", "BTS PIANO - Fake Love x Your Lie in April", null, "Seeder" },
                    { 64, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 92, DateTimeKind.Local).AddTicks(8443), new DateTime(2025, 2, 12, 1, 14, 17, 92, DateTimeKind.Local).AddTicks(8446), new TimeSpan(2055366666), "/music/Charlie Puth - Attention.mp3", 1, 0, "NotLiked", "Charlie Puth - Attention", null, "Seeder" },
                    { 65, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 93, DateTimeKind.Local).AddTicks(706), new DateTime(2025, 2, 12, 1, 14, 17, 93, DateTimeKind.Local).AddTicks(710), new TimeSpan(2305766666), "/music/Charlie Puth - We Dont Talk Anymore.mp3", 1, 0, "NotLiked", "Charlie Puth - We Dont Talk Anymore", null, "Seeder" },
                    { 66, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 93, DateTimeKind.Local).AddTicks(2919), new DateTime(2025, 2, 12, 1, 14, 17, 93, DateTimeKind.Local).AddTicks(2922), new TimeSpan(2466961666), "/music/Cinnamons x Evening Cinema - Summertime (KanRomEng Lyrics).mp3", 1, 0, "NotLiked", "Cinnamons x Evening Cinema - Summertime (KanRomEng Lyrics)", null, "Seeder" },
                    { 67, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 93, DateTimeKind.Local).AddTicks(5046), new DateTime(2025, 2, 12, 1, 14, 17, 93, DateTimeKind.Local).AddTicks(5050), new TimeSpan(2147440833), "/music/DanMachi OST - 英雄願望 アルゴノゥト The Will of Hero.mp3", 1, 0, "NotLiked", "DanMachi OST - 英雄願望 アルゴノゥト The Will of Hero", null, "Seeder" },
                    { 68, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 93, DateTimeKind.Local).AddTicks(7432), new DateTime(2025, 2, 12, 1, 14, 17, 93, DateTimeKind.Local).AddTicks(7435), new TimeSpan(2431488333), "/music/Dark cat feat. jenny - NO STOPPING US •.mp3", 1, 0, "NotLiked", "Dark cat feat. jenny - NO STOPPING US •", null, "Seeder" },
                    { 69, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 94, DateTimeKind.Local).AddTicks(729), new DateTime(2025, 2, 12, 1, 14, 17, 94, DateTimeKind.Local).AddTicks(732), new TimeSpan(2733533333), "/music/Date A Live OP I - Date Alive.mp3", 1, 0, "NotLiked", "Date A Live OP I - Date Alive", null, "Seeder" },
                    { 70, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 94, DateTimeKind.Local).AddTicks(3762), new DateTime(2025, 2, 12, 1, 14, 17, 94, DateTimeKind.Local).AddTicks(3765), new TimeSpan(1651596666), "/music/Date A Live OST - Ground Zero.mp3", 1, 0, "NotLiked", "Date A Live OST - Ground Zero", null, "Seeder" },
                    { 71, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 94, DateTimeKind.Local).AddTicks(6948), new DateTime(2025, 2, 12, 1, 14, 17, 94, DateTimeKind.Local).AddTicks(6952), new TimeSpan(1982072499), "/music/Date A Live Season 2 OST - Hurricane (Yamai Battle Theme).mp3", 1, 0, "NotLiked", "Date A Live Season 2 OST - Hurricane (Yamai Battle Theme)", null, "Seeder" },
                    { 72, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 95, DateTimeKind.Local).AddTicks(751), new DateTime(2025, 2, 12, 1, 14, 17, 95, DateTimeKind.Local).AddTicks(755), new TimeSpan(2753095833), "/music/Decade  - Journey through the Decade.mp3", 1, 0, "NotLiked", "Decade  - Journey through the Decade", null, "Seeder" },
                    { 73, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 95, DateTimeKind.Local).AddTicks(3805), new DateTime(2025, 2, 12, 1, 14, 17, 95, DateTimeKind.Local).AddTicks(3809), new TimeSpan(0, 0, 5, 44, 300), "/music/Demon Slayer Kimetsu no Yaiba EP 19 Ending FullKamado Tanjiro no Uta.mp3", 1, 0, "NotLiked", "Demon Slayer Kimetsu no Yaiba EP 19 Ending FullKamado Tanjiro no Uta", null, "Seeder" },
                    { 74, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 95, DateTimeKind.Local).AddTicks(7923), new DateTime(2025, 2, 12, 1, 14, 17, 95, DateTimeKind.Local).AddTicks(7927), new TimeSpan(2345674166), "/music/Demon Slayer Kimetsu no Yaiba OP Full 鬼滅の刃 OP Full - Gurenge LiSA.mp3", 1, 0, "NotLiked", "Demon Slayer Kimetsu no Yaiba OP Full 鬼滅の刃 OP Full - Gurenge LiSA", null, "Seeder" },
                    { 75, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 96, DateTimeKind.Local).AddTicks(753), new DateTime(2025, 2, 12, 1, 14, 17, 96, DateTimeKind.Local).AddTicks(757), new TimeSpan(2483133333), "/music/Demon Slayer Kimetsu No Yaiba OST - Demon Slaying Corps 鬼殺隊 Most Epic Music.mp3", 1, 0, "NotLiked", "Demon Slayer Kimetsu No Yaiba OST - Demon Slaying Corps 鬼殺隊 Most Epic Music", null, "Seeder" },
                    { 76, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 96, DateTimeKind.Local).AddTicks(4630), new DateTime(2025, 2, 12, 1, 14, 17, 96, DateTimeKind.Local).AddTicks(4635), new TimeSpan(1735063333), "/music/Diplo French Montana & Lil Pump - Welcome To The Party (Laeko Remix).mp3", 1, 0, "NotLiked", "Diplo French Montana & Lil Pump - Welcome To The Party (Laeko Remix)", null, "Seeder" },
                    { 77, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 96, DateTimeKind.Local).AddTicks(8387), new DateTime(2025, 2, 12, 1, 14, 17, 96, DateTimeKind.Local).AddTicks(8392), new TimeSpan(2555645000), "/music/DNA Official MV.mp3", 1, 0, "NotLiked", "DNA Official MV", null, "Seeder" },
                    { 78, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 96, DateTimeKind.Local).AddTicks(9963), new DateTime(2025, 2, 12, 1, 14, 17, 96, DateTimeKind.Local).AddTicks(9967), new TimeSpan(1877739166), "/music/Don Toliver - No Pole.mp3", 1, 0, "NotLiked", "Don Toliver - No Pole", null, "Seeder" },
                    { 79, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 97, DateTimeKind.Local).AddTicks(4524), new DateTime(2025, 2, 12, 1, 14, 17, 97, DateTimeKind.Local).AddTicks(4529), new TimeSpan(2567904166), "/music/DOPE  (Official MV).mp3", 1, 0, "NotLiked", "DOPE  (Official MV)", null, "Seeder" },
                    { 80, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 97, DateTimeKind.Local).AddTicks(8790), new DateTime(2025, 2, 12, 1, 14, 17, 97, DateTimeKind.Local).AddTicks(8793), new TimeSpan(2161525833), "/music/Dororo Opening Full - 『Ziyoouvachi - Kaen』.mp3", 1, 0, "NotLiked", "Dororo Opening Full - 『Ziyoouvachi - Kaen』", null, "Seeder" },
                    { 81, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 98, DateTimeKind.Local).AddTicks(1536), new DateTime(2025, 2, 12, 1, 14, 17, 98, DateTimeKind.Local).AddTicks(1539), new TimeSpan(3157648333), "/music/Drake - Nonstop.mp3", 1, 0, "NotLiked", "Drake - Nonstop", null, "Seeder" },
                    { 82, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 98, DateTimeKind.Local).AddTicks(4692), new DateTime(2025, 2, 12, 1, 14, 17, 98, DateTimeKind.Local).AddTicks(4697), new TimeSpan(906656666), "/music/ED Gakusen Toshi Asterisk War Season 2 Ending - [愛の詩-words of love-] [Ai no Uta] by Chisuga Haru.mp3", 1, 0, "NotLiked", "ED Gakusen Toshi Asterisk War Season 2 Ending - [愛の詩-words of love-] [Ai no Uta] by Chisuga Haru", null, "Seeder" },
                    { 83, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 98, DateTimeKind.Local).AddTicks(7470), new DateTime(2025, 2, 12, 1, 14, 17, 98, DateTimeKind.Local).AddTicks(7475), new TimeSpan(2471395833), "/music/Eir Aoi - Ignite.mp3", 1, 0, "NotLiked", "Eir Aoi - Ignite", null, "Seeder" },
                    { 84, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 99, DateTimeKind.Local).AddTicks(950), new DateTime(2025, 2, 12, 1, 14, 17, 99, DateTimeKind.Local).AddTicks(955), new TimeSpan(1657214062), "/music/Fareoh - Under Water.mp3", 1, 0, "NotLiked", "Fareoh - Under Water", null, "Seeder" },
                    { 85, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 99, DateTimeKind.Local).AddTicks(3976), new DateTime(2025, 2, 12, 1, 14, 17, 99, DateTimeKind.Local).AddTicks(3980), new TimeSpan(2441921666), "/music/Fatalis' Theme - MHWI (High Quality PC Extract).mp3", 1, 0, "NotLiked", "Fatalis' Theme - MHWI (High Quality PC Extract)", null, "Seeder" },
                    { 86, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 99, DateTimeKind.Local).AddTicks(6676), new DateTime(2025, 2, 12, 1, 14, 17, 99, DateTimeKind.Local).AddTicks(6679), new TimeSpan(3321712500), "/music/Floor 88 - Zalikha.mp3", 1, 0, "NotLiked", "Floor 88 - Zalikha", null, "Seeder" },
                    { 87, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 100, DateTimeKind.Local).AddTicks(53), new DateTime(2025, 2, 12, 1, 14, 17, 100, DateTimeKind.Local).AddTicks(57), new TimeSpan(2650066666), "/music/Fonzi M - “Renai Circulation” - Kana Hanazawa – Bakemo.mp3", 1, 0, "NotLiked", "Fonzi M - “Renai Circulation” - Kana Hanazawa – Bakemo", null, "Seeder" },
                    { 88, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 100, DateTimeKind.Local).AddTicks(2669), new DateTime(2025, 2, 12, 1, 14, 17, 100, DateTimeKind.Local).AddTicks(2673), new TimeSpan(2188652500), "/music/Full opening naruto Blue Bird [Lyrics].mp3", 1, 0, "NotLiked", "Full opening naruto Blue Bird [Lyrics]", null, "Seeder" },
                    { 89, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 100, DateTimeKind.Local).AddTicks(5210), new DateTime(2025, 2, 12, 1, 14, 17, 100, DateTimeKind.Local).AddTicks(5214), new TimeSpan(2602334166), "/music/Gakusen Toshi Asterisk  - Waiting for the rain.mp3", 1, 0, "NotLiked", "Gakusen Toshi Asterisk  - Waiting for the rain", null, "Seeder" },
                    { 90, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 100, DateTimeKind.Local).AddTicks(7442), new DateTime(2025, 2, 12, 1, 14, 17, 100, DateTimeKind.Local).AddTicks(7445), new TimeSpan(2621375000), "/music/Gakusen Toshi Asterisk War Season 2 Ending Full.mp3", 1, 0, "NotLiked", "Gakusen Toshi Asterisk War Season 2 Ending Full", null, "Seeder" },
                    { 91, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 100, DateTimeKind.Local).AddTicks(8764), new DateTime(2025, 2, 12, 1, 14, 17, 100, DateTimeKind.Local).AddTicks(8767), new TimeSpan(1297645833), "/music/Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人.mp3", 1, 0, "NotLiked", "Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人", null, "Seeder" },
                    { 92, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(636), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(639), new TimeSpan(2111185000), "/music/Goblin Slayer - Rightfully _ Mili [Full].mp3", 1, 0, "NotLiked", "Goblin Slayer - Rightfully _ Mili [Full]", null, "Seeder" },
                    { 93, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(2035), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(2038), new TimeSpan(1873305000), "/music/Goblins from Mars  - Put Your Love In Dreamz.mp3", 1, 0, "NotLiked", "Goblins from Mars  - Put Your Love In Dreamz", null, "Seeder" },
                    { 94, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(3793), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(3797), new TimeSpan(1812530833), "/music/Goblins from Mars - Cold Blooded Love (ft. Krista Marina).mp3", 1, 0, "NotLiked", "Goblins from Mars - Cold Blooded Love (ft. Krista Marina)", null, "Seeder" },
                    { 95, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(5159), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(5163), new TimeSpan(2091100833), "/music/Goblins from Mars - Heart Afire When The Bassjumps.mp3", 1, 0, "NotLiked", "Goblins from Mars - Heart Afire When The Bassjumps", null, "Seeder" },
                    { 96, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(6408), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(6411), new TimeSpan(2760920833), "/music/Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC].mp3", 1, 0, "NotLiked", "Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC]", null, "Seeder" },
                    { 97, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(7808), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(7811), new TimeSpan(2822477500), "/music/Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC].mp3", 1, 0, "NotLiked", "Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC]", null, "Seeder" },
                    { 98, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(9370), new DateTime(2025, 2, 12, 1, 14, 17, 101, DateTimeKind.Local).AddTicks(9373), new TimeSpan(2235863333), "/music/grandson - Despicable.mp3", 1, 0, "NotLiked", "grandson - Despicable", null, "Seeder" },
                    { 99, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(607), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(610), new TimeSpan(1464057500), "/music/Greatest Battle Music Of All Times Saijaku Muhai.mp3", 1, 0, "NotLiked", "Greatest Battle Music Of All Times Saijaku Muhai", null, "Seeder" },
                    { 100, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(2102), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(2105), new TimeSpan(916307500), "/music/Gundam - OP1 HD.mp3", 1, 0, "NotLiked", "Gundam - OP1 HD", null, "Seeder" },
                    { 101, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(3518), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(3521), new TimeSpan(0, 0, 3, 57, 567), "/music/Gundam - Seed.mp3", 1, 0, "NotLiked", "Gundam - Seed", null, "Seeder" },
                    { 102, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(4918), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(4921), new TimeSpan(2539995000), "/music/Hans Zimmer - Flight.mp3", 1, 0, "NotLiked", "Hans Zimmer - Flight", null, "Seeder" },
                    { 103, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(6195), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(6199), new TimeSpan(5451416666), "/music/Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music", null, "Seeder" },
                    { 104, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(7435), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(7438), new TimeSpan(0, 0, 8, 25, 182), "/music/Hiroyuki Sawano Impure King Suite Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano Impure King Suite Epic Battle Music", null, "Seeder" },
                    { 105, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(8787), new DateTime(2025, 2, 12, 1, 14, 17, 102, DateTimeKind.Local).AddTicks(8790), new TimeSpan(1010207500), "/music/HOPE.mp3", 1, 0, "NotLiked", "HOPE", null, "Seeder" },
                    { 106, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 103, DateTimeKind.Local).AddTicks(483), new DateTime(2025, 2, 12, 1, 14, 17, 103, DateTimeKind.Local).AddTicks(486), new TimeSpan(2029805000), "/music/HOTD - Pentakill .mp3", 1, 0, "NotLiked", "HOTD - Pentakill ", null, "Seeder" },
                    { 107, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 103, DateTimeKind.Local).AddTicks(1743), new DateTime(2025, 2, 12, 1, 14, 17, 103, DateTimeKind.Local).AddTicks(1746), new TimeSpan(1892867500), "/music/i feel like i did too much Don Toliver - No Idea (Lyrics).mp3", 1, 0, "NotLiked", "i feel like i did too much Don Toliver - No Idea (Lyrics)", null, "Seeder" },
                    { 108, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 103, DateTimeKind.Local).AddTicks(3559), new DateTime(2025, 2, 12, 1, 14, 17, 103, DateTimeKind.Local).AddTicks(3562), new TimeSpan(2197520833), "/music/I NEED U (Official MV).mp3", 1, 0, "NotLiked", "I NEED U (Official MV)", null, "Seeder" },
                    { 109, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 103, DateTimeKind.Local).AddTicks(5329), new DateTime(2025, 2, 12, 1, 14, 17, 103, DateTimeKind.Local).AddTicks(5332), new TimeSpan(2315417500), "/music/IDOL Official MV.mp3", 1, 0, "NotLiked", "IDOL Official MV", null, "Seeder" },
                    { 110, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 103, DateTimeKind.Local).AddTicks(7152), new DateTime(2025, 2, 12, 1, 14, 17, 103, DateTimeKind.Local).AddTicks(7155), new TimeSpan(0, 0, 2, 43, 73), "/music/Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix].mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix]", null, "Seeder" },
                    { 111, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 103, DateTimeKind.Local).AddTicks(8568), new DateTime(2025, 2, 12, 1, 14, 17, 103, DateTimeKind.Local).AddTicks(8571), new TimeSpan(2166742500), "/music/Imagine Dragons - Believer.mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer", null, "Seeder" },
                    { 112, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 104, DateTimeKind.Local).AddTicks(72), new DateTime(2025, 2, 12, 1, 14, 17, 104, DateTimeKind.Local).AddTicks(75), new TimeSpan(0, 0, 5, 23, 329), "/music/ISLAND OST - Island Opening Full「Eien no Hitotsu」.mp3", 1, 0, "NotLiked", "ISLAND OST - Island Opening Full「Eien no Hitotsu」", null, "Seeder" },
                    { 113, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 104, DateTimeKind.Local).AddTicks(1308), new DateTime(2025, 2, 12, 1, 14, 17, 104, DateTimeKind.Local).AddTicks(1312), new TimeSpan(3018363333), "/music/ISLAND OST - Lasting Memories FULL.mp3", 1, 0, "NotLiked", "ISLAND OST - Lasting Memories FULL", null, "Seeder" },
                    { 114, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 104, DateTimeKind.Local).AddTicks(2869), new DateTime(2025, 2, 12, 1, 14, 17, 104, DateTimeKind.Local).AddTicks(2872), new TimeSpan(1347204166), "/music/J.Fla  - Havana.mp3", 1, 0, "NotLiked", "J.Fla  - Havana", null, "Seeder" },
                    { 115, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 104, DateTimeKind.Local).AddTicks(4501), new DateTime(2025, 2, 12, 1, 14, 17, 104, DateTimeKind.Local).AddTicks(4504), new TimeSpan(0, 0, 4, 11, 652), "/music/Jacob Lee - Demons.mp3", 1, 0, "NotLiked", "Jacob Lee - Demons", null, "Seeder" },
                    { 116, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 104, DateTimeKind.Local).AddTicks(5719), new DateTime(2025, 2, 12, 1, 14, 17, 104, DateTimeKind.Local).AddTicks(5722), new TimeSpan(0, 0, 3, 25, 641), "/music/Jaden - GOKU.mp3", 1, 0, "NotLiked", "Jaden - GOKU", null, "Seeder" },
                    { 117, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 104, DateTimeKind.Local).AddTicks(8102), new DateTime(2025, 2, 12, 1, 14, 17, 104, DateTimeKind.Local).AddTicks(8105), new TimeSpan(0, 0, 2, 50, 898), "/music/Justin Stone - Lungs (Prod. Alex Collins).mp3", 1, 0, "NotLiked", "Justin Stone - Lungs (Prod. Alex Collins)", null, "Seeder" },
                    { 118, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 105, DateTimeKind.Local).AddTicks(946), new DateTime(2025, 2, 12, 1, 14, 17, 105, DateTimeKind.Local).AddTicks(949), new TimeSpan(2634677500), "/music/Kaguya-Sama - Love is war (feat. Masayuki Suzuki) .mp3", 1, 0, "NotLiked", "Kaguya-Sama - Love is war (feat. Masayuki Suzuki) ", null, "Seeder" },
                    { 119, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 105, DateTimeKind.Local).AddTicks(2877), new DateTime(2025, 2, 12, 1, 14, 17, 105, DateTimeKind.Local).AddTicks(2880), new TimeSpan(2541299166), "/music/Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki.mp3", 1, 0, "NotLiked", "Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki", null, "Seeder" },
                    { 120, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 105, DateTimeKind.Local).AddTicks(4818), new DateTime(2025, 2, 12, 1, 14, 17, 105, DateTimeKind.Local).AddTicks(4822), new TimeSpan(2771615000), "/music/Kakusei [Awakening].mp3", 1, 0, "NotLiked", "Kakusei [Awakening]", null, "Seeder" },
                    { 121, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 105, DateTimeKind.Local).AddTicks(6382), new DateTime(2025, 2, 12, 1, 14, 17, 105, DateTimeKind.Local).AddTicks(6385), new TimeSpan(1819312500), "/music/Kamikaze Feat. Lox Chatterbox.mp3", 1, 0, "NotLiked", "Kamikaze Feat. Lox Chatterbox", null, "Seeder" },
                    { 122, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 105, DateTimeKind.Local).AddTicks(7634), new DateTime(2025, 2, 12, 1, 14, 17, 105, DateTimeKind.Local).AddTicks(7637), new TimeSpan(2651631666), "/music/KANA-BOON - Silhouette.mp3", 1, 0, "NotLiked", "KANA-BOON - Silhouette", null, "Seeder" },
                    { 123, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 105, DateTimeKind.Local).AddTicks(8864), new DateTime(2025, 2, 12, 1, 14, 17, 105, DateTimeKind.Local).AddTicks(8867), new TimeSpan(2030065833), "/music/KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends.mp3", 1, 0, "NotLiked", "KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends", null, "Seeder" },
                    { 124, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(804), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(807), new TimeSpan(2423924166), "/music/Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP.mp3", 1, 0, "NotLiked", "Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP", null, "Seeder" },
                    { 125, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(2044), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(2048), new TimeSpan(1273127500), "/music/khai dreams - sunkissed.mp3", 1, 0, "NotLiked", "khai dreams - sunkissed", null, "Seeder" },
                    { 126, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(3247), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(3251), new TimeSpan(2328198333), "/music/Kibou No Uta Lyrics.mp3", 1, 0, "NotLiked", "Kibou No Uta Lyrics", null, "Seeder" },
                    { 127, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(4789), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(4792), new TimeSpan(2271597500), "/music/Krewella - Calm Down (SKAN Remix).mp3", 1, 0, "NotLiked", "Krewella - Calm Down (SKAN Remix)", null, "Seeder" },
                    { 128, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(5976), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(5980), new TimeSpan(2126574166), "/music/KSI & Randolph - Champagne (Official Audio).mp3", 1, 0, "NotLiked", "KSI & Randolph - Champagne (Official Audio)", null, "Seeder" },
                    { 129, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(7635), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(7638), new TimeSpan(2101273333), "/music/KUURO - Afraid of the Dark (feat. Sophiya) .mp3", 1, 0, "NotLiked", "KUURO - Afraid of the Dark (feat. Sophiya) ", null, "Seeder" },
                    { 130, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(9139), new DateTime(2025, 2, 12, 1, 14, 17, 106, DateTimeKind.Local).AddTicks(9143), new TimeSpan(1921298333), "/music/KUURO - What U Wanna Do.mp3", 1, 0, "NotLiked", "KUURO - What U Wanna Do", null, "Seeder" },
                    { 131, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 107, DateTimeKind.Local).AddTicks(818), new DateTime(2025, 2, 12, 1, 14, 17, 107, DateTimeKind.Local).AddTicks(822), new TimeSpan(0, 0, 3, 19, 381), "/music/LAYTO - Little Poor Me.mp3", 1, 0, "NotLiked", "LAYTO - Little Poor Me", null, "Seeder" },
                    { 132, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 107, DateTimeKind.Local).AddTicks(2074), new DateTime(2025, 2, 12, 1, 14, 17, 107, DateTimeKind.Local).AddTicks(2077), new TimeSpan(2351934166), "/music/Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends.mp3", 1, 0, "NotLiked", "Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends", null, "Seeder" },
                    { 133, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 107, DateTimeKind.Local).AddTicks(4228), new DateTime(2025, 2, 12, 1, 14, 17, 107, DateTimeKind.Local).AddTicks(4231), new TimeSpan(1406674166), "/music/Leonhart - Grancrest Senki OST - Hope.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST - Hope", null, "Seeder" },
                    { 134, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 107, DateTimeKind.Local).AddTicks(6037), new DateTime(2025, 2, 12, 1, 14, 17, 107, DateTimeKind.Local).AddTicks(6040), new TimeSpan(3110176666), "/music/Leonhart - Grancrest Senki OST.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST", null, "Seeder" },
                    { 135, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 107, DateTimeKind.Local).AddTicks(7305), new DateTime(2025, 2, 12, 1, 14, 17, 107, DateTimeKind.Local).AddTicks(7308), new TimeSpan(1668811666), "/music/Liam Ferrari - I Like The Way.mp3", 1, 0, "NotLiked", "Liam Ferrari - I Like The Way", null, "Seeder" },
                    { 136, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 107, DateTimeKind.Local).AddTicks(8800), new DateTime(2025, 2, 12, 1, 14, 17, 107, DateTimeKind.Local).AddTicks(8803), new TimeSpan(1570999166), "/music/Lil Nas X Billy Ray Cyrus - Old Town Road (Remix).mp3", 1, 0, "NotLiked", "Lil Nas X Billy Ray Cyrus - Old Town Road (Remix)", null, "Seeder" },
                    { 137, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(142), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(145), new TimeSpan(0, 0, 2, 44, 638), "/music/LIL SKIES - Boss Up.mp3", 1, 0, "NotLiked", "LIL SKIES - Boss Up", null, "Seeder" },
                    { 138, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(1343), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(1347), new TimeSpan(1561087499), "/music/LIL SKIES - Lust.mp3", 1, 0, "NotLiked", "LIL SKIES - Lust", null, "Seeder" },
                    { 139, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(2953), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(2957), new TimeSpan(1803140833), "/music/Lil Uzi Vert - XO Tour Llif3 .mp3", 1, 0, "NotLiked", "Lil Uzi Vert - XO Tour Llif3 ", null, "Seeder" },
                    { 140, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(4420), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(4424), new TimeSpan(2002939166), "/music/Lilianna Wilde - Grind Me Down (Jawster Remix).mp3", 1, 0, "NotLiked", "Lilianna Wilde - Grind Me Down (Jawster Remix)", null, "Seeder" },
                    { 141, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(5658), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(5662), new TimeSpan(0, 0, 4, 44, 204), "/music/LiSA - Catch the Moment.mp3", 1, 0, "NotLiked", "LiSA - Catch the Moment", null, "Seeder" },
                    { 142, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(6902), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(6906), new TimeSpan(2477916666), "/music/LiSA - Crossing Field.mp3", 1, 0, "NotLiked", "LiSA - Crossing Field", null, "Seeder" },
                    { 143, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(8212), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(8216), new TimeSpan(1852177500), "/music/Look Alive [BASS BOOSTED].mp3", 1, 0, "NotLiked", "Look Alive [BASS BOOSTED]", null, "Seeder" },
                    { 144, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(9422), new DateTime(2025, 2, 12, 1, 14, 17, 108, DateTimeKind.Local).AddTicks(9425), new TimeSpan(2581989166), "/music/Lyrics Owari no Seraph OST - 108.mp3", 1, 0, "NotLiked", "Lyrics Owari no Seraph OST - 108", null, "Seeder" },
                    { 145, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(676), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(679), new TimeSpan(2420794166), "/music/MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ.mp3", 1, 0, "NotLiked", "MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ", null, "Seeder" },
                    { 146, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(2161), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(2164), new TimeSpan(2044411666), "/music/Magnolia.mp3", 1, 0, "NotLiked", "Magnolia", null, "Seeder" },
                    { 147, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(3517), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(3521), new TimeSpan(3914847500), "/music/MHW ICEBORNE Safi Jiiva Battle Theme OST.mp3", 1, 0, "NotLiked", "MHW ICEBORNE Safi Jiiva Battle Theme OST", null, "Seeder" },
                    { 148, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(5152), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(5155), new TimeSpan(2741097500), "/music/MIC Drop (Steve Aoki Remix) Official MV.mp3", 1, 0, "NotLiked", "MIC Drop (Steve Aoki Remix) Official MV", null, "Seeder" },
                    { 149, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(6507), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(6511), new TimeSpan(2436444166), "/music/Migos - Get Right Witcha (G-REX X TOP $HELF Remix).mp3", 1, 0, "NotLiked", "Migos - Get Right Witcha (G-REX X TOP $HELF Remix)", null, "Seeder" },
                    { 150, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(7821), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(7824), new TimeSpan(2220995833), "/music/MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura.mp3", 1, 0, "NotLiked", "MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura", null, "Seeder" },
                    { 151, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(9222), new DateTime(2025, 2, 12, 1, 14, 17, 109, DateTimeKind.Local).AddTicks(9226), new TimeSpan(1660986666), "/music/Moonlight.mp3", 1, 0, "NotLiked", "Moonlight", null, "Seeder" },
                    { 152, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(562), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(565), new TimeSpan(2153700833), "/music/Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records.mp3", 1, 0, "NotLiked", "Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records", null, "Seeder" },
                    { 153, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(1923), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(1926), new TimeSpan(2213692500), "/music/Mrs. GREEN APPLE - インフェルノInferno.mp3", 1, 0, "NotLiked", "Mrs. GREEN APPLE - インフェルノInferno", null, "Seeder" },
                    { 154, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(3398), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(3402), new TimeSpan(4549455000), "/music/My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2).mp3", 1, 0, "NotLiked", "My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2)", null, "Seeder" },
                    { 155, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(4780), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(4784), new TimeSpan(1672463333), "/music/My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version).mp3", 1, 0, "NotLiked", "My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version)", null, "Seeder" },
                    { 156, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(6307), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(6310), new TimeSpan(2548863333), "/music/Namirin  - Renai Circulation「恋愛サーキュレーショ.mp3", 1, 0, "NotLiked", "Namirin  - Renai Circulation「恋愛サーキュレーショ", null, "Seeder" },
                    { 157, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(7655), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(7658), new TimeSpan(2596074166), "/music/Nanatsu no Taizai S2 - Escanor Theme (Rearrangement).mp3", 1, 0, "NotLiked", "Nanatsu no Taizai S2 - Escanor Theme (Rearrangement)", null, "Seeder" },
                    { 158, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(9520), new DateTime(2025, 2, 12, 1, 14, 17, 110, DateTimeKind.Local).AddTicks(9523), new TimeSpan(2005025833), "/music/NEFFEX - Fight Back.mp3", 1, 0, "NotLiked", "NEFFEX - Fight Back", null, "Seeder" },
                    { 159, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 111, DateTimeKind.Local).AddTicks(1003), new DateTime(2025, 2, 12, 1, 14, 17, 111, DateTimeKind.Local).AddTicks(1006), new TimeSpan(1951815833), "/music/NEFFEX - Myself.mp3", 1, 0, "NotLiked", "NEFFEX - Myself", null, "Seeder" },
                    { 160, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 111, DateTimeKind.Local).AddTicks(2566), new DateTime(2025, 2, 12, 1, 14, 17, 111, DateTimeKind.Local).AddTicks(2570), new TimeSpan(2091622500), "/music/Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro).mp3", 1, 0, "NotLiked", "Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro)", null, "Seeder" },
                    { 161, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 111, DateTimeKind.Local).AddTicks(4620), new DateTime(2025, 2, 12, 1, 14, 17, 111, DateTimeKind.Local).AddTicks(4624), new TimeSpan(1901735833), "/music/Nightcore - Control.mp3", 1, 0, "NotLiked", "Nightcore - Control", null, "Seeder" },
                    { 162, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 111, DateTimeKind.Local).AddTicks(6190), new DateTime(2025, 2, 12, 1, 14, 17, 111, DateTimeKind.Local).AddTicks(6194), new TimeSpan(1472925833), "/music/Nightcore - Rockefeller Street.mp3", 1, 0, "NotLiked", "Nightcore - Rockefeller Street", null, "Seeder" },
                    { 163, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 111, DateTimeKind.Local).AddTicks(7579), new DateTime(2025, 2, 12, 1, 14, 17, 111, DateTimeKind.Local).AddTicks(7583), new TimeSpan(2801871666), "/music/No Game No Life Opening Full.mp3", 1, 0, "NotLiked", "No Game No Life Opening Full", null, "Seeder" },
                    { 164, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 111, DateTimeKind.Local).AddTicks(9950), new DateTime(2025, 2, 12, 1, 14, 17, 111, DateTimeKind.Local).AddTicks(9954), new TimeSpan(2905161666), "/music/Not Today Official MV.mp3", 1, 0, "NotLiked", "Not Today Official MV", null, "Seeder" },
                    { 165, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 112, DateTimeKind.Local).AddTicks(1524), new DateTime(2025, 2, 12, 1, 14, 17, 112, DateTimeKind.Local).AddTicks(1527), new TimeSpan(6001253333), "/music/Nto - Trauma (Worakls Remix).mp3", 1, 0, "NotLiked", "Nto - Trauma (Worakls Remix)", null, "Seeder" },
                    { 166, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 112, DateTimeKind.Local).AddTicks(3047), new DateTime(2025, 2, 12, 1, 14, 17, 112, DateTimeKind.Local).AddTicks(3051), new TimeSpan(1710023333), "/music/Owari no Seraph OST - 1hundredknight M [終わりのセラフ].mp3", 1, 0, "NotLiked", "Owari no Seraph OST - 1hundredknight M [終わりのセラフ]", null, "Seeder" },
                    { 167, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 112, DateTimeKind.Local).AddTicks(4286), new DateTime(2025, 2, 12, 1, 14, 17, 112, DateTimeKind.Local).AddTicks(4290), new TimeSpan(0, 0, 2, 52, 584), "/music/Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack.mp3", 1, 0, "NotLiked", "Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack", null, "Seeder" },
                    { 168, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 112, DateTimeKind.Local).AddTicks(5717), new DateTime(2025, 2, 12, 1, 14, 17, 112, DateTimeKind.Local).AddTicks(5721), new TimeSpan(2321677500), "/music/Post Malone - Better Now.mp3", 1, 0, "NotLiked", "Post Malone - Better Now", null, "Seeder" },
                    { 169, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 112, DateTimeKind.Local).AddTicks(7376), new DateTime(2025, 2, 12, 1, 14, 17, 112, DateTimeKind.Local).AddTicks(7379), new TimeSpan(2181349166), "/music/Post Malone_ 21 Savage - Rockstar.mp3", 1, 0, "NotLiked", "Post Malone_ 21 Savage - Rockstar", null, "Seeder" },
                    { 170, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 112, DateTimeKind.Local).AddTicks(8694), new DateTime(2025, 2, 12, 1, 14, 17, 112, DateTimeKind.Local).AddTicks(8697), new TimeSpan(2120575000), "/music/Reverse feat. G-Eazy.mp3", 1, 0, "NotLiked", "Reverse feat. G-Eazy", null, "Seeder" },
                    { 171, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(516), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(520), new TimeSpan(1755408333), "/music/Rich The Kid - Plug Walk (Audio).mp3", 1, 0, "NotLiked", "Rich The Kid - Plug Walk (Audio)", null, "Seeder" },
                    { 172, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(2035), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(2038), new TimeSpan(1948425000), "/music/Right Now.mp3", 1, 0, "NotLiked", "Right Now", null, "Seeder" },
                    { 173, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(3621), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(3624), new TimeSpan(2102838333), "/music/RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends.mp3", 1, 0, "NotLiked", "RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends", null, "Seeder" },
                    { 174, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(5108), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(5111), new TimeSpan(3396832500), "/music/Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST.mp3", 1, 0, "NotLiked", "Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST", null, "Seeder" },
                    { 175, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(6635), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(6639), new TimeSpan(1666725000), "/music/SAD!.mp3", 1, 0, "NotLiked", "SAD!", null, "Seeder" },
                    { 176, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(8428), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(8431), new TimeSpan(1602038333), "/music/Saijaku Muhai no Bahamut  - Saijaku Muhai OST.mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut  - Saijaku Muhai OST", null, "Seeder" },
                    { 177, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(9874), new DateTime(2025, 2, 12, 1, 14, 17, 113, DateTimeKind.Local).AddTicks(9878), new TimeSpan(0, 0, 4, 13, 217), "/music/Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only).mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only)", null, "Seeder" },
                    { 178, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 114, DateTimeKind.Local).AddTicks(2048), new DateTime(2025, 2, 12, 1, 14, 17, 114, DateTimeKind.Local).AddTicks(2052), new TimeSpan(0, 0, 36, 46, 337), "/music/Sakura - 落ち着いて冷やす.mp3", 1, 0, "NotLiked", "Sakura - 落ち着いて冷やす", null, "Seeder" },
                    { 179, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 114, DateTimeKind.Local).AddTicks(4133), new DateTime(2025, 2, 12, 1, 14, 17, 114, DateTimeKind.Local).AddTicks(4137), new TimeSpan(2224647500), "/music/SAMAHTA - graffiti (feat. Melody Federer).mp3", 1, 0, "NotLiked", "SAMAHTA - graffiti (feat. Melody Federer)", null, "Seeder" },
                    { 180, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 114, DateTimeKind.Local).AddTicks(5650), new DateTime(2025, 2, 12, 1, 14, 17, 114, DateTimeKind.Local).AddTicks(5654), new TimeSpan(0, 0, 3, 59, 445), "/music/Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte", null, "Seeder" },
                    { 181, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 114, DateTimeKind.Local).AddTicks(7346), new DateTime(2025, 2, 12, 1, 14, 17, 114, DateTimeKind.Local).AddTicks(7350), new TimeSpan(2497479166), "/music/Shawn Mendes - Mercy.mp3", 1, 0, "NotLiked", "Shawn Mendes - Mercy", null, "Seeder" },
                    { 182, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 114, DateTimeKind.Local).AddTicks(8838), new DateTime(2025, 2, 12, 1, 14, 17, 114, DateTimeKind.Local).AddTicks(8842), new TimeSpan(2398884166), "/music/Shawn Mendes - Stitches.mp3", 1, 0, "NotLiked", "Shawn Mendes - Stitches", null, "Seeder" },
                    { 183, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 115, DateTimeKind.Local).AddTicks(451), new DateTime(2025, 2, 12, 1, 14, 17, 115, DateTimeKind.Local).AddTicks(455), new TimeSpan(2375148333), "/music/Shawn Mendes - Theres Nothing Holdin Me Back.mp3", 1, 0, "NotLiked", "Shawn Mendes - Theres Nothing Holdin Me Back", null, "Seeder" },
                    { 184, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 115, DateTimeKind.Local).AddTicks(2142), new DateTime(2025, 2, 12, 1, 14, 17, 115, DateTimeKind.Local).AddTicks(2147), new TimeSpan(2564513333), "/music/Shawn Mendes - Treat You Better.mp3", 1, 0, "NotLiked", "Shawn Mendes - Treat You Better", null, "Seeder" },
                    { 185, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 115, DateTimeKind.Local).AddTicks(3795), new DateTime(2025, 2, 12, 1, 14, 17, 115, DateTimeKind.Local).AddTicks(3798), new TimeSpan(1860263333), "/music/Sheck Wes - Mo Bamba.mp3", 1, 0, "NotLiked", "Sheck Wes - Mo Bamba", null, "Seeder" },
                    { 186, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 115, DateTimeKind.Local).AddTicks(5267), new DateTime(2025, 2, 12, 1, 14, 17, 115, DateTimeKind.Local).AddTicks(5272), new TimeSpan(2367323333), "/music/Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte", null, "Seeder" },
                    { 187, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 115, DateTimeKind.Local).AddTicks(7094), new DateTime(2025, 2, 12, 1, 14, 17, 115, DateTimeKind.Local).AddTicks(7097), new TimeSpan(2032152500), "/music/Sickick - Infected.mp3", 1, 0, "NotLiked", "Sickick - Infected", null, "Seeder" },
                    { 188, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 115, DateTimeKind.Local).AddTicks(8888), new DateTime(2025, 2, 12, 1, 14, 17, 115, DateTimeKind.Local).AddTicks(8892), new TimeSpan(2551732500), "/music/Sickick - Mind Games.mp3", 1, 0, "NotLiked", "Sickick - Mind Games", null, "Seeder" },
                    { 189, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 116, DateTimeKind.Local).AddTicks(847), new DateTime(2025, 2, 12, 1, 14, 17, 116, DateTimeKind.Local).AddTicks(851), new TimeSpan(2362106666), "/music/SickickMusic - Lost My Way.mp3", 1, 0, "NotLiked", "SickickMusic - Lost My Way", null, "Seeder" },
                    { 190, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 116, DateTimeKind.Local).AddTicks(2684), new DateTime(2025, 2, 12, 1, 14, 17, 116, DateTimeKind.Local).AddTicks(2688), new TimeSpan(2763268333), "/music/Skan & Krale - No Glory (feat. M.I.M.E & Drama B).mp3", 1, 0, "NotLiked", "Skan & Krale - No Glory (feat. M.I.M.E & Drama B)", null, "Seeder" },
                    { 191, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 116, DateTimeKind.Local).AddTicks(4382), new DateTime(2025, 2, 12, 1, 14, 17, 116, DateTimeKind.Local).AddTicks(4386), new TimeSpan(861010833), "/music/SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW.mp3", 1, 0, "NotLiked", "SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW", null, "Seeder" },
                    { 192, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 116, DateTimeKind.Local).AddTicks(6161), new DateTime(2025, 2, 12, 1, 14, 17, 116, DateTimeKind.Local).AddTicks(6165), new TimeSpan(2190739166), "/music/SKRILLEX - Bangarang feat. Sirah.mp3", 1, 0, "NotLiked", "SKRILLEX - Bangarang feat. Sirah", null, "Seeder" },
                    { 193, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 116, DateTimeKind.Local).AddTicks(7832), new DateTime(2025, 2, 12, 1, 14, 17, 116, DateTimeKind.Local).AddTicks(7836), new TimeSpan(1666725000), "/music/Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix).mp3", 1, 0, "NotLiked", "Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix)", null, "Seeder" },
                    { 194, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 116, DateTimeKind.Local).AddTicks(9633), new DateTime(2025, 2, 12, 1, 14, 17, 116, DateTimeKind.Local).AddTicks(9637), new TimeSpan(3572112500), "/music/Soredemo sekai wa utsukushii - Beautiful rain full ver..mp3", 1, 0, "NotLiked", "Soredemo sekai wa utsukushii - Beautiful rain full ver.", null, "Seeder" },
                    { 195, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 117, DateTimeKind.Local).AddTicks(1842), new DateTime(2025, 2, 12, 1, 14, 17, 117, DateTimeKind.Local).AddTicks(1847), new TimeSpan(2411404166), "/music/Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna].mp3", 1, 0, "NotLiked", "Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna]", null, "Seeder" },
                    { 196, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 117, DateTimeKind.Local).AddTicks(3693), new DateTime(2025, 2, 12, 1, 14, 17, 117, DateTimeKind.Local).AddTicks(3697), new TimeSpan(2046237500), "/music/STéLOUSE - Sociopath (feat. Bryce Fox).mp3", 1, 0, "NotLiked", "STéLOUSE - Sociopath (feat. Bryce Fox)", null, "Seeder" },
                    { 197, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 117, DateTimeKind.Local).AddTicks(5505), new DateTime(2025, 2, 12, 1, 14, 17, 117, DateTimeKind.Local).AddTicks(5508), new TimeSpan(2646415000), "/music/Sufian Suhaimi - Di Matamu.mp3", 1, 0, "NotLiked", "Sufian Suhaimi - Di Matamu", null, "Seeder" },
                    { 198, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 117, DateTimeKind.Local).AddTicks(7049), new DateTime(2025, 2, 12, 1, 14, 17, 117, DateTimeKind.Local).AddTicks(7053), new TimeSpan(2951329166), "/music/Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting", null, "Seeder" },
                    { 199, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 117, DateTimeKind.Local).AddTicks(8606), new DateTime(2025, 2, 12, 1, 14, 17, 117, DateTimeKind.Local).AddTicks(8611), new TimeSpan(2231429166), "/music/Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub", null, "Seeder" },
                    { 200, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 118, DateTimeKind.Local).AddTicks(347), new DateTime(2025, 2, 12, 1, 14, 17, 118, DateTimeKind.Local).AddTicks(351), new TimeSpan(3378313333), "/music/Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION.mp3", 1, 0, "NotLiked", "Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION", null, "Seeder" },
                    { 201, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 118, DateTimeKind.Local).AddTicks(1884), new DateTime(2025, 2, 12, 1, 14, 17, 118, DateTimeKind.Local).AddTicks(1889), new TimeSpan(2818565000), "/music/TETRA-FANG - Supernova.mp3", 1, 0, "NotLiked", "TETRA-FANG - Supernova", null, "Seeder" },
                    { 202, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 118, DateTimeKind.Local).AddTicks(4133), new DateTime(2025, 2, 12, 1, 14, 17, 118, DateTimeKind.Local).AddTicks(4136), new TimeSpan(2359498333), "/music/The Mirza - Lelah Mengalah.mp3", 1, 0, "NotLiked", "The Mirza - Lelah Mengalah", null, "Seeder" },
                    { 203, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 118, DateTimeKind.Local).AddTicks(5930), new DateTime(2025, 2, 12, 1, 14, 17, 118, DateTimeKind.Local).AddTicks(5934), new TimeSpan(37452797500), "/music/The Soul of Wind -  🗻 The Mountains 🗻.mp3", 1, 0, "NotLiked", "The Soul of Wind -  🗻 The Mountains 🗻", null, "Seeder" },
                    { 204, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 118, DateTimeKind.Local).AddTicks(7537), new DateTime(2025, 2, 12, 1, 14, 17, 118, DateTimeKind.Local).AddTicks(7541), new TimeSpan(1943990833), "/music/TheFatRat - Fly Away feat. Anjulie.mp3", 1, 0, "NotLiked", "TheFatRat - Fly Away feat. Anjulie", null, "Seeder" },
                    { 205, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 118, DateTimeKind.Local).AddTicks(9130), new DateTime(2025, 2, 12, 1, 14, 17, 118, DateTimeKind.Local).AddTicks(9134), new TimeSpan(2910639166), "/music/TheFatRat - Monody (feat. Laura Brehm).mp3", 1, 0, "NotLiked", "TheFatRat - Monody (feat. Laura Brehm)", null, "Seeder" },
                    { 206, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 119, DateTimeKind.Local).AddTicks(1381), new DateTime(2025, 2, 12, 1, 14, 17, 119, DateTimeKind.Local).AddTicks(1385), new TimeSpan(0, 0, 3, 1, 227), "/music/TheFatRat - Time Lapse.mp3", 1, 0, "NotLiked", "TheFatRat - Time Lapse", null, "Seeder" },
                    { 207, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 119, DateTimeKind.Local).AddTicks(3219), new DateTime(2025, 2, 12, 1, 14, 17, 119, DateTimeKind.Local).AddTicks(3223), new TimeSpan(2491740833), "/music/TheFatRat - Unity.mp3", 1, 0, "NotLiked", "TheFatRat - Unity", null, "Seeder" },
                    { 208, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 119, DateTimeKind.Local).AddTicks(4830), new DateTime(2025, 2, 12, 1, 14, 17, 119, DateTimeKind.Local).AddTicks(4834), new TimeSpan(2474786666), "/music/TIIMO - Bangin In the Club.mp3", 1, 0, "NotLiked", "TIIMO - Bangin In the Club", null, "Seeder" },
                    { 209, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 119, DateTimeKind.Local).AddTicks(6367), new DateTime(2025, 2, 12, 1, 14, 17, 119, DateTimeKind.Local).AddTicks(6371), new TimeSpan(2949764166), "/music/Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-].mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-]", null, "Seeder" },
                    { 210, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 119, DateTimeKind.Local).AddTicks(8334), new DateTime(2025, 2, 12, 1, 14, 17, 119, DateTimeKind.Local).AddTicks(8338), new TimeSpan(1978420833), "/music/Tokyo Ghoul - Unravel (Marco B. Remix).mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (Marco B. Remix)", null, "Seeder" },
                    { 211, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 120, DateTimeKind.Local).AddTicks(151), new DateTime(2025, 2, 12, 1, 14, 17, 120, DateTimeKind.Local).AddTicks(155), new TimeSpan(2481307500), "/music/Tokyo Ghoul - Unravel (OP Piano) .mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (OP Piano) ", null, "Seeder" },
                    { 212, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 120, DateTimeKind.Local).AddTicks(2115), new DateTime(2025, 2, 12, 1, 14, 17, 120, DateTimeKind.Local).AddTicks(2119), new TimeSpan(2621635833), "/music/Tokyo Ghoul - Unravel 2.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel 2", null, "Seeder" },
                    { 213, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 120, DateTimeKind.Local).AddTicks(4021), new DateTime(2025, 2, 12, 1, 14, 17, 120, DateTimeKind.Local).AddTicks(4026), new TimeSpan(0, 0, 4, 1, 323), "/music/Tokyo Ghoul - Unravel.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel", null, "Seeder" },
                    { 214, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 120, DateTimeKind.Local).AddTicks(6139), new DateTime(2025, 2, 12, 1, 14, 17, 120, DateTimeKind.Local).AddTicks(6143), new TimeSpan(1975551666), "/music/Tokyo Machine - FLY [Monstercat Release].mp3", 1, 0, "NotLiked", "Tokyo Machine - FLY [Monstercat Release]", null, "Seeder" },
                    { 215, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 120, DateTimeKind.Local).AddTicks(7835), new DateTime(2025, 2, 12, 1, 14, 17, 120, DateTimeKind.Local).AddTicks(7838), new TimeSpan(2304201666), "/music/Trapcity - Dead To Me (feat. Lox Chatterbox).mp3", 1, 0, "NotLiked", "Trapcity - Dead To Me (feat. Lox Chatterbox)", null, "Seeder" },
                    { 216, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 120, DateTimeKind.Local).AddTicks(9694), new DateTime(2025, 2, 12, 1, 14, 17, 120, DateTimeKind.Local).AddTicks(9698), new TimeSpan(37651552500), "/music/Trapcity - Samurai☯ Lofi.mp3", 1, 0, "NotLiked", "Trapcity - Samurai☯ Lofi", null, "Seeder" },
                    { 217, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 121, DateTimeKind.Local).AddTicks(1588), new DateTime(2025, 2, 12, 1, 14, 17, 121, DateTimeKind.Local).AddTicks(1593), new TimeSpan(2689713333), "/music/Trapcity - Trap Queen (Crankdat Remix).mp3", 1, 0, "NotLiked", "Trapcity - Trap Queen (Crankdat Remix)", null, "Seeder" },
                    { 218, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 121, DateTimeKind.Local).AddTicks(3741), new DateTime(2025, 2, 12, 1, 14, 17, 121, DateTimeKind.Local).AddTicks(3746), new TimeSpan(3144867499), "/music/Travis Scott - SICKO MODE.mp3", 1, 0, "NotLiked", "Travis Scott - SICKO MODE", null, "Seeder" },
                    { 219, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 121, DateTimeKind.Local).AddTicks(5571), new DateTime(2025, 2, 12, 1, 14, 17, 121, DateTimeKind.Local).AddTicks(5575), new TimeSpan(1863132500), "/music/Two Feet - I Feel Like Im Drowning.mp3", 1, 0, "NotLiked", "Two Feet - I Feel Like Im Drowning", null, "Seeder" },
                    { 220, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 121, DateTimeKind.Local).AddTicks(7600), new DateTime(2025, 2, 12, 1, 14, 17, 121, DateTimeKind.Local).AddTicks(7604), new TimeSpan(2292203333), "/music/Unlike Pluto ft. Mike Taylor - Everything Black.mp3", 1, 0, "NotLiked", "Unlike Pluto ft. Mike Taylor - Everything Black", null, "Seeder" },
                    { 221, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 121, DateTimeKind.Local).AddTicks(9172), new DateTime(2025, 2, 12, 1, 14, 17, 121, DateTimeKind.Local).AddTicks(9176), new TimeSpan(3559853333), "/music/Wishing Lyrics Rem(minase inori) ReZero.mp3", 1, 0, "NotLiked", "Wishing Lyrics Rem(minase inori) ReZero", null, "Seeder" },
                    { 222, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 122, DateTimeKind.Local).AddTicks(830), new DateTime(2025, 2, 12, 1, 14, 17, 122, DateTimeKind.Local).AddTicks(835), new TimeSpan(949433333), "/music/XXXTENTACION - BAD!.mp3", 1, 0, "NotLiked", "XXXTENTACION - BAD!", null, "Seeder" },
                    { 223, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 122, DateTimeKind.Local).AddTicks(2394), new DateTime(2025, 2, 12, 1, 14, 17, 122, DateTimeKind.Local).AddTicks(2398), new TimeSpan(1945555833), "/music/Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics].mp3", 1, 0, "NotLiked", "Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics]", null, "Seeder" },
                    { 224, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 122, DateTimeKind.Local).AddTicks(3918), new DateTime(2025, 2, 12, 1, 14, 17, 122, DateTimeKind.Local).AddTicks(3922), new TimeSpan(2141441666), "/music/Yasuha - Flyday Chinatown.mp3", 1, 0, "NotLiked", "Yasuha - Flyday Chinatown", null, "Seeder" },
                    { 225, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 122, DateTimeKind.Local).AddTicks(5452), new DateTime(2025, 2, 12, 1, 14, 17, 122, DateTimeKind.Local).AddTicks(5456), new TimeSpan(2595291666), "/music/YOASOBI 夜に駆ける English & Romanji Lyrics.mp3", 1, 0, "NotLiked", "YOASOBI 夜に駆ける English & Romanji Lyrics", null, "Seeder" },
                    { 226, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 122, DateTimeKind.Local).AddTicks(7005), new DateTime(2025, 2, 12, 1, 14, 17, 122, DateTimeKind.Local).AddTicks(7009), new TimeSpan(2042846666), "/music/YOASOBIハルジオンOfficial Music Video.mp3", 1, 0, "NotLiked", "YOASOBIハルジオンOfficial Music Video", null, "Seeder" },
                    { 227, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 122, DateTimeKind.Local).AddTicks(8822), new DateTime(2025, 2, 12, 1, 14, 17, 122, DateTimeKind.Local).AddTicks(8826), new TimeSpan(2276553333), "/music/Yuna - Longing.mp3", 1, 0, "NotLiked", "Yuna - Longing", null, "Seeder" },
                    { 228, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 123, DateTimeKind.Local).AddTicks(1692), new DateTime(2025, 2, 12, 1, 14, 17, 123, DateTimeKind.Local).AddTicks(1697), new TimeSpan(1973986666), "/music/Yuna - Smile for you .mp3", 1, 0, "NotLiked", "Yuna - Smile for you ", null, "Seeder" },
                    { 229, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 123, DateTimeKind.Local).AddTicks(6962), new DateTime(2025, 2, 12, 1, 14, 17, 123, DateTimeKind.Local).AddTicks(6967), new TimeSpan(2126052500), "/music/[FULL] Fairy Tail OP 1 -Snow Fairy- OriginalEnglish.mp3", 1, 0, "NotLiked", "[FULL] Fairy Tail OP 1 -Snow Fairy- OriginalEnglish", null, "Seeder" },
                    { 230, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 124, DateTimeKind.Local).AddTicks(1108), new DateTime(2025, 2, 12, 1, 14, 17, 124, DateTimeKind.Local).AddTicks(1114), new TimeSpan(1868088333), "/music/[MV] - _ Some(썸 탈꺼야).mp3", 1, 0, "NotLiked", "[MV] - _ Some(썸 탈꺼야)", null, "Seeder" },
                    { 231, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 124, DateTimeKind.Local).AddTicks(5850), new DateTime(2025, 2, 12, 1, 14, 17, 124, DateTimeKind.Local).AddTicks(5855), new TimeSpan(2270554166), "/music/[Official Video] JAM Project - THE HERO !! - One Punch Man Opening Theme ワンパンマン.mp3", 1, 0, "NotLiked", "[Official Video] JAM Project - THE HERO !! - One Punch Man Opening Theme ワンパンマン", null, "Seeder" },
                    { 232, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 124, DateTimeKind.Local).AddTicks(9833), new DateTime(2025, 2, 12, 1, 14, 17, 124, DateTimeKind.Local).AddTicks(9839), new TimeSpan(2948199166), "/music/_ FIRE (Official MV).mp3", 1, 0, "NotLiked", "_ FIRE (Official MV)", null, "Seeder" },
                    { 233, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 125, DateTimeKind.Local).AddTicks(4192), new DateTime(2025, 2, 12, 1, 14, 17, 125, DateTimeKind.Local).AddTicks(4197), new TimeSpan(3297455000), "/music/❀Club2Tokyo❀ - Cold Eyes Warm Smile.mp3", 1, 0, "NotLiked", "❀Club2Tokyo❀ - Cold Eyes Warm Smile", null, "Seeder" },
                    { 234, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 125, DateTimeKind.Local).AddTicks(8458), new DateTime(2025, 2, 12, 1, 14, 17, 125, DateTimeKind.Local).AddTicks(8464), new TimeSpan(1794272499), "/music/「Gotoubun no Kimochi」 - Quintessential Quintuplets .mp3", 1, 0, "NotLiked", "「Gotoubun no Kimochi」 - Quintessential Quintuplets ", null, "Seeder" },
                    { 235, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 126, DateTimeKind.Local).AddTicks(2238), new DateTime(2025, 2, 12, 1, 14, 17, 126, DateTimeKind.Local).AddTicks(2244), new TimeSpan(3264850833), "/music/「Your Name」盾の勇者 の 成り上がり - Chiai Fujikawa.mp3", 1, 0, "NotLiked", "「Your Name」盾の勇者 の 成り上がり - Chiai Fujikawa", null, "Seeder" },
                    { 236, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 126, DateTimeKind.Local).AddTicks(5966), new DateTime(2025, 2, 12, 1, 14, 17, 126, DateTimeKind.Local).AddTicks(5970), new TimeSpan(36486149166), "/music/【BGM】 - Beautiful Piano Music .mp3", 1, 0, "NotLiked", "【BGM】 - Beautiful Piano Music ", null, "Seeder" },
                    { 237, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 126, DateTimeKind.Local).AddTicks(7725), new DateTime(2025, 2, 12, 1, 14, 17, 126, DateTimeKind.Local).AddTicks(7730), new TimeSpan(3511077500), "/music/タイニーリトルアシアンタム.mp3", 1, 0, "NotLiked", "タイニーリトルアシアンタム", null, "Seeder" },
                    { 238, null, 1, null, "Seeder", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 12, 1, 14, 17, 126, DateTimeKind.Local).AddTicks(9929), new DateTime(2025, 2, 12, 1, 14, 17, 126, DateTimeKind.Local).AddTicks(9934), new TimeSpan(0, 0, 3, 6, 548), "/music/レペゼン地球66thシングルO2MEN.mp3", 1, 0, "NotLiked", "レペゼン地球66thシングルO2MEN", null, "Seeder" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

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
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Playlist");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
