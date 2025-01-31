using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pancake_Final.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPlaylistDB : Migration
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
                    SongId = table.Column<int>(type: "int", nullable: false),
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
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d12a5e95-c5d4-4b79-98cf-ea410b9a27dd", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGlFnAnlLk/UoTo6oXOd0WUsEyjYKbYY9ze+H8slZKO6QMWT9dVwsZFAk0coc2cgjw==", null, false, "b42f8dd3-716d-4198-8357-66fdeb502ff6", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumID", "ArtistId", "ArtistsArtistID", "CreatedBy", "DateCreated", "DateUpdated", "Duration", "FilePath", "GenID", "Id", "LikedS", "Name", "PlaylistId", "UpdateBy" },
                values: new object[,]
                {
                    { 1, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7280), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7290), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Don Toliver - No Pole.mp3", 1, 0, "NotLiked", "Don Toliver - No Pole", null, "Seeder" },
                    { 2, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7297), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7297), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人.mp3", 1, 0, "NotLiked", "Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人", null, "Seeder" },
                    { 3, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7299), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7299), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Goblin Slayer - Rightfully _ Mili [Full].mp3", 1, 0, "NotLiked", "Goblin Slayer - Rightfully _ Mili [Full]", null, "Seeder" },
                    { 4, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7301), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7301), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Goblins from Mars  - Put Your Love In Dreamz.mp3", 1, 0, "NotLiked", "Goblins from Mars  - Put Your Love In Dreamz", null, "Seeder" },
                    { 5, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7302), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7303), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Goblins from Mars - Cold Blooded Love (ft. Krista Marina).mp3", 1, 0, "NotLiked", "Goblins from Mars - Cold Blooded Love (ft. Krista Marina)", null, "Seeder" },
                    { 6, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7305), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7305), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Goblins from Mars - Heart Afire When The Bassjumps.mp3", 1, 0, "NotLiked", "Goblins from Mars - Heart Afire When The Bassjumps", null, "Seeder" },
                    { 7, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7307), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7307), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC].mp3", 1, 0, "NotLiked", "Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC]", null, "Seeder" },
                    { 8, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7308), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7309), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC].mp3", 1, 0, "NotLiked", "Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC]", null, "Seeder" },
                    { 9, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7310), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7310), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\grandson - Despicable.mp3", 1, 0, "NotLiked", "grandson - Despicable", null, "Seeder" },
                    { 10, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7312), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7313), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Greatest Battle Music Of All Times Saijaku Muhai.mp3", 1, 0, "NotLiked", "Greatest Battle Music Of All Times Saijaku Muhai", null, "Seeder" },
                    { 11, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7314), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7314), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Gundam - OP1 HD.mp3", 1, 0, "NotLiked", "Gundam - OP1 HD", null, "Seeder" },
                    { 12, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7315), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7315), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Gundam - Seed.mp3", 1, 0, "NotLiked", "Gundam - Seed", null, "Seeder" },
                    { 13, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7317), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7317), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Hans Zimmer - Flight.mp3", 1, 0, "NotLiked", "Hans Zimmer - Flight", null, "Seeder" },
                    { 14, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7318), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7319), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music", null, "Seeder" },
                    { 15, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7320), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7320), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Hiroyuki Sawano Impure King Suite Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano Impure King Suite Epic Battle Music", null, "Seeder" },
                    { 16, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7322), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7322), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\HOPE.mp3", 1, 0, "NotLiked", "HOPE", null, "Seeder" },
                    { 17, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7323), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7324), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\HOTD - Pentakill .mp3", 1, 0, "NotLiked", "HOTD - Pentakill ", null, "Seeder" },
                    { 18, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7325), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7326), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\i feel like i did too much Don Toliver - No Idea (Lyrics).mp3", 1, 0, "NotLiked", "i feel like i did too much Don Toliver - No Idea (Lyrics)", null, "Seeder" },
                    { 19, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7327), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7327), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\I NEED U (Official MV).mp3", 1, 0, "NotLiked", "I NEED U (Official MV)", null, "Seeder" },
                    { 20, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7329), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7329), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\IDOL Official MV.mp3", 1, 0, "NotLiked", "IDOL Official MV", null, "Seeder" },
                    { 21, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7330), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7331), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix].mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix]", null, "Seeder" },
                    { 22, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7332), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7332), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Imagine Dragons - Believer.mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer", null, "Seeder" },
                    { 23, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7333), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7334), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\ISLAND OST - Island Opening Full「Eien no Hitotsu」.mp3", 1, 0, "NotLiked", "ISLAND OST - Island Opening Full「Eien no Hitotsu」", null, "Seeder" },
                    { 24, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7335), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7335), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\ISLAND OST - Lasting Memories FULL.mp3", 1, 0, "NotLiked", "ISLAND OST - Lasting Memories FULL", null, "Seeder" },
                    { 25, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7337), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7337), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\J.Fla  - Havana.mp3", 1, 0, "NotLiked", "J.Fla  - Havana", null, "Seeder" },
                    { 26, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7338), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7338), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Jacob Lee - Demons.mp3", 1, 0, "NotLiked", "Jacob Lee - Demons", null, "Seeder" },
                    { 27, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7340), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7340), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Jaden - GOKU.mp3", 1, 0, "NotLiked", "Jaden - GOKU", null, "Seeder" },
                    { 28, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7341), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7342), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Justin Stone - Lungs (Prod. Alex Collins).mp3", 1, 0, "NotLiked", "Justin Stone - Lungs (Prod. Alex Collins)", null, "Seeder" },
                    { 29, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7343), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7343), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Kaguya-Sama - Love is war (feat. Masayuki Suzuki) .mp3", 1, 0, "NotLiked", "Kaguya-Sama - Love is war (feat. Masayuki Suzuki) ", null, "Seeder" },
                    { 30, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7345), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7345), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki.mp3", 1, 0, "NotLiked", "Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki", null, "Seeder" },
                    { 31, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7346), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7347), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Kakusei [Awakening].mp3", 1, 0, "NotLiked", "Kakusei [Awakening]", null, "Seeder" },
                    { 32, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7386), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7386), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Kamikaze Feat. Lox Chatterbox.mp3", 1, 0, "NotLiked", "Kamikaze Feat. Lox Chatterbox", null, "Seeder" },
                    { 33, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7388), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7388), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\KANA-BOON - Silhouette.mp3", 1, 0, "NotLiked", "KANA-BOON - Silhouette", null, "Seeder" },
                    { 34, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7390), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7390), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends.mp3", 1, 0, "NotLiked", "KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends", null, "Seeder" },
                    { 35, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7392), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7392), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP.mp3", 1, 0, "NotLiked", "Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP", null, "Seeder" },
                    { 36, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7393), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7393), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\khai dreams - sunkissed.mp3", 1, 0, "NotLiked", "khai dreams - sunkissed", null, "Seeder" },
                    { 37, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7394), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7395), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Kibou No Uta Lyrics.mp3", 1, 0, "NotLiked", "Kibou No Uta Lyrics", null, "Seeder" },
                    { 38, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7396), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7396), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Krewella - Calm Down (SKAN Remix).mp3", 1, 0, "NotLiked", "Krewella - Calm Down (SKAN Remix)", null, "Seeder" },
                    { 39, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7397), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7398), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\KSI & Randolph - Champagne (Official Audio).mp3", 1, 0, "NotLiked", "KSI & Randolph - Champagne (Official Audio)", null, "Seeder" },
                    { 40, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7399), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7399), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\KUURO - Afraid of the Dark (feat. Sophiya) .mp3", 1, 0, "NotLiked", "KUURO - Afraid of the Dark (feat. Sophiya) ", null, "Seeder" },
                    { 41, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7400), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7400), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\KUURO - What U Wanna Do.mp3", 1, 0, "NotLiked", "KUURO - What U Wanna Do", null, "Seeder" },
                    { 42, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7402), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7402), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\LAYTO - Little Poor Me.mp3", 1, 0, "NotLiked", "LAYTO - Little Poor Me", null, "Seeder" },
                    { 43, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7403), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7404), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends.mp3", 1, 0, "NotLiked", "Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends", null, "Seeder" },
                    { 44, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7405), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7405), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Leonhart - Grancrest Senki OST - Hope.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST - Hope", null, "Seeder" },
                    { 45, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7406), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7407), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Leonhart - Grancrest Senki OST.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST", null, "Seeder" },
                    { 46, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7408), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7408), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Liam Ferrari - I Like The Way.mp3", 1, 0, "NotLiked", "Liam Ferrari - I Like The Way", null, "Seeder" },
                    { 47, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7410), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7410), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Lil Nas X Billy Ray Cyrus - Old Town Road (Remix).mp3", 1, 0, "NotLiked", "Lil Nas X Billy Ray Cyrus - Old Town Road (Remix)", null, "Seeder" },
                    { 48, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7411), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7411), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\LIL SKIES - Boss Up.mp3", 1, 0, "NotLiked", "LIL SKIES - Boss Up", null, "Seeder" },
                    { 49, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7413), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7413), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\LIL SKIES - Lust.mp3", 1, 0, "NotLiked", "LIL SKIES - Lust", null, "Seeder" },
                    { 50, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7414), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7414), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Lil Uzi Vert - XO Tour Llif3 .mp3", 1, 0, "NotLiked", "Lil Uzi Vert - XO Tour Llif3 ", null, "Seeder" },
                    { 51, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7416), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7416), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Lilianna Wilde - Grind Me Down (Jawster Remix).mp3", 1, 0, "NotLiked", "Lilianna Wilde - Grind Me Down (Jawster Remix)", null, "Seeder" },
                    { 52, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7417), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7417), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\LiSA - Catch the Moment.mp3", 1, 0, "NotLiked", "LiSA - Catch the Moment", null, "Seeder" },
                    { 53, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7418), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7419), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\LiSA - Crossing Field.mp3", 1, 0, "NotLiked", "LiSA - Crossing Field", null, "Seeder" },
                    { 54, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7420), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7420), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Look Alive [BASS BOOSTED].mp3", 1, 0, "NotLiked", "Look Alive [BASS BOOSTED]", null, "Seeder" },
                    { 55, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7421), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7422), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Lyrics Owari no Seraph OST - 108.mp3", 1, 0, "NotLiked", "Lyrics Owari no Seraph OST - 108", null, "Seeder" },
                    { 56, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7423), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7423), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ.mp3", 1, 0, "NotLiked", "MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ", null, "Seeder" },
                    { 57, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7425), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7425), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Magnolia.mp3", 1, 0, "NotLiked", "Magnolia", null, "Seeder" },
                    { 58, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7426), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7426), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Maroon 5 - Sugar.mp3", 1, 0, "NotLiked", "Maroon 5 - Sugar", null, "Seeder" },
                    { 59, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7427), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7428), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Maroon 5 Ft. Wiz Khalifa.mp3", 1, 0, "NotLiked", "Maroon 5 Ft. Wiz Khalifa", null, "Seeder" },
                    { 60, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7429), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7430), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\MHW ICEBORNE Safi Jiiva Battle Theme OST.mp3", 1, 0, "NotLiked", "MHW ICEBORNE Safi Jiiva Battle Theme OST", null, "Seeder" },
                    { 61, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7431), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7431), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\MIC Drop (Steve Aoki Remix) Official MV.mp3", 1, 0, "NotLiked", "MIC Drop (Steve Aoki Remix) Official MV", null, "Seeder" },
                    { 62, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7432), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7433), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Migos - Get Right Witcha (G-REX X TOP $HELF Remix).mp3", 1, 0, "NotLiked", "Migos - Get Right Witcha (G-REX X TOP $HELF Remix)", null, "Seeder" },
                    { 63, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7434), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7434), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura.mp3", 1, 0, "NotLiked", "MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura", null, "Seeder" },
                    { 64, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7435), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7436), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Moonlight.mp3", 1, 0, "NotLiked", "Moonlight", null, "Seeder" },
                    { 65, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7437), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7437), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records.mp3", 1, 0, "NotLiked", "Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records", null, "Seeder" },
                    { 66, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7461), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7461), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Mrs. GREEN APPLE - インフェルノInferno.mp3", 1, 0, "NotLiked", "Mrs. GREEN APPLE - インフェルノInferno", null, "Seeder" },
                    { 67, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7463), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7463), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2).mp3", 1, 0, "NotLiked", "My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2)", null, "Seeder" },
                    { 68, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7464), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7465), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version).mp3", 1, 0, "NotLiked", "My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version)", null, "Seeder" },
                    { 69, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7466), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7466), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Namirin  - Renai Circulation「恋愛サーキュレーショ.mp3", 1, 0, "NotLiked", "Namirin  - Renai Circulation「恋愛サーキュレーショ", null, "Seeder" },
                    { 70, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7467), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7468), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Nanatsu no Taizai S2 - Escanor Theme (Rearrangement).mp3", 1, 0, "NotLiked", "Nanatsu no Taizai S2 - Escanor Theme (Rearrangement)", null, "Seeder" },
                    { 71, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7469), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7469), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\NEFFEX - Fight Back.mp3", 1, 0, "NotLiked", "NEFFEX - Fight Back", null, "Seeder" },
                    { 72, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7470), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7470), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\NEFFEX - Myself.mp3", 1, 0, "NotLiked", "NEFFEX - Myself", null, "Seeder" },
                    { 73, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7472), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7472), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro).mp3", 1, 0, "NotLiked", "Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro)", null, "Seeder" },
                    { 74, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7473), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7474), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Nightcore - Control.mp3", 1, 0, "NotLiked", "Nightcore - Control", null, "Seeder" },
                    { 75, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7475), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7475), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Nightcore - Rockefeller Street.mp3", 1, 0, "NotLiked", "Nightcore - Rockefeller Street", null, "Seeder" },
                    { 76, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7476), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7477), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\No Game No Life Opening Full.mp3", 1, 0, "NotLiked", "No Game No Life Opening Full", null, "Seeder" },
                    { 77, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7478), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7478), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Not Today Official MV.mp3", 1, 0, "NotLiked", "Not Today Official MV", null, "Seeder" },
                    { 78, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7480), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7480), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Nto - Trauma (Worakls Remix).mp3", 1, 0, "NotLiked", "Nto - Trauma (Worakls Remix)", null, "Seeder" },
                    { 79, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7481), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7481), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Owari no Seraph OST - 1hundredknight M [終わりのセラフ].mp3", 1, 0, "NotLiked", "Owari no Seraph OST - 1hundredknight M [終わりのセラフ]", null, "Seeder" },
                    { 80, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7483), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7483), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack.mp3", 1, 0, "NotLiked", "Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack", null, "Seeder" },
                    { 81, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7484), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7484), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Post Malone - Better Now.mp3", 1, 0, "NotLiked", "Post Malone - Better Now", null, "Seeder" },
                    { 82, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7486), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7486), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Post Malone_ 21 Savage - Rockstar.mp3", 1, 0, "NotLiked", "Post Malone_ 21 Savage - Rockstar", null, "Seeder" },
                    { 83, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7487), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7488), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Reverse feat. G-Eazy.mp3", 1, 0, "NotLiked", "Reverse feat. G-Eazy", null, "Seeder" },
                    { 84, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7489), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7489), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Rich The Kid - Plug Walk (Audio).mp3", 1, 0, "NotLiked", "Rich The Kid - Plug Walk (Audio)", null, "Seeder" },
                    { 85, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7490), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7491), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Right Now.mp3", 1, 0, "NotLiked", "Right Now", null, "Seeder" },
                    { 86, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7492), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7492), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends.mp3", 1, 0, "NotLiked", "RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends", null, "Seeder" },
                    { 87, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7494), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7494), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST.mp3", 1, 0, "NotLiked", "Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST", null, "Seeder" },
                    { 88, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7495), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7496), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\SAD!.mp3", 1, 0, "NotLiked", "SAD!", null, "Seeder" },
                    { 89, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7497), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7497), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Saijaku Muhai no Bahamut  - Saijaku Muhai OST.mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut  - Saijaku Muhai OST", null, "Seeder" },
                    { 90, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7498), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7499), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only).mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only)", null, "Seeder" },
                    { 91, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7500), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7500), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sakura - 落ち着いて冷やす.mp3", 1, 0, "NotLiked", "Sakura - 落ち着いて冷やす", null, "Seeder" },
                    { 92, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7501), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7502), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\SAMAHTA - graffiti (feat. Melody Federer).mp3", 1, 0, "NotLiked", "SAMAHTA - graffiti (feat. Melody Federer)", null, "Seeder" },
                    { 93, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7503), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7503), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte", null, "Seeder" },
                    { 94, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7504), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7505), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Shawn Mendes - Mercy.mp3", 1, 0, "NotLiked", "Shawn Mendes - Mercy", null, "Seeder" },
                    { 95, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7506), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7506), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Shawn Mendes - Stitches.mp3", 1, 0, "NotLiked", "Shawn Mendes - Stitches", null, "Seeder" },
                    { 96, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7507), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7507), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Shawn Mendes - Theres Nothing Holdin Me Back.mp3", 1, 0, "NotLiked", "Shawn Mendes - Theres Nothing Holdin Me Back", null, "Seeder" },
                    { 97, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7509), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7509), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Shawn Mendes - Treat You Better.mp3", 1, 0, "NotLiked", "Shawn Mendes - Treat You Better", null, "Seeder" },
                    { 98, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7510), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7510), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sheck Wes - Mo Bamba.mp3", 1, 0, "NotLiked", "Sheck Wes - Mo Bamba", null, "Seeder" },
                    { 99, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7512), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7512), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte", null, "Seeder" },
                    { 100, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7513), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7514), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sickick - Infected.mp3", 1, 0, "NotLiked", "Sickick - Infected", null, "Seeder" },
                    { 101, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7515), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7515), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sickick - Mind Games.mp3", 1, 0, "NotLiked", "Sickick - Mind Games", null, "Seeder" },
                    { 102, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7516), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7517), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\SickickMusic - Lost My Way.mp3", 1, 0, "NotLiked", "SickickMusic - Lost My Way", null, "Seeder" },
                    { 103, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7518), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7518), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Skan & Krale - No Glory (feat. M.I.M.E & Drama B).mp3", 1, 0, "NotLiked", "Skan & Krale - No Glory (feat. M.I.M.E & Drama B)", null, "Seeder" },
                    { 104, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7519), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7520), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW.mp3", 1, 0, "NotLiked", "SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW", null, "Seeder" },
                    { 105, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7556), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7557), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\SKRILLEX - Bangarang feat. Sirah.mp3", 1, 0, "NotLiked", "SKRILLEX - Bangarang feat. Sirah", null, "Seeder" },
                    { 106, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7558), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7558), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix).mp3", 1, 0, "NotLiked", "Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix)", null, "Seeder" },
                    { 107, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7560), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7560), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Soredemo sekai wa utsukushii - Beautiful rain full ver..mp3", 1, 0, "NotLiked", "Soredemo sekai wa utsukushii - Beautiful rain full ver.", null, "Seeder" },
                    { 108, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7561), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7562), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna].mp3", 1, 0, "NotLiked", "Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna]", null, "Seeder" },
                    { 109, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7563), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7563), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\STéLOUSE - Sociopath (feat. Bryce Fox).mp3", 1, 0, "NotLiked", "STéLOUSE - Sociopath (feat. Bryce Fox)", null, "Seeder" },
                    { 110, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7564), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7565), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sufian Suhaimi - Di Matamu.mp3", 1, 0, "NotLiked", "Sufian Suhaimi - Di Matamu", null, "Seeder" },
                    { 111, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7566), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7566), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting", null, "Seeder" },
                    { 112, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7567), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7568), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub", null, "Seeder" },
                    { 113, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7569), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7569), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION.mp3", 1, 0, "NotLiked", "Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION", null, "Seeder" },
                    { 114, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7570), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7571), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\TETRA-FANG - Supernova.mp3", 1, 0, "NotLiked", "TETRA-FANG - Supernova", null, "Seeder" },
                    { 115, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7572), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7572), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\The Mirza - Lelah Mengalah.mp3", 1, 0, "NotLiked", "The Mirza - Lelah Mengalah", null, "Seeder" },
                    { 116, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7573), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7574), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\The Soul of Wind -  🗻 The Mountains 🗻.mp3", 1, 0, "NotLiked", "The Soul of Wind -  🗻 The Mountains 🗻", null, "Seeder" },
                    { 117, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7575), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7575), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\TheFatRat - Fly Away feat. Anjulie.mp3", 1, 0, "NotLiked", "TheFatRat - Fly Away feat. Anjulie", null, "Seeder" },
                    { 118, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7576), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7576), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\TheFatRat - Monody (feat. Laura Brehm).mp3", 1, 0, "NotLiked", "TheFatRat - Monody (feat. Laura Brehm)", null, "Seeder" },
                    { 119, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7578), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7578), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\TheFatRat - Time Lapse.mp3", 1, 0, "NotLiked", "TheFatRat - Time Lapse", null, "Seeder" },
                    { 120, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7579), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7579), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\TheFatRat - Unity.mp3", 1, 0, "NotLiked", "TheFatRat - Unity", null, "Seeder" },
                    { 121, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7580), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7581), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\TIIMO - Bangin In the Club.mp3", 1, 0, "NotLiked", "TIIMO - Bangin In the Club", null, "Seeder" },
                    { 122, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7582), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7582), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-].mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-]", null, "Seeder" },
                    { 123, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7583), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7584), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Unravel (Marco B. Remix).mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (Marco B. Remix)", null, "Seeder" },
                    { 124, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7585), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7585), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Unravel (OP Piano) .mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (OP Piano) ", null, "Seeder" },
                    { 125, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7586), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7587), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Unravel 2.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel 2", null, "Seeder" },
                    { 126, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7588), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7588), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Unravel.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel", null, "Seeder" },
                    { 127, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7590), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7590), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tokyo Machine - FLY [Monstercat Release].mp3", 1, 0, "NotLiked", "Tokyo Machine - FLY [Monstercat Release]", null, "Seeder" },
                    { 128, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7591), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7591), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Trapcity - Dead To Me (feat. Lox Chatterbox).mp3", 1, 0, "NotLiked", "Trapcity - Dead To Me (feat. Lox Chatterbox)", null, "Seeder" },
                    { 129, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7592), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Trapcity - Samurai☯ Lofi.mp3", 1, 0, "NotLiked", "Trapcity - Samurai☯ Lofi", null, "Seeder" },
                    { 130, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7595), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7596), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Trapcity - Trap Queen (Crankdat Remix).mp3", 1, 0, "NotLiked", "Trapcity - Trap Queen (Crankdat Remix)", null, "Seeder" },
                    { 131, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7597), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7597), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Travis Scott - SICKO MODE.mp3", 1, 0, "NotLiked", "Travis Scott - SICKO MODE", null, "Seeder" },
                    { 132, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7598), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7599), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Two Feet - I Feel Like Im Drowning.mp3", 1, 0, "NotLiked", "Two Feet - I Feel Like Im Drowning", null, "Seeder" },
                    { 133, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7600), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7600), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Unlike Pluto ft. Mike Taylor - Everything Black.mp3", 1, 0, "NotLiked", "Unlike Pluto ft. Mike Taylor - Everything Black", null, "Seeder" },
                    { 134, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7614), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7614), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Wishing Lyrics Rem(minase inori) ReZero.mp3", 1, 0, "NotLiked", "Wishing Lyrics Rem(minase inori) ReZero", null, "Seeder" },
                    { 135, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7616), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7616), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\XXXTENTACION - BAD!.mp3", 1, 0, "NotLiked", "XXXTENTACION - BAD!", null, "Seeder" },
                    { 136, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7617), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7618), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics].mp3", 1, 0, "NotLiked", "Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics]", null, "Seeder" },
                    { 137, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7619), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7619), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Yasuha - Flyday Chinatown.mp3", 1, 0, "NotLiked", "Yasuha - Flyday Chinatown", null, "Seeder" },
                    { 138, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7620), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7621), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\YOASOBI 夜に駆ける English & Romanji Lyrics.mp3", 1, 0, "NotLiked", "YOASOBI 夜に駆ける English & Romanji Lyrics", null, "Seeder" },
                    { 139, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7622), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7622), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\YOASOBIハルジオンOfficial Music Video.mp3", 1, 0, "NotLiked", "YOASOBIハルジオンOfficial Music Video", null, "Seeder" },
                    { 140, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7623), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7624), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Yuna - Longing.mp3", 1, 0, "NotLiked", "Yuna - Longing", null, "Seeder" },
                    { 141, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7625), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7625), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Yuna - Smile for you .mp3", 1, 0, "NotLiked", "Yuna - Smile for you ", null, "Seeder" },
                    { 142, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7626), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7627), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\タイニーリトルアシアンタム.mp3", 1, 0, "NotLiked", "タイニーリトルアシアンタム", null, "Seeder" },
                    { 143, 0, 1, null, "Seeder", new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7628), new DateTime(2025, 1, 28, 16, 30, 49, 197, DateTimeKind.Local).AddTicks(7628), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\source\\repos\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\レペゼン地球66thシングルO2MEN.mp3", 1, 0, "NotLiked", "レペゼン地球66thシングルO2MEN", null, "Seeder" }
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
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Playlist");
        }
    }
}
