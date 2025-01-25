using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pancake_Final.Migrations
{
    /// <inheritdoc />
    public partial class preloadSongs : Migration
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "6ace6441-a4cf-4349-8f88-227ac6c6cd6f", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMSban4WqDF0731ez6c70Ma9HaelxkipuFsPCBnz6nelI77x/ShJhFUSq7wdDKSB4g==", null, false, "ad62e84a-9d9f-47fb-a8dc-b0280915cd4a", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumID", "ArtistId", "ArtistsArtistID", "CreatedBy", "DateCreated", "DateUpdated", "Duration", "FilePath", "GenID", "Id", "LikedS", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8679), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8688), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Don Toliver - No Pole.mp3", 1, 0, "NotLiked", "Don Toliver - No Pole", "Seeder" },
                    { 2, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8700), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8701), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人.mp3", 1, 0, "NotLiked", "Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人", "Seeder" },
                    { 3, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8702), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8703), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Goblin Slayer - Rightfully _ Mili [Full].mp3", 1, 0, "NotLiked", "Goblin Slayer - Rightfully _ Mili [Full]", "Seeder" },
                    { 4, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8705), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8705), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Goblins from Mars  - Put Your Love In Dreamz.mp3", 1, 0, "NotLiked", "Goblins from Mars  - Put Your Love In Dreamz", "Seeder" },
                    { 5, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8706), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8707), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Goblins from Mars - Cold Blooded Love (ft. Krista Marina).mp3", 1, 0, "NotLiked", "Goblins from Mars - Cold Blooded Love (ft. Krista Marina)", "Seeder" },
                    { 6, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8709), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8709), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Goblins from Mars - Heart Afire When The Bassjumps.mp3", 1, 0, "NotLiked", "Goblins from Mars - Heart Afire When The Bassjumps", "Seeder" },
                    { 7, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8711), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8711), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC].mp3", 1, 0, "NotLiked", "Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC]", "Seeder" },
                    { 8, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8713), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8713), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC].mp3", 1, 0, "NotLiked", "Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC]", "Seeder" },
                    { 9, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8714), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8714), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\grandson - Despicable.mp3", 1, 0, "NotLiked", "grandson - Despicable", "Seeder" },
                    { 10, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8716), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8716), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Greatest Battle Music Of All Times Saijaku Muhai.mp3", 1, 0, "NotLiked", "Greatest Battle Music Of All Times Saijaku Muhai", "Seeder" },
                    { 11, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8718), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8718), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Gundam - OP1 HD.mp3", 1, 0, "NotLiked", "Gundam - OP1 HD", "Seeder" },
                    { 12, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8719), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8719), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Gundam - Seed.mp3", 1, 0, "NotLiked", "Gundam - Seed", "Seeder" },
                    { 13, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8720), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8720), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Hans Zimmer - Flight.mp3", 1, 0, "NotLiked", "Hans Zimmer - Flight", "Seeder" },
                    { 14, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8721), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8722), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music", "Seeder" },
                    { 15, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8723), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8723), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Hiroyuki Sawano Impure King Suite Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano Impure King Suite Epic Battle Music", "Seeder" },
                    { 16, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8724), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8724), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\HOPE.mp3", 1, 0, "NotLiked", "HOPE", "Seeder" },
                    { 17, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8726), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8726), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\HOTD - Pentakill .mp3", 1, 0, "NotLiked", "HOTD - Pentakill ", "Seeder" },
                    { 18, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8733), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8733), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\i feel like i did too much Don Toliver - No Idea (Lyrics).mp3", 1, 0, "NotLiked", "i feel like i did too much Don Toliver - No Idea (Lyrics)", "Seeder" },
                    { 19, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8734), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8735), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\I NEED U (Official MV).mp3", 1, 0, "NotLiked", "I NEED U (Official MV)", "Seeder" },
                    { 20, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8736), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8736), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\IDOL Official MV.mp3", 1, 0, "NotLiked", "IDOL Official MV", "Seeder" },
                    { 21, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8764), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8765), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix].mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix]", "Seeder" },
                    { 22, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8766), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8766), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Imagine Dragons - Believer.mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer", "Seeder" },
                    { 23, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8768), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8768), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\ISLAND OST - Island Opening Full「Eien no Hitotsu」.mp3", 1, 0, "NotLiked", "ISLAND OST - Island Opening Full「Eien no Hitotsu」", "Seeder" },
                    { 24, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8769), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8769), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\ISLAND OST - Lasting Memories FULL.mp3", 1, 0, "NotLiked", "ISLAND OST - Lasting Memories FULL", "Seeder" },
                    { 25, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8770), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8771), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\J.Fla  - Havana.mp3", 1, 0, "NotLiked", "J.Fla  - Havana", "Seeder" },
                    { 26, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8772), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8772), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Jacob Lee - Demons.mp3", 1, 0, "NotLiked", "Jacob Lee - Demons", "Seeder" },
                    { 27, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8773), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8773), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Jaden - GOKU.mp3", 1, 0, "NotLiked", "Jaden - GOKU", "Seeder" },
                    { 28, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8774), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8775), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Justin Stone - Lungs (Prod. Alex Collins).mp3", 1, 0, "NotLiked", "Justin Stone - Lungs (Prod. Alex Collins)", "Seeder" },
                    { 29, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8776), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8776), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Kaguya-Sama - Love is war (feat. Masayuki Suzuki) .mp3", 1, 0, "NotLiked", "Kaguya-Sama - Love is war (feat. Masayuki Suzuki) ", "Seeder" },
                    { 30, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8777), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8778), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki.mp3", 1, 0, "NotLiked", "Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki", "Seeder" },
                    { 31, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8779), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8779), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Kakusei [Awakening].mp3", 1, 0, "NotLiked", "Kakusei [Awakening]", "Seeder" },
                    { 32, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8781), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8781), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Kamikaze Feat. Lox Chatterbox.mp3", 1, 0, "NotLiked", "Kamikaze Feat. Lox Chatterbox", "Seeder" },
                    { 33, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8782), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8782), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\KANA-BOON - Silhouette.mp3", 1, 0, "NotLiked", "KANA-BOON - Silhouette", "Seeder" },
                    { 34, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8785), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8786), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends.mp3", 1, 0, "NotLiked", "KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends", "Seeder" },
                    { 35, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8787), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8787), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP.mp3", 1, 0, "NotLiked", "Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP", "Seeder" },
                    { 36, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8788), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8789), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\khai dreams - sunkissed.mp3", 1, 0, "NotLiked", "khai dreams - sunkissed", "Seeder" },
                    { 37, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8790), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8790), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Kibou No Uta Lyrics.mp3", 1, 0, "NotLiked", "Kibou No Uta Lyrics", "Seeder" },
                    { 38, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8791), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8791), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Krewella - Calm Down (SKAN Remix).mp3", 1, 0, "NotLiked", "Krewella - Calm Down (SKAN Remix)", "Seeder" },
                    { 39, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8792), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8793), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\KSI & Randolph - Champagne (Official Audio).mp3", 1, 0, "NotLiked", "KSI & Randolph - Champagne (Official Audio)", "Seeder" },
                    { 40, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8794), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8794), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\KUURO - Afraid of the Dark (feat. Sophiya) .mp3", 1, 0, "NotLiked", "KUURO - Afraid of the Dark (feat. Sophiya) ", "Seeder" },
                    { 41, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8795), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8795), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\KUURO - What U Wanna Do.mp3", 1, 0, "NotLiked", "KUURO - What U Wanna Do", "Seeder" },
                    { 42, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8796), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8796), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\LAYTO - Little Poor Me.mp3", 1, 0, "NotLiked", "LAYTO - Little Poor Me", "Seeder" },
                    { 43, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8798), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8798), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends.mp3", 1, 0, "NotLiked", "Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends", "Seeder" },
                    { 44, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8799), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8799), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Leonhart - Grancrest Senki OST - Hope.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST - Hope", "Seeder" },
                    { 45, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8800), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8800), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Leonhart - Grancrest Senki OST.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST", "Seeder" },
                    { 46, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8801), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8802), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Liam Ferrari - I Like The Way.mp3", 1, 0, "NotLiked", "Liam Ferrari - I Like The Way", "Seeder" },
                    { 47, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8803), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8803), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Lil Nas X Billy Ray Cyrus - Old Town Road (Remix).mp3", 1, 0, "NotLiked", "Lil Nas X Billy Ray Cyrus - Old Town Road (Remix)", "Seeder" },
                    { 48, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8804), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8804), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\LIL SKIES - Boss Up.mp3", 1, 0, "NotLiked", "LIL SKIES - Boss Up", "Seeder" },
                    { 49, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8805), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8805), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\LIL SKIES - Lust.mp3", 1, 0, "NotLiked", "LIL SKIES - Lust", "Seeder" },
                    { 50, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8806), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8807), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Lil Uzi Vert - XO Tour Llif3 .mp3", 1, 0, "NotLiked", "Lil Uzi Vert - XO Tour Llif3 ", "Seeder" },
                    { 51, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8808), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8808), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Lilianna Wilde - Grind Me Down (Jawster Remix).mp3", 1, 0, "NotLiked", "Lilianna Wilde - Grind Me Down (Jawster Remix)", "Seeder" },
                    { 52, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8809), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8809), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\LiSA - Catch the Moment.mp3", 1, 0, "NotLiked", "LiSA - Catch the Moment", "Seeder" },
                    { 53, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8810), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8810), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\LiSA - Crossing Field.mp3", 1, 0, "NotLiked", "LiSA - Crossing Field", "Seeder" },
                    { 54, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8811), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8812), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Look Alive [BASS BOOSTED].mp3", 1, 0, "NotLiked", "Look Alive [BASS BOOSTED]", "Seeder" },
                    { 55, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8812), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8813), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Lyrics Owari no Seraph OST - 108.mp3", 1, 0, "NotLiked", "Lyrics Owari no Seraph OST - 108", "Seeder" },
                    { 56, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8814), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8814), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ.mp3", 1, 0, "NotLiked", "MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ", "Seeder" },
                    { 57, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8815), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8815), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Magnolia.mp3", 1, 0, "NotLiked", "Magnolia", "Seeder" },
                    { 58, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8816), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8817), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Maroon 5 - Sugar.mp3", 1, 0, "NotLiked", "Maroon 5 - Sugar", "Seeder" },
                    { 59, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8818), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8818), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Maroon 5 Ft. Wiz Khalifa.mp3", 1, 0, "NotLiked", "Maroon 5 Ft. Wiz Khalifa", "Seeder" },
                    { 60, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8867), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8867), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\MHW ICEBORNE Safi Jiiva Battle Theme OST.mp3", 1, 0, "NotLiked", "MHW ICEBORNE Safi Jiiva Battle Theme OST", "Seeder" },
                    { 61, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8868), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8869), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\MIC Drop (Steve Aoki Remix) Official MV.mp3", 1, 0, "NotLiked", "MIC Drop (Steve Aoki Remix) Official MV", "Seeder" },
                    { 62, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8870), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8870), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Migos - Get Right Witcha (G-REX X TOP $HELF Remix).mp3", 1, 0, "NotLiked", "Migos - Get Right Witcha (G-REX X TOP $HELF Remix)", "Seeder" },
                    { 63, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8872), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8872), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura.mp3", 1, 0, "NotLiked", "MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura", "Seeder" },
                    { 64, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8874), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8875), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Moonlight.mp3", 1, 0, "NotLiked", "Moonlight", "Seeder" },
                    { 65, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8876), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8876), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records.mp3", 1, 0, "NotLiked", "Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records", "Seeder" },
                    { 66, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8878), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8878), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Mrs. GREEN APPLE - インフェルノInferno.mp3", 1, 0, "NotLiked", "Mrs. GREEN APPLE - インフェルノInferno", "Seeder" },
                    { 67, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8879), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8880), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2).mp3", 1, 0, "NotLiked", "My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2)", "Seeder" },
                    { 68, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8881), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8881), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version).mp3", 1, 0, "NotLiked", "My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version)", "Seeder" },
                    { 69, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8883), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8883), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Namirin  - Renai Circulation「恋愛サーキュレーショ.mp3", 1, 0, "NotLiked", "Namirin  - Renai Circulation「恋愛サーキュレーショ", "Seeder" },
                    { 70, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8884), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8885), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Nanatsu no Taizai S2 - Escanor Theme (Rearrangement).mp3", 1, 0, "NotLiked", "Nanatsu no Taizai S2 - Escanor Theme (Rearrangement)", "Seeder" },
                    { 71, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8886), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8886), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\NEFFEX - Fight Back.mp3", 1, 0, "NotLiked", "NEFFEX - Fight Back", "Seeder" },
                    { 72, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8887), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8887), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\NEFFEX - Myself.mp3", 1, 0, "NotLiked", "NEFFEX - Myself", "Seeder" },
                    { 73, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8888), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8889), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro).mp3", 1, 0, "NotLiked", "Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro)", "Seeder" },
                    { 74, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8890), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8890), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Nightcore - Control.mp3", 1, 0, "NotLiked", "Nightcore - Control", "Seeder" },
                    { 75, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8891), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8891), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Nightcore - Rockefeller Street.mp3", 1, 0, "NotLiked", "Nightcore - Rockefeller Street", "Seeder" },
                    { 76, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8892), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8893), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\No Game No Life Opening Full.mp3", 1, 0, "NotLiked", "No Game No Life Opening Full", "Seeder" },
                    { 77, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8894), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8894), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Not Today Official MV.mp3", 1, 0, "NotLiked", "Not Today Official MV", "Seeder" },
                    { 78, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8895), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8895), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Nto - Trauma (Worakls Remix).mp3", 1, 0, "NotLiked", "Nto - Trauma (Worakls Remix)", "Seeder" },
                    { 79, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8896), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8897), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Owari no Seraph OST - 1hundredknight M [終わりのセラフ].mp3", 1, 0, "NotLiked", "Owari no Seraph OST - 1hundredknight M [終わりのセラフ]", "Seeder" },
                    { 80, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8898), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8898), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack.mp3", 1, 0, "NotLiked", "Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack", "Seeder" },
                    { 81, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8899), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8899), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Post Malone - Better Now.mp3", 1, 0, "NotLiked", "Post Malone - Better Now", "Seeder" },
                    { 82, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8900), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8900), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Post Malone_ 21 Savage - Rockstar.mp3", 1, 0, "NotLiked", "Post Malone_ 21 Savage - Rockstar", "Seeder" },
                    { 83, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8901), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8902), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Reverse feat. G-Eazy.mp3", 1, 0, "NotLiked", "Reverse feat. G-Eazy", "Seeder" },
                    { 84, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8902), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8903), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Rich The Kid - Plug Walk (Audio).mp3", 1, 0, "NotLiked", "Rich The Kid - Plug Walk (Audio)", "Seeder" },
                    { 85, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8903), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8904), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Right Now.mp3", 1, 0, "NotLiked", "Right Now", "Seeder" },
                    { 86, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8905), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8905), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends.mp3", 1, 0, "NotLiked", "RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends", "Seeder" },
                    { 87, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8906), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8907), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST.mp3", 1, 0, "NotLiked", "Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST", "Seeder" },
                    { 88, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8908), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8908), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\SAD!.mp3", 1, 0, "NotLiked", "SAD!", "Seeder" },
                    { 89, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8909), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8909), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Saijaku Muhai no Bahamut  - Saijaku Muhai OST.mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut  - Saijaku Muhai OST", "Seeder" },
                    { 90, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8910), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8911), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only).mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only)", "Seeder" },
                    { 91, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8912), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8912), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Sakura - 落ち着いて冷やす.mp3", 1, 0, "NotLiked", "Sakura - 落ち着いて冷やす", "Seeder" },
                    { 92, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8913), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8913), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\SAMAHTA - graffiti (feat. Melody Federer).mp3", 1, 0, "NotLiked", "SAMAHTA - graffiti (feat. Melody Federer)", "Seeder" },
                    { 93, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8915), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8915), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte", "Seeder" },
                    { 94, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8916), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8916), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Shawn Mendes - Mercy.mp3", 1, 0, "NotLiked", "Shawn Mendes - Mercy", "Seeder" },
                    { 95, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8917), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8917), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Shawn Mendes - Stitches.mp3", 1, 0, "NotLiked", "Shawn Mendes - Stitches", "Seeder" },
                    { 96, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8918), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8919), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Shawn Mendes - Theres Nothing Holdin Me Back.mp3", 1, 0, "NotLiked", "Shawn Mendes - Theres Nothing Holdin Me Back", "Seeder" },
                    { 97, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8941), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8942), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Shawn Mendes - Treat You Better.mp3", 1, 0, "NotLiked", "Shawn Mendes - Treat You Better", "Seeder" },
                    { 98, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8943), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8943), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Sheck Wes - Mo Bamba.mp3", 1, 0, "NotLiked", "Sheck Wes - Mo Bamba", "Seeder" },
                    { 99, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8945), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8945), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte", "Seeder" },
                    { 100, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8946), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8946), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Sickick - Infected.mp3", 1, 0, "NotLiked", "Sickick - Infected", "Seeder" },
                    { 101, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8947), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8947), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Sickick - Mind Games.mp3", 1, 0, "NotLiked", "Sickick - Mind Games", "Seeder" },
                    { 102, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8948), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8949), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\SickickMusic - Lost My Way.mp3", 1, 0, "NotLiked", "SickickMusic - Lost My Way", "Seeder" },
                    { 103, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8949), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8950), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Skan & Krale - No Glory (feat. M.I.M.E & Drama B).mp3", 1, 0, "NotLiked", "Skan & Krale - No Glory (feat. M.I.M.E & Drama B)", "Seeder" },
                    { 104, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8951), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8951), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW.mp3", 1, 0, "NotLiked", "SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW", "Seeder" },
                    { 105, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8952), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8953), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\SKRILLEX - Bangarang feat. Sirah.mp3", 1, 0, "NotLiked", "SKRILLEX - Bangarang feat. Sirah", "Seeder" },
                    { 106, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8954), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8954), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix).mp3", 1, 0, "NotLiked", "Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix)", "Seeder" },
                    { 107, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8955), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8955), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Soredemo sekai wa utsukushii - Beautiful rain full ver..mp3", 1, 0, "NotLiked", "Soredemo sekai wa utsukushii - Beautiful rain full ver.", "Seeder" },
                    { 108, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8956), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8957), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna].mp3", 1, 0, "NotLiked", "Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna]", "Seeder" },
                    { 109, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8958), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\STéLOUSE - Sociopath (feat. Bryce Fox).mp3", 1, 0, "NotLiked", "STéLOUSE - Sociopath (feat. Bryce Fox)", "Seeder" },
                    { 110, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8959), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8959), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Sufian Suhaimi - Di Matamu.mp3", 1, 0, "NotLiked", "Sufian Suhaimi - Di Matamu", "Seeder" },
                    { 111, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8961), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8961), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting", "Seeder" },
                    { 112, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8962), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8962), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub", "Seeder" },
                    { 113, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8963), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8964), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION.mp3", 1, 0, "NotLiked", "Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION", "Seeder" },
                    { 114, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8965), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8965), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\TETRA-FANG - Supernova.mp3", 1, 0, "NotLiked", "TETRA-FANG - Supernova", "Seeder" },
                    { 115, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8966), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8966), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\The Mirza - Lelah Mengalah.mp3", 1, 0, "NotLiked", "The Mirza - Lelah Mengalah", "Seeder" },
                    { 116, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8967), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8967), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\The Soul of Wind -  🗻 The Mountains 🗻.mp3", 1, 0, "NotLiked", "The Soul of Wind -  🗻 The Mountains 🗻", "Seeder" },
                    { 117, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8968), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8969), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\TheFatRat - Fly Away feat. Anjulie.mp3", 1, 0, "NotLiked", "TheFatRat - Fly Away feat. Anjulie", "Seeder" },
                    { 118, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8970), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8970), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\TheFatRat - Monody (feat. Laura Brehm).mp3", 1, 0, "NotLiked", "TheFatRat - Monody (feat. Laura Brehm)", "Seeder" },
                    { 119, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8971), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8971), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\TheFatRat - Time Lapse.mp3", 1, 0, "NotLiked", "TheFatRat - Time Lapse", "Seeder" },
                    { 120, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8972), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8972), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\TheFatRat - Unity.mp3", 1, 0, "NotLiked", "TheFatRat - Unity", "Seeder" },
                    { 121, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8973), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8974), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\TIIMO - Bangin In the Club.mp3", 1, 0, "NotLiked", "TIIMO - Bangin In the Club", "Seeder" },
                    { 122, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8975), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8975), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-].mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-]", "Seeder" },
                    { 123, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8976), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8976), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Unravel (Marco B. Remix).mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (Marco B. Remix)", "Seeder" },
                    { 124, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8977), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8978), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Unravel (OP Piano) .mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (OP Piano) ", "Seeder" },
                    { 125, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8978), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8979), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Unravel 2.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel 2", "Seeder" },
                    { 126, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8979), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8980), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Unravel.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel", "Seeder" },
                    { 127, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8981), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8981), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Tokyo Machine - FLY [Monstercat Release].mp3", 1, 0, "NotLiked", "Tokyo Machine - FLY [Monstercat Release]", "Seeder" },
                    { 128, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8982), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8983), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Trapcity - Dead To Me (feat. Lox Chatterbox).mp3", 1, 0, "NotLiked", "Trapcity - Dead To Me (feat. Lox Chatterbox)", "Seeder" },
                    { 129, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8984), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8984), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Trapcity - Samurai☯ Lofi.mp3", 1, 0, "NotLiked", "Trapcity - Samurai☯ Lofi", "Seeder" },
                    { 130, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8985), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8986), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Trapcity - Trap Queen (Crankdat Remix).mp3", 1, 0, "NotLiked", "Trapcity - Trap Queen (Crankdat Remix)", "Seeder" },
                    { 131, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8987), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(8987), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Travis Scott - SICKO MODE.mp3", 1, 0, "NotLiked", "Travis Scott - SICKO MODE", "Seeder" },
                    { 132, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9005), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9006), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Two Feet - I Feel Like Im Drowning.mp3", 1, 0, "NotLiked", "Two Feet - I Feel Like Im Drowning", "Seeder" },
                    { 133, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9007), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9007), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Unlike Pluto ft. Mike Taylor - Everything Black.mp3", 1, 0, "NotLiked", "Unlike Pluto ft. Mike Taylor - Everything Black", "Seeder" },
                    { 134, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9008), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9009), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Wishing Lyrics Rem(minase inori) ReZero.mp3", 1, 0, "NotLiked", "Wishing Lyrics Rem(minase inori) ReZero", "Seeder" },
                    { 135, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9010), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9010), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\XXXTENTACION - BAD!.mp3", 1, 0, "NotLiked", "XXXTENTACION - BAD!", "Seeder" },
                    { 136, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9011), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9011), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics].mp3", 1, 0, "NotLiked", "Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics]", "Seeder" },
                    { 137, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9012), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9013), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Yasuha - Flyday Chinatown.mp3", 1, 0, "NotLiked", "Yasuha - Flyday Chinatown", "Seeder" },
                    { 138, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9014), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9014), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\YOASOBI 夜に駆ける English & Romanji Lyrics.mp3", 1, 0, "NotLiked", "YOASOBI 夜に駆ける English & Romanji Lyrics", "Seeder" },
                    { 139, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9015), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9015), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\YOASOBIハルジオンOfficial Music Video.mp3", 1, 0, "NotLiked", "YOASOBIハルジオンOfficial Music Video", "Seeder" },
                    { 140, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9016), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9017), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Yuna - Longing.mp3", 1, 0, "NotLiked", "Yuna - Longing", "Seeder" },
                    { 141, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9018), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9018), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\Yuna - Smile for you .mp3", 1, 0, "NotLiked", "Yuna - Smile for you ", "Seeder" },
                    { 142, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9019), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9019), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\タイニーリトルアシアンタム.mp3", 1, 0, "NotLiked", "タイニーリトルアシアンタム", "Seeder" },
                    { 143, 1, 1, null, "Seeder", new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9020), new DateTime(2025, 1, 25, 22, 40, 43, 599, DateTimeKind.Local).AddTicks(9020), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\itisg\\source\\repos\\Pancake_Final\\Pancake_Final\\wwwroot\\music\\レペゼン地球66thシングルO2MEN.mp3", 1, 0, "NotLiked", "レペゼン地球66thシングルO2MEN", "Seeder" }
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
                name: "Playlist");

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
        }
    }
}
