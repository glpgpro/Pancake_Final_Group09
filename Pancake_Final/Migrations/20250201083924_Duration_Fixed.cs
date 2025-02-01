using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pancake_Final.Migrations
{
    /// <inheritdoc />
    public partial class Duration_Fixed : Migration
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
                    UserId = table.Column<int>(type: "int", nullable: true),
                    SongId = table.Column<int>(type: "int", nullable: true),
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
                    PlaylistID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    PlaylistName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlist", x => x.PlaylistID);
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
                name: "Song",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: true),
                    AlbumID = table.Column<int>(type: "int", nullable: true),
                    GenID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LikedS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    ArtistsArtistID = table.Column<int>(type: "int", nullable: true),
                    PlaylistID = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Song_Playlist_PlaylistID",
                        column: x => x.PlaylistID,
                        principalTable: "Playlist",
                        principalColumn: "PlaylistID");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "b3318db6-2208-483b-a852-a5cdf91e1300", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENYiWSj8oRiNGODYwgszuKMcstyKxQj07sImCI3K0+M6mAYNhqwBU9WblYxYsGQ44Q==", null, false, "b9951281-5e5a-4fc9-86e1-2b6511fe13f9", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumID", "ArtistId", "ArtistsArtistID", "CreatedBy", "DateCreated", "DateUpdated", "Duration", "FilePath", "GenID", "Id", "LikedS", "Name", "PlaylistID", "UpdateBy" },
                values: new object[,]
                {
                    { 1, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 391, DateTimeKind.Local).AddTicks(3410), new DateTime(2025, 2, 1, 16, 39, 24, 391, DateTimeKind.Local).AddTicks(3420), new TimeSpan(1877739166), "/music/Don Toliver - No Pole.mp3", 1, 0, "NotLiked", "Don Toliver - No Pole", null, "Seeder" },
                    { 2, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 391, DateTimeKind.Local).AddTicks(9075), new DateTime(2025, 2, 1, 16, 39, 24, 391, DateTimeKind.Local).AddTicks(9082), new TimeSpan(1297645833), "/music/Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人.mp3", 1, 0, "NotLiked", "Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人", null, "Seeder" },
                    { 3, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 392, DateTimeKind.Local).AddTicks(5370), new DateTime(2025, 2, 1, 16, 39, 24, 392, DateTimeKind.Local).AddTicks(5457), new TimeSpan(2111185000), "/music/Goblin Slayer - Rightfully _ Mili [Full].mp3", 1, 0, "NotLiked", "Goblin Slayer - Rightfully _ Mili [Full]", null, "Seeder" },
                    { 4, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 392, DateTimeKind.Local).AddTicks(7617), new DateTime(2025, 2, 1, 16, 39, 24, 392, DateTimeKind.Local).AddTicks(7620), new TimeSpan(1873305000), "/music/Goblins from Mars  - Put Your Love In Dreamz.mp3", 1, 0, "NotLiked", "Goblins from Mars  - Put Your Love In Dreamz", null, "Seeder" },
                    { 5, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 392, DateTimeKind.Local).AddTicks(8734), new DateTime(2025, 2, 1, 16, 39, 24, 392, DateTimeKind.Local).AddTicks(8735), new TimeSpan(1812530833), "/music/Goblins from Mars - Cold Blooded Love (ft. Krista Marina).mp3", 1, 0, "NotLiked", "Goblins from Mars - Cold Blooded Love (ft. Krista Marina)", null, "Seeder" },
                    { 6, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 393, DateTimeKind.Local).AddTicks(238), new DateTime(2025, 2, 1, 16, 39, 24, 393, DateTimeKind.Local).AddTicks(241), new TimeSpan(2091100833), "/music/Goblins from Mars - Heart Afire When The Bassjumps.mp3", 1, 0, "NotLiked", "Goblins from Mars - Heart Afire When The Bassjumps", null, "Seeder" },
                    { 7, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 393, DateTimeKind.Local).AddTicks(1999), new DateTime(2025, 2, 1, 16, 39, 24, 393, DateTimeKind.Local).AddTicks(2002), new TimeSpan(2760920833), "/music/Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC].mp3", 1, 0, "NotLiked", "Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC]", null, "Seeder" },
                    { 8, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 393, DateTimeKind.Local).AddTicks(3550), new DateTime(2025, 2, 1, 16, 39, 24, 393, DateTimeKind.Local).AddTicks(3553), new TimeSpan(2822477500), "/music/Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC].mp3", 1, 0, "NotLiked", "Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC]", null, "Seeder" },
                    { 9, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 393, DateTimeKind.Local).AddTicks(6056), new DateTime(2025, 2, 1, 16, 39, 24, 393, DateTimeKind.Local).AddTicks(6060), new TimeSpan(2235863333), "/music/grandson - Despicable.mp3", 1, 0, "NotLiked", "grandson - Despicable", null, "Seeder" },
                    { 10, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 393, DateTimeKind.Local).AddTicks(8417), new DateTime(2025, 2, 1, 16, 39, 24, 393, DateTimeKind.Local).AddTicks(8420), new TimeSpan(1464057500), "/music/Greatest Battle Music Of All Times Saijaku Muhai.mp3", 1, 0, "NotLiked", "Greatest Battle Music Of All Times Saijaku Muhai", null, "Seeder" },
                    { 11, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 394, DateTimeKind.Local).AddTicks(169), new DateTime(2025, 2, 1, 16, 39, 24, 394, DateTimeKind.Local).AddTicks(172), new TimeSpan(916307500), "/music/Gundam - OP1 HD.mp3", 1, 0, "NotLiked", "Gundam - OP1 HD", null, "Seeder" },
                    { 12, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 394, DateTimeKind.Local).AddTicks(1721), new DateTime(2025, 2, 1, 16, 39, 24, 394, DateTimeKind.Local).AddTicks(1722), new TimeSpan(0, 0, 3, 57, 567), "/music/Gundam - Seed.mp3", 1, 0, "NotLiked", "Gundam - Seed", null, "Seeder" },
                    { 13, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 394, DateTimeKind.Local).AddTicks(3165), new DateTime(2025, 2, 1, 16, 39, 24, 394, DateTimeKind.Local).AddTicks(3167), new TimeSpan(2539995000), "/music/Hans Zimmer - Flight.mp3", 1, 0, "NotLiked", "Hans Zimmer - Flight", null, "Seeder" },
                    { 14, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 394, DateTimeKind.Local).AddTicks(5828), new DateTime(2025, 2, 1, 16, 39, 24, 394, DateTimeKind.Local).AddTicks(5831), new TimeSpan(5451416666), "/music/Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music", null, "Seeder" },
                    { 15, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 394, DateTimeKind.Local).AddTicks(7820), new DateTime(2025, 2, 1, 16, 39, 24, 394, DateTimeKind.Local).AddTicks(7824), new TimeSpan(0, 0, 8, 25, 182), "/music/Hiroyuki Sawano Impure King Suite Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano Impure King Suite Epic Battle Music", null, "Seeder" },
                    { 16, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 394, DateTimeKind.Local).AddTicks(9538), new DateTime(2025, 2, 1, 16, 39, 24, 394, DateTimeKind.Local).AddTicks(9540), new TimeSpan(1010207500), "/music/HOPE.mp3", 1, 0, "NotLiked", "HOPE", null, "Seeder" },
                    { 17, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 395, DateTimeKind.Local).AddTicks(1136), new DateTime(2025, 2, 1, 16, 39, 24, 395, DateTimeKind.Local).AddTicks(1138), new TimeSpan(2029805000), "/music/HOTD - Pentakill .mp3", 1, 0, "NotLiked", "HOTD - Pentakill ", null, "Seeder" },
                    { 18, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 395, DateTimeKind.Local).AddTicks(2529), new DateTime(2025, 2, 1, 16, 39, 24, 395, DateTimeKind.Local).AddTicks(2531), new TimeSpan(1892867500), "/music/i feel like i did too much Don Toliver - No Idea (Lyrics).mp3", 1, 0, "NotLiked", "i feel like i did too much Don Toliver - No Idea (Lyrics)", null, "Seeder" },
                    { 19, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 395, DateTimeKind.Local).AddTicks(4957), new DateTime(2025, 2, 1, 16, 39, 24, 395, DateTimeKind.Local).AddTicks(4960), new TimeSpan(2197520833), "/music/I NEED U (Official MV).mp3", 1, 0, "NotLiked", "I NEED U (Official MV)", null, "Seeder" },
                    { 20, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 395, DateTimeKind.Local).AddTicks(7709), new DateTime(2025, 2, 1, 16, 39, 24, 395, DateTimeKind.Local).AddTicks(7712), new TimeSpan(2315417500), "/music/IDOL Official MV.mp3", 1, 0, "NotLiked", "IDOL Official MV", null, "Seeder" },
                    { 21, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 395, DateTimeKind.Local).AddTicks(9807), new DateTime(2025, 2, 1, 16, 39, 24, 395, DateTimeKind.Local).AddTicks(9810), new TimeSpan(0, 0, 2, 43, 73), "/music/Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix].mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix]", null, "Seeder" },
                    { 22, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 396, DateTimeKind.Local).AddTicks(1447), new DateTime(2025, 2, 1, 16, 39, 24, 396, DateTimeKind.Local).AddTicks(1450), new TimeSpan(2166742500), "/music/Imagine Dragons - Believer.mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer", null, "Seeder" },
                    { 23, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 396, DateTimeKind.Local).AddTicks(3107), new DateTime(2025, 2, 1, 16, 39, 24, 396, DateTimeKind.Local).AddTicks(3110), new TimeSpan(0, 0, 5, 23, 329), "/music/ISLAND OST - Island Opening Full「Eien no Hitotsu」.mp3", 1, 0, "NotLiked", "ISLAND OST - Island Opening Full「Eien no Hitotsu」", null, "Seeder" },
                    { 24, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 396, DateTimeKind.Local).AddTicks(5492), new DateTime(2025, 2, 1, 16, 39, 24, 396, DateTimeKind.Local).AddTicks(5495), new TimeSpan(3018363333), "/music/ISLAND OST - Lasting Memories FULL.mp3", 1, 0, "NotLiked", "ISLAND OST - Lasting Memories FULL", null, "Seeder" },
                    { 25, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 396, DateTimeKind.Local).AddTicks(7817), new DateTime(2025, 2, 1, 16, 39, 24, 396, DateTimeKind.Local).AddTicks(7821), new TimeSpan(1347204166), "/music/J.Fla  - Havana.mp3", 1, 0, "NotLiked", "J.Fla  - Havana", null, "Seeder" },
                    { 26, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 397, DateTimeKind.Local).AddTicks(7), new DateTime(2025, 2, 1, 16, 39, 24, 397, DateTimeKind.Local).AddTicks(10), new TimeSpan(0, 0, 4, 11, 652), "/music/Jacob Lee - Demons.mp3", 1, 0, "NotLiked", "Jacob Lee - Demons", null, "Seeder" },
                    { 27, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 397, DateTimeKind.Local).AddTicks(1451), new DateTime(2025, 2, 1, 16, 39, 24, 397, DateTimeKind.Local).AddTicks(1453), new TimeSpan(0, 0, 3, 25, 641), "/music/Jaden - GOKU.mp3", 1, 0, "NotLiked", "Jaden - GOKU", null, "Seeder" },
                    { 28, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 397, DateTimeKind.Local).AddTicks(2792), new DateTime(2025, 2, 1, 16, 39, 24, 397, DateTimeKind.Local).AddTicks(2794), new TimeSpan(0, 0, 2, 50, 898), "/music/Justin Stone - Lungs (Prod. Alex Collins).mp3", 1, 0, "NotLiked", "Justin Stone - Lungs (Prod. Alex Collins)", null, "Seeder" },
                    { 29, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 397, DateTimeKind.Local).AddTicks(4423), new DateTime(2025, 2, 1, 16, 39, 24, 397, DateTimeKind.Local).AddTicks(4425), new TimeSpan(2634677500), "/music/Kaguya-Sama - Love is war (feat. Masayuki Suzuki) .mp3", 1, 0, "NotLiked", "Kaguya-Sama - Love is war (feat. Masayuki Suzuki) ", null, "Seeder" },
                    { 30, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 397, DateTimeKind.Local).AddTicks(6973), new DateTime(2025, 2, 1, 16, 39, 24, 397, DateTimeKind.Local).AddTicks(6977), new TimeSpan(2541299166), "/music/Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki.mp3", 1, 0, "NotLiked", "Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki", null, "Seeder" },
                    { 31, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 397, DateTimeKind.Local).AddTicks(8694), new DateTime(2025, 2, 1, 16, 39, 24, 397, DateTimeKind.Local).AddTicks(8697), new TimeSpan(2771615000), "/music/Kakusei [Awakening].mp3", 1, 0, "NotLiked", "Kakusei [Awakening]", null, "Seeder" },
                    { 32, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(293), new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(296), new TimeSpan(1819312500), "/music/Kamikaze Feat. Lox Chatterbox.mp3", 1, 0, "NotLiked", "Kamikaze Feat. Lox Chatterbox", null, "Seeder" },
                    { 33, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(1741), new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(1744), new TimeSpan(2651631666), "/music/KANA-BOON - Silhouette.mp3", 1, 0, "NotLiked", "KANA-BOON - Silhouette", null, "Seeder" },
                    { 34, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(3140), new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(3143), new TimeSpan(2030065833), "/music/KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends.mp3", 1, 0, "NotLiked", "KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends", null, "Seeder" },
                    { 35, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(4486), new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(4489), new TimeSpan(2423924166), "/music/Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP.mp3", 1, 0, "NotLiked", "Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP", null, "Seeder" },
                    { 36, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(5868), new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(5870), new TimeSpan(1273127500), "/music/khai dreams - sunkissed.mp3", 1, 0, "NotLiked", "khai dreams - sunkissed", null, "Seeder" },
                    { 37, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(7148), new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(7150), new TimeSpan(2328198333), "/music/Kibou No Uta Lyrics.mp3", 1, 0, "NotLiked", "Kibou No Uta Lyrics", null, "Seeder" },
                    { 38, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(8893), new DateTime(2025, 2, 1, 16, 39, 24, 398, DateTimeKind.Local).AddTicks(8896), new TimeSpan(2271597500), "/music/Krewella - Calm Down (SKAN Remix).mp3", 1, 0, "NotLiked", "Krewella - Calm Down (SKAN Remix)", null, "Seeder" },
                    { 39, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 399, DateTimeKind.Local).AddTicks(249), new DateTime(2025, 2, 1, 16, 39, 24, 399, DateTimeKind.Local).AddTicks(251), new TimeSpan(2126574166), "/music/KSI & Randolph - Champagne (Official Audio).mp3", 1, 0, "NotLiked", "KSI & Randolph - Champagne (Official Audio)", null, "Seeder" },
                    { 40, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 399, DateTimeKind.Local).AddTicks(1867), new DateTime(2025, 2, 1, 16, 39, 24, 399, DateTimeKind.Local).AddTicks(1869), new TimeSpan(2101273333), "/music/KUURO - Afraid of the Dark (feat. Sophiya) .mp3", 1, 0, "NotLiked", "KUURO - Afraid of the Dark (feat. Sophiya) ", null, "Seeder" },
                    { 41, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 399, DateTimeKind.Local).AddTicks(3462), new DateTime(2025, 2, 1, 16, 39, 24, 399, DateTimeKind.Local).AddTicks(3464), new TimeSpan(1921298333), "/music/KUURO - What U Wanna Do.mp3", 1, 0, "NotLiked", "KUURO - What U Wanna Do", null, "Seeder" },
                    { 42, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 399, DateTimeKind.Local).AddTicks(5068), new DateTime(2025, 2, 1, 16, 39, 24, 399, DateTimeKind.Local).AddTicks(5070), new TimeSpan(0, 0, 3, 19, 381), "/music/LAYTO - Little Poor Me.mp3", 1, 0, "NotLiked", "LAYTO - Little Poor Me", null, "Seeder" },
                    { 43, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 399, DateTimeKind.Local).AddTicks(6492), new DateTime(2025, 2, 1, 16, 39, 24, 399, DateTimeKind.Local).AddTicks(6495), new TimeSpan(2351934166), "/music/Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends.mp3", 1, 0, "NotLiked", "Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends", null, "Seeder" },
                    { 44, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 399, DateTimeKind.Local).AddTicks(8122), new DateTime(2025, 2, 1, 16, 39, 24, 399, DateTimeKind.Local).AddTicks(8124), new TimeSpan(1406674166), "/music/Leonhart - Grancrest Senki OST - Hope.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST - Hope", null, "Seeder" },
                    { 45, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 400, DateTimeKind.Local).AddTicks(672), new DateTime(2025, 2, 1, 16, 39, 24, 400, DateTimeKind.Local).AddTicks(675), new TimeSpan(3110176666), "/music/Leonhart - Grancrest Senki OST.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST", null, "Seeder" },
                    { 46, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 400, DateTimeKind.Local).AddTicks(2229), new DateTime(2025, 2, 1, 16, 39, 24, 400, DateTimeKind.Local).AddTicks(2231), new TimeSpan(1668811666), "/music/Liam Ferrari - I Like The Way.mp3", 1, 0, "NotLiked", "Liam Ferrari - I Like The Way", null, "Seeder" },
                    { 47, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 400, DateTimeKind.Local).AddTicks(3690), new DateTime(2025, 2, 1, 16, 39, 24, 400, DateTimeKind.Local).AddTicks(3692), new TimeSpan(1570999166), "/music/Lil Nas X Billy Ray Cyrus - Old Town Road (Remix).mp3", 1, 0, "NotLiked", "Lil Nas X Billy Ray Cyrus - Old Town Road (Remix)", null, "Seeder" },
                    { 48, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 400, DateTimeKind.Local).AddTicks(5672), new DateTime(2025, 2, 1, 16, 39, 24, 400, DateTimeKind.Local).AddTicks(5675), new TimeSpan(0, 0, 2, 44, 638), "/music/LIL SKIES - Boss Up.mp3", 1, 0, "NotLiked", "LIL SKIES - Boss Up", null, "Seeder" },
                    { 49, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 400, DateTimeKind.Local).AddTicks(7123), new DateTime(2025, 2, 1, 16, 39, 24, 400, DateTimeKind.Local).AddTicks(7125), new TimeSpan(1561087499), "/music/LIL SKIES - Lust.mp3", 1, 0, "NotLiked", "LIL SKIES - Lust", null, "Seeder" },
                    { 50, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 400, DateTimeKind.Local).AddTicks(8884), new DateTime(2025, 2, 1, 16, 39, 24, 400, DateTimeKind.Local).AddTicks(8887), new TimeSpan(1803140833), "/music/Lil Uzi Vert - XO Tour Llif3 .mp3", 1, 0, "NotLiked", "Lil Uzi Vert - XO Tour Llif3 ", null, "Seeder" },
                    { 51, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 401, DateTimeKind.Local).AddTicks(539), new DateTime(2025, 2, 1, 16, 39, 24, 401, DateTimeKind.Local).AddTicks(541), new TimeSpan(2002939166), "/music/Lilianna Wilde - Grind Me Down (Jawster Remix).mp3", 1, 0, "NotLiked", "Lilianna Wilde - Grind Me Down (Jawster Remix)", null, "Seeder" },
                    { 52, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 401, DateTimeKind.Local).AddTicks(1979), new DateTime(2025, 2, 1, 16, 39, 24, 401, DateTimeKind.Local).AddTicks(1982), new TimeSpan(0, 0, 4, 44, 204), "/music/LiSA - Catch the Moment.mp3", 1, 0, "NotLiked", "LiSA - Catch the Moment", null, "Seeder" },
                    { 53, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 401, DateTimeKind.Local).AddTicks(3357), new DateTime(2025, 2, 1, 16, 39, 24, 401, DateTimeKind.Local).AddTicks(3360), new TimeSpan(2477916666), "/music/LiSA - Crossing Field.mp3", 1, 0, "NotLiked", "LiSA - Crossing Field", null, "Seeder" },
                    { 54, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 401, DateTimeKind.Local).AddTicks(6538), new DateTime(2025, 2, 1, 16, 39, 24, 401, DateTimeKind.Local).AddTicks(6542), new TimeSpan(1852177500), "/music/Look Alive [BASS BOOSTED].mp3", 1, 0, "NotLiked", "Look Alive [BASS BOOSTED]", null, "Seeder" },
                    { 55, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 401, DateTimeKind.Local).AddTicks(9571), new DateTime(2025, 2, 1, 16, 39, 24, 401, DateTimeKind.Local).AddTicks(9574), new TimeSpan(2581989166), "/music/Lyrics Owari no Seraph OST - 108.mp3", 1, 0, "NotLiked", "Lyrics Owari no Seraph OST - 108", null, "Seeder" },
                    { 56, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 402, DateTimeKind.Local).AddTicks(1801), new DateTime(2025, 2, 1, 16, 39, 24, 402, DateTimeKind.Local).AddTicks(1804), new TimeSpan(2420794166), "/music/MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ.mp3", 1, 0, "NotLiked", "MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ", null, "Seeder" },
                    { 57, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 402, DateTimeKind.Local).AddTicks(3713), new DateTime(2025, 2, 1, 16, 39, 24, 402, DateTimeKind.Local).AddTicks(3715), new TimeSpan(2044411666), "/music/Magnolia.mp3", 1, 0, "NotLiked", "Magnolia", null, "Seeder" },
                    { 58, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 402, DateTimeKind.Local).AddTicks(5292), new DateTime(2025, 2, 1, 16, 39, 24, 402, DateTimeKind.Local).AddTicks(5295), new TimeSpan(2660760833), "/music/Maroon 5 - Sugar.mp3", 1, 0, "NotLiked", "Maroon 5 - Sugar", null, "Seeder" },
                    { 59, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 402, DateTimeKind.Local).AddTicks(6637), new DateTime(2025, 2, 1, 16, 39, 24, 402, DateTimeKind.Local).AddTicks(6640), new TimeSpan(2326633333), "/music/Maroon 5 Ft. Wiz Khalifa.mp3", 1, 0, "NotLiked", "Maroon 5 Ft. Wiz Khalifa", null, "Seeder" },
                    { 60, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 402, DateTimeKind.Local).AddTicks(7995), new DateTime(2025, 2, 1, 16, 39, 24, 402, DateTimeKind.Local).AddTicks(7998), new TimeSpan(3914847500), "/music/MHW ICEBORNE Safi Jiiva Battle Theme OST.mp3", 1, 0, "NotLiked", "MHW ICEBORNE Safi Jiiva Battle Theme OST", null, "Seeder" },
                    { 61, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 402, DateTimeKind.Local).AddTicks(9569), new DateTime(2025, 2, 1, 16, 39, 24, 402, DateTimeKind.Local).AddTicks(9572), new TimeSpan(2741097500), "/music/MIC Drop (Steve Aoki Remix) Official MV.mp3", 1, 0, "NotLiked", "MIC Drop (Steve Aoki Remix) Official MV", null, "Seeder" },
                    { 62, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 403, DateTimeKind.Local).AddTicks(1039), new DateTime(2025, 2, 1, 16, 39, 24, 403, DateTimeKind.Local).AddTicks(1041), new TimeSpan(2436444166), "/music/Migos - Get Right Witcha (G-REX X TOP $HELF Remix).mp3", 1, 0, "NotLiked", "Migos - Get Right Witcha (G-REX X TOP $HELF Remix)", null, "Seeder" },
                    { 63, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 403, DateTimeKind.Local).AddTicks(2422), new DateTime(2025, 2, 1, 16, 39, 24, 403, DateTimeKind.Local).AddTicks(2424), new TimeSpan(2220995833), "/music/MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura.mp3", 1, 0, "NotLiked", "MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura", null, "Seeder" },
                    { 64, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 403, DateTimeKind.Local).AddTicks(3972), new DateTime(2025, 2, 1, 16, 39, 24, 403, DateTimeKind.Local).AddTicks(3975), new TimeSpan(1660986666), "/music/Moonlight.mp3", 1, 0, "NotLiked", "Moonlight", null, "Seeder" },
                    { 65, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 403, DateTimeKind.Local).AddTicks(5482), new DateTime(2025, 2, 1, 16, 39, 24, 403, DateTimeKind.Local).AddTicks(5484), new TimeSpan(2153700833), "/music/Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records.mp3", 1, 0, "NotLiked", "Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records", null, "Seeder" },
                    { 66, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 403, DateTimeKind.Local).AddTicks(7563), new DateTime(2025, 2, 1, 16, 39, 24, 403, DateTimeKind.Local).AddTicks(7566), new TimeSpan(2213692500), "/music/Mrs. GREEN APPLE - インフェルノInferno.mp3", 1, 0, "NotLiked", "Mrs. GREEN APPLE - インフェルノInferno", null, "Seeder" },
                    { 67, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 403, DateTimeKind.Local).AddTicks(9187), new DateTime(2025, 2, 1, 16, 39, 24, 403, DateTimeKind.Local).AddTicks(9190), new TimeSpan(4549455000), "/music/My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2).mp3", 1, 0, "NotLiked", "My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2)", null, "Seeder" },
                    { 68, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(710), new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(713), new TimeSpan(1672463333), "/music/My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version).mp3", 1, 0, "NotLiked", "My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version)", null, "Seeder" },
                    { 69, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(2134), new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(2137), new TimeSpan(2548863333), "/music/Namirin  - Renai Circulation「恋愛サーキュレーショ.mp3", 1, 0, "NotLiked", "Namirin  - Renai Circulation「恋愛サーキュレーショ", null, "Seeder" },
                    { 70, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(3820), new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(3822), new TimeSpan(2596074166), "/music/Nanatsu no Taizai S2 - Escanor Theme (Rearrangement).mp3", 1, 0, "NotLiked", "Nanatsu no Taizai S2 - Escanor Theme (Rearrangement)", null, "Seeder" },
                    { 71, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(5559), new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(5562), new TimeSpan(2005025833), "/music/NEFFEX - Fight Back.mp3", 1, 0, "NotLiked", "NEFFEX - Fight Back", null, "Seeder" },
                    { 72, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(6880), new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(6882), new TimeSpan(1951815833), "/music/NEFFEX - Myself.mp3", 1, 0, "NotLiked", "NEFFEX - Myself", null, "Seeder" },
                    { 73, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(8271), new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(8273), new TimeSpan(2091622500), "/music/Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro).mp3", 1, 0, "NotLiked", "Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro)", null, "Seeder" },
                    { 74, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(9904), new DateTime(2025, 2, 1, 16, 39, 24, 404, DateTimeKind.Local).AddTicks(9907), new TimeSpan(1901735833), "/music/Nightcore - Control.mp3", 1, 0, "NotLiked", "Nightcore - Control", null, "Seeder" },
                    { 75, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 405, DateTimeKind.Local).AddTicks(1276), new DateTime(2025, 2, 1, 16, 39, 24, 405, DateTimeKind.Local).AddTicks(1279), new TimeSpan(1472925833), "/music/Nightcore - Rockefeller Street.mp3", 1, 0, "NotLiked", "Nightcore - Rockefeller Street", null, "Seeder" },
                    { 76, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 405, DateTimeKind.Local).AddTicks(2711), new DateTime(2025, 2, 1, 16, 39, 24, 405, DateTimeKind.Local).AddTicks(2713), new TimeSpan(2801871666), "/music/No Game No Life Opening Full.mp3", 1, 0, "NotLiked", "No Game No Life Opening Full", null, "Seeder" },
                    { 77, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 405, DateTimeKind.Local).AddTicks(4555), new DateTime(2025, 2, 1, 16, 39, 24, 405, DateTimeKind.Local).AddTicks(4558), new TimeSpan(2905161666), "/music/Not Today Official MV.mp3", 1, 0, "NotLiked", "Not Today Official MV", null, "Seeder" },
                    { 78, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 405, DateTimeKind.Local).AddTicks(6755), new DateTime(2025, 2, 1, 16, 39, 24, 405, DateTimeKind.Local).AddTicks(6758), new TimeSpan(6001253333), "/music/Nto - Trauma (Worakls Remix).mp3", 1, 0, "NotLiked", "Nto - Trauma (Worakls Remix)", null, "Seeder" },
                    { 79, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 405, DateTimeKind.Local).AddTicks(8309), new DateTime(2025, 2, 1, 16, 39, 24, 405, DateTimeKind.Local).AddTicks(8312), new TimeSpan(1710023333), "/music/Owari no Seraph OST - 1hundredknight M [終わりのセラフ].mp3", 1, 0, "NotLiked", "Owari no Seraph OST - 1hundredknight M [終わりのセラフ]", null, "Seeder" },
                    { 80, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 405, DateTimeKind.Local).AddTicks(9574), new DateTime(2025, 2, 1, 16, 39, 24, 405, DateTimeKind.Local).AddTicks(9575), new TimeSpan(0, 0, 2, 52, 584), "/music/Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack.mp3", 1, 0, "NotLiked", "Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack", null, "Seeder" },
                    { 81, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(872), new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(874), new TimeSpan(2321677500), "/music/Post Malone - Better Now.mp3", 1, 0, "NotLiked", "Post Malone - Better Now", null, "Seeder" },
                    { 82, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(2356), new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(2358), new TimeSpan(2181349166), "/music/Post Malone_ 21 Savage - Rockstar.mp3", 1, 0, "NotLiked", "Post Malone_ 21 Savage - Rockstar", null, "Seeder" },
                    { 83, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(3650), new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(3652), new TimeSpan(2120575000), "/music/Reverse feat. G-Eazy.mp3", 1, 0, "NotLiked", "Reverse feat. G-Eazy", null, "Seeder" },
                    { 84, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(5193), new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(5195), new TimeSpan(1755408333), "/music/Rich The Kid - Plug Walk (Audio).mp3", 1, 0, "NotLiked", "Rich The Kid - Plug Walk (Audio)", null, "Seeder" },
                    { 85, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(6517), new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(6519), new TimeSpan(1948425000), "/music/Right Now.mp3", 1, 0, "NotLiked", "Right Now", null, "Seeder" },
                    { 86, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(8034), new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(8037), new TimeSpan(2102838333), "/music/RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends.mp3", 1, 0, "NotLiked", "RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends", null, "Seeder" },
                    { 87, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(9954), new DateTime(2025, 2, 1, 16, 39, 24, 406, DateTimeKind.Local).AddTicks(9957), new TimeSpan(3396832500), "/music/Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST.mp3", 1, 0, "NotLiked", "Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST", null, "Seeder" },
                    { 88, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 407, DateTimeKind.Local).AddTicks(2110), new DateTime(2025, 2, 1, 16, 39, 24, 407, DateTimeKind.Local).AddTicks(2113), new TimeSpan(1666725000), "/music/SAD!.mp3", 1, 0, "NotLiked", "SAD!", null, "Seeder" },
                    { 89, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 407, DateTimeKind.Local).AddTicks(4303), new DateTime(2025, 2, 1, 16, 39, 24, 407, DateTimeKind.Local).AddTicks(4306), new TimeSpan(1602038333), "/music/Saijaku Muhai no Bahamut  - Saijaku Muhai OST.mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut  - Saijaku Muhai OST", null, "Seeder" },
                    { 90, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 407, DateTimeKind.Local).AddTicks(5975), new DateTime(2025, 2, 1, 16, 39, 24, 407, DateTimeKind.Local).AddTicks(5978), new TimeSpan(0, 0, 4, 13, 217), "/music/Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only).mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only)", null, "Seeder" },
                    { 91, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 407, DateTimeKind.Local).AddTicks(7525), new DateTime(2025, 2, 1, 16, 39, 24, 407, DateTimeKind.Local).AddTicks(7527), new TimeSpan(0, 0, 36, 46, 337), "/music/Sakura - 落ち着いて冷やす.mp3", 1, 0, "NotLiked", "Sakura - 落ち着いて冷やす", null, "Seeder" },
                    { 92, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 408, DateTimeKind.Local).AddTicks(171), new DateTime(2025, 2, 1, 16, 39, 24, 408, DateTimeKind.Local).AddTicks(174), new TimeSpan(2224647500), "/music/SAMAHTA - graffiti (feat. Melody Federer).mp3", 1, 0, "NotLiked", "SAMAHTA - graffiti (feat. Melody Federer)", null, "Seeder" },
                    { 93, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 408, DateTimeKind.Local).AddTicks(2143), new DateTime(2025, 2, 1, 16, 39, 24, 408, DateTimeKind.Local).AddTicks(2146), new TimeSpan(0, 0, 3, 59, 445), "/music/Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte", null, "Seeder" },
                    { 94, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 408, DateTimeKind.Local).AddTicks(3926), new DateTime(2025, 2, 1, 16, 39, 24, 408, DateTimeKind.Local).AddTicks(3929), new TimeSpan(2497479166), "/music/Shawn Mendes - Mercy.mp3", 1, 0, "NotLiked", "Shawn Mendes - Mercy", null, "Seeder" },
                    { 95, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 408, DateTimeKind.Local).AddTicks(5763), new DateTime(2025, 2, 1, 16, 39, 24, 408, DateTimeKind.Local).AddTicks(5766), new TimeSpan(2398884166), "/music/Shawn Mendes - Stitches.mp3", 1, 0, "NotLiked", "Shawn Mendes - Stitches", null, "Seeder" },
                    { 96, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 408, DateTimeKind.Local).AddTicks(7302), new DateTime(2025, 2, 1, 16, 39, 24, 408, DateTimeKind.Local).AddTicks(7305), new TimeSpan(2375148333), "/music/Shawn Mendes - Theres Nothing Holdin Me Back.mp3", 1, 0, "NotLiked", "Shawn Mendes - Theres Nothing Holdin Me Back", null, "Seeder" },
                    { 97, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 408, DateTimeKind.Local).AddTicks(8805), new DateTime(2025, 2, 1, 16, 39, 24, 408, DateTimeKind.Local).AddTicks(8808), new TimeSpan(2564513333), "/music/Shawn Mendes - Treat You Better.mp3", 1, 0, "NotLiked", "Shawn Mendes - Treat You Better", null, "Seeder" },
                    { 98, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 409, DateTimeKind.Local).AddTicks(507), new DateTime(2025, 2, 1, 16, 39, 24, 409, DateTimeKind.Local).AddTicks(510), new TimeSpan(1860263333), "/music/Sheck Wes - Mo Bamba.mp3", 1, 0, "NotLiked", "Sheck Wes - Mo Bamba", null, "Seeder" },
                    { 99, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 409, DateTimeKind.Local).AddTicks(2739), new DateTime(2025, 2, 1, 16, 39, 24, 409, DateTimeKind.Local).AddTicks(2742), new TimeSpan(2367323333), "/music/Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte", null, "Seeder" },
                    { 100, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 409, DateTimeKind.Local).AddTicks(4561), new DateTime(2025, 2, 1, 16, 39, 24, 409, DateTimeKind.Local).AddTicks(4564), new TimeSpan(2032152500), "/music/Sickick - Infected.mp3", 1, 0, "NotLiked", "Sickick - Infected", null, "Seeder" },
                    { 101, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 409, DateTimeKind.Local).AddTicks(6068), new DateTime(2025, 2, 1, 16, 39, 24, 409, DateTimeKind.Local).AddTicks(6071), new TimeSpan(2551732500), "/music/Sickick - Mind Games.mp3", 1, 0, "NotLiked", "Sickick - Mind Games", null, "Seeder" },
                    { 102, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 409, DateTimeKind.Local).AddTicks(7771), new DateTime(2025, 2, 1, 16, 39, 24, 409, DateTimeKind.Local).AddTicks(7774), new TimeSpan(2362106666), "/music/SickickMusic - Lost My Way.mp3", 1, 0, "NotLiked", "SickickMusic - Lost My Way", null, "Seeder" },
                    { 103, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 409, DateTimeKind.Local).AddTicks(9704), new DateTime(2025, 2, 1, 16, 39, 24, 409, DateTimeKind.Local).AddTicks(9708), new TimeSpan(2763268333), "/music/Skan & Krale - No Glory (feat. M.I.M.E & Drama B).mp3", 1, 0, "NotLiked", "Skan & Krale - No Glory (feat. M.I.M.E & Drama B)", null, "Seeder" },
                    { 104, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 410, DateTimeKind.Local).AddTicks(1316), new DateTime(2025, 2, 1, 16, 39, 24, 410, DateTimeKind.Local).AddTicks(1319), new TimeSpan(861010833), "/music/SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW.mp3", 1, 0, "NotLiked", "SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW", null, "Seeder" },
                    { 105, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 410, DateTimeKind.Local).AddTicks(2786), new DateTime(2025, 2, 1, 16, 39, 24, 410, DateTimeKind.Local).AddTicks(2789), new TimeSpan(2190739166), "/music/SKRILLEX - Bangarang feat. Sirah.mp3", 1, 0, "NotLiked", "SKRILLEX - Bangarang feat. Sirah", null, "Seeder" },
                    { 106, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 410, DateTimeKind.Local).AddTicks(4097), new DateTime(2025, 2, 1, 16, 39, 24, 410, DateTimeKind.Local).AddTicks(4100), new TimeSpan(1666725000), "/music/Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix).mp3", 1, 0, "NotLiked", "Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix)", null, "Seeder" },
                    { 107, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 410, DateTimeKind.Local).AddTicks(5571), new DateTime(2025, 2, 1, 16, 39, 24, 410, DateTimeKind.Local).AddTicks(5573), new TimeSpan(3572112500), "/music/Soredemo sekai wa utsukushii - Beautiful rain full ver..mp3", 1, 0, "NotLiked", "Soredemo sekai wa utsukushii - Beautiful rain full ver.", null, "Seeder" },
                    { 108, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 410, DateTimeKind.Local).AddTicks(7290), new DateTime(2025, 2, 1, 16, 39, 24, 410, DateTimeKind.Local).AddTicks(7293), new TimeSpan(2411404166), "/music/Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna].mp3", 1, 0, "NotLiked", "Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna]", null, "Seeder" },
                    { 109, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 410, DateTimeKind.Local).AddTicks(8746), new DateTime(2025, 2, 1, 16, 39, 24, 410, DateTimeKind.Local).AddTicks(8749), new TimeSpan(2046237500), "/music/STéLOUSE - Sociopath (feat. Bryce Fox).mp3", 1, 0, "NotLiked", "STéLOUSE - Sociopath (feat. Bryce Fox)", null, "Seeder" },
                    { 110, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 411, DateTimeKind.Local).AddTicks(1514), new DateTime(2025, 2, 1, 16, 39, 24, 411, DateTimeKind.Local).AddTicks(1517), new TimeSpan(2646415000), "/music/Sufian Suhaimi - Di Matamu.mp3", 1, 0, "NotLiked", "Sufian Suhaimi - Di Matamu", null, "Seeder" },
                    { 111, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 411, DateTimeKind.Local).AddTicks(2469), new DateTime(2025, 2, 1, 16, 39, 24, 411, DateTimeKind.Local).AddTicks(2470), new TimeSpan(2951329166), "/music/Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting", null, "Seeder" },
                    { 112, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 411, DateTimeKind.Local).AddTicks(4728), new DateTime(2025, 2, 1, 16, 39, 24, 411, DateTimeKind.Local).AddTicks(4730), new TimeSpan(2231429166), "/music/Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub", null, "Seeder" },
                    { 113, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 411, DateTimeKind.Local).AddTicks(6208), new DateTime(2025, 2, 1, 16, 39, 24, 411, DateTimeKind.Local).AddTicks(6210), new TimeSpan(3378313333), "/music/Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION.mp3", 1, 0, "NotLiked", "Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION", null, "Seeder" },
                    { 114, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 411, DateTimeKind.Local).AddTicks(7551), new DateTime(2025, 2, 1, 16, 39, 24, 411, DateTimeKind.Local).AddTicks(7553), new TimeSpan(2818565000), "/music/TETRA-FANG - Supernova.mp3", 1, 0, "NotLiked", "TETRA-FANG - Supernova", null, "Seeder" },
                    { 115, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 411, DateTimeKind.Local).AddTicks(9485), new DateTime(2025, 2, 1, 16, 39, 24, 411, DateTimeKind.Local).AddTicks(9489), new TimeSpan(2359498333), "/music/The Mirza - Lelah Mengalah.mp3", 1, 0, "NotLiked", "The Mirza - Lelah Mengalah", null, "Seeder" },
                    { 116, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 412, DateTimeKind.Local).AddTicks(1665), new DateTime(2025, 2, 1, 16, 39, 24, 412, DateTimeKind.Local).AddTicks(1668), new TimeSpan(37452797500), "/music/The Soul of Wind -  🗻 The Mountains 🗻.mp3", 1, 0, "NotLiked", "The Soul of Wind -  🗻 The Mountains 🗻", null, "Seeder" },
                    { 117, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 412, DateTimeKind.Local).AddTicks(3726), new DateTime(2025, 2, 1, 16, 39, 24, 412, DateTimeKind.Local).AddTicks(3729), new TimeSpan(1943990833), "/music/TheFatRat - Fly Away feat. Anjulie.mp3", 1, 0, "NotLiked", "TheFatRat - Fly Away feat. Anjulie", null, "Seeder" },
                    { 118, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 412, DateTimeKind.Local).AddTicks(5292), new DateTime(2025, 2, 1, 16, 39, 24, 412, DateTimeKind.Local).AddTicks(5294), new TimeSpan(2910639166), "/music/TheFatRat - Monody (feat. Laura Brehm).mp3", 1, 0, "NotLiked", "TheFatRat - Monody (feat. Laura Brehm)", null, "Seeder" },
                    { 119, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 412, DateTimeKind.Local).AddTicks(7062), new DateTime(2025, 2, 1, 16, 39, 24, 412, DateTimeKind.Local).AddTicks(7065), new TimeSpan(0, 0, 3, 1, 227), "/music/TheFatRat - Time Lapse.mp3", 1, 0, "NotLiked", "TheFatRat - Time Lapse", null, "Seeder" },
                    { 120, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 412, DateTimeKind.Local).AddTicks(8394), new DateTime(2025, 2, 1, 16, 39, 24, 412, DateTimeKind.Local).AddTicks(8396), new TimeSpan(2491740833), "/music/TheFatRat - Unity.mp3", 1, 0, "NotLiked", "TheFatRat - Unity", null, "Seeder" },
                    { 121, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 412, DateTimeKind.Local).AddTicks(9722), new DateTime(2025, 2, 1, 16, 39, 24, 412, DateTimeKind.Local).AddTicks(9723), new TimeSpan(2474786666), "/music/TIIMO - Bangin In the Club.mp3", 1, 0, "NotLiked", "TIIMO - Bangin In the Club", null, "Seeder" },
                    { 122, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 413, DateTimeKind.Local).AddTicks(1508), new DateTime(2025, 2, 1, 16, 39, 24, 413, DateTimeKind.Local).AddTicks(1510), new TimeSpan(2949764166), "/music/Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-].mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-]", null, "Seeder" },
                    { 123, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 413, DateTimeKind.Local).AddTicks(2945), new DateTime(2025, 2, 1, 16, 39, 24, 413, DateTimeKind.Local).AddTicks(2947), new TimeSpan(1978420833), "/music/Tokyo Ghoul - Unravel (Marco B. Remix).mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (Marco B. Remix)", null, "Seeder" },
                    { 124, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 413, DateTimeKind.Local).AddTicks(4260), new DateTime(2025, 2, 1, 16, 39, 24, 413, DateTimeKind.Local).AddTicks(4262), new TimeSpan(2481307500), "/music/Tokyo Ghoul - Unravel (OP Piano) .mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (OP Piano) ", null, "Seeder" },
                    { 125, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 413, DateTimeKind.Local).AddTicks(5652), new DateTime(2025, 2, 1, 16, 39, 24, 413, DateTimeKind.Local).AddTicks(5654), new TimeSpan(2621635833), "/music/Tokyo Ghoul - Unravel 2.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel 2", null, "Seeder" },
                    { 126, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 413, DateTimeKind.Local).AddTicks(6979), new DateTime(2025, 2, 1, 16, 39, 24, 413, DateTimeKind.Local).AddTicks(6981), new TimeSpan(0, 0, 4, 1, 323), "/music/Tokyo Ghoul - Unravel.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel", null, "Seeder" },
                    { 127, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 413, DateTimeKind.Local).AddTicks(8575), new DateTime(2025, 2, 1, 16, 39, 24, 413, DateTimeKind.Local).AddTicks(8578), new TimeSpan(1975551666), "/music/Tokyo Machine - FLY [Monstercat Release].mp3", 1, 0, "NotLiked", "Tokyo Machine - FLY [Monstercat Release]", null, "Seeder" },
                    { 128, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(602), new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(605), new TimeSpan(2304201666), "/music/Trapcity - Dead To Me (feat. Lox Chatterbox).mp3", 1, 0, "NotLiked", "Trapcity - Dead To Me (feat. Lox Chatterbox)", null, "Seeder" },
                    { 129, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(2222), new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(2224), new TimeSpan(37651552500), "/music/Trapcity - Samurai☯ Lofi.mp3", 1, 0, "NotLiked", "Trapcity - Samurai☯ Lofi", null, "Seeder" },
                    { 130, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(3783), new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(3786), new TimeSpan(2689713333), "/music/Trapcity - Trap Queen (Crankdat Remix).mp3", 1, 0, "NotLiked", "Trapcity - Trap Queen (Crankdat Remix)", null, "Seeder" },
                    { 131, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(5364), new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(5366), new TimeSpan(3144867499), "/music/Travis Scott - SICKO MODE.mp3", 1, 0, "NotLiked", "Travis Scott - SICKO MODE", null, "Seeder" },
                    { 132, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(6806), new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(6808), new TimeSpan(1863132500), "/music/Two Feet - I Feel Like Im Drowning.mp3", 1, 0, "NotLiked", "Two Feet - I Feel Like Im Drowning", null, "Seeder" },
                    { 133, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(8208), new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(8210), new TimeSpan(2292203333), "/music/Unlike Pluto ft. Mike Taylor - Everything Black.mp3", 1, 0, "NotLiked", "Unlike Pluto ft. Mike Taylor - Everything Black", null, "Seeder" },
                    { 134, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(9682), new DateTime(2025, 2, 1, 16, 39, 24, 414, DateTimeKind.Local).AddTicks(9684), new TimeSpan(3559853333), "/music/Wishing Lyrics Rem(minase inori) ReZero.mp3", 1, 0, "NotLiked", "Wishing Lyrics Rem(minase inori) ReZero", null, "Seeder" },
                    { 135, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 415, DateTimeKind.Local).AddTicks(1331), new DateTime(2025, 2, 1, 16, 39, 24, 415, DateTimeKind.Local).AddTicks(1334), new TimeSpan(949433333), "/music/XXXTENTACION - BAD!.mp3", 1, 0, "NotLiked", "XXXTENTACION - BAD!", null, "Seeder" },
                    { 136, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 415, DateTimeKind.Local).AddTicks(2660), new DateTime(2025, 2, 1, 16, 39, 24, 415, DateTimeKind.Local).AddTicks(2662), new TimeSpan(1945555833), "/music/Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics].mp3", 1, 0, "NotLiked", "Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics]", null, "Seeder" },
                    { 137, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 415, DateTimeKind.Local).AddTicks(3915), new DateTime(2025, 2, 1, 16, 39, 24, 415, DateTimeKind.Local).AddTicks(3917), new TimeSpan(2141441666), "/music/Yasuha - Flyday Chinatown.mp3", 1, 0, "NotLiked", "Yasuha - Flyday Chinatown", null, "Seeder" },
                    { 138, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 415, DateTimeKind.Local).AddTicks(5183), new DateTime(2025, 2, 1, 16, 39, 24, 415, DateTimeKind.Local).AddTicks(5185), new TimeSpan(2595291666), "/music/YOASOBI 夜に駆ける English & Romanji Lyrics.mp3", 1, 0, "NotLiked", "YOASOBI 夜に駆ける English & Romanji Lyrics", null, "Seeder" },
                    { 139, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 415, DateTimeKind.Local).AddTicks(6417), new DateTime(2025, 2, 1, 16, 39, 24, 415, DateTimeKind.Local).AddTicks(6419), new TimeSpan(2042846666), "/music/YOASOBIハルジオンOfficial Music Video.mp3", 1, 0, "NotLiked", "YOASOBIハルジオンOfficial Music Video", null, "Seeder" },
                    { 140, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 415, DateTimeKind.Local).AddTicks(8484), new DateTime(2025, 2, 1, 16, 39, 24, 415, DateTimeKind.Local).AddTicks(8487), new TimeSpan(2276553333), "/music/Yuna - Longing.mp3", 1, 0, "NotLiked", "Yuna - Longing", null, "Seeder" },
                    { 141, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 416, DateTimeKind.Local).AddTicks(1029), new DateTime(2025, 2, 1, 16, 39, 24, 416, DateTimeKind.Local).AddTicks(1032), new TimeSpan(1973986666), "/music/Yuna - Smile for you .mp3", 1, 0, "NotLiked", "Yuna - Smile for you ", null, "Seeder" },
                    { 142, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 416, DateTimeKind.Local).AddTicks(2712), new DateTime(2025, 2, 1, 16, 39, 24, 416, DateTimeKind.Local).AddTicks(2715), new TimeSpan(3511077500), "/music/タイニーリトルアシアンタム.mp3", 1, 0, "NotLiked", "タイニーリトルアシアンタム", null, "Seeder" },
                    { 143, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 39, 24, 416, DateTimeKind.Local).AddTicks(4198), new DateTime(2025, 2, 1, 16, 39, 24, 416, DateTimeKind.Local).AddTicks(4201), new TimeSpan(0, 0, 3, 6, 548), "/music/レペゼン地球66thシングルO2MEN.mp3", 1, 0, "NotLiked", "レペゼン地球66thシングルO2MEN", null, "Seeder" }
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
                name: "IX_Song_PlaylistID",
                table: "Song",
                column: "PlaylistID");

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
