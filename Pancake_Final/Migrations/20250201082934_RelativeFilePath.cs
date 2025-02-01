using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pancake_Final.Migrations
{
    /// <inheritdoc />
    public partial class RelativeFilePath : Migration
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "3099c63f-640f-4ea8-8ede-987f325ac7eb", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECSTBrwv8YcvcqP7y1ySh3J1L6jyn9RIbN+FLkq7mYzD10bA8sDTJPZnna0bUBU28w==", null, false, "5f966089-6d97-47ca-b865-8d1a97749a3f", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumID", "ArtistId", "ArtistsArtistID", "CreatedBy", "DateCreated", "DateUpdated", "Duration", "FilePath", "GenID", "Id", "LikedS", "Name", "PlaylistID", "UpdateBy" },
                values: new object[,]
                {
                    { 1, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(5975), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(5987), new TimeSpan(0, 0, 0, 0, 0), "/music/Don Toliver - No Pole.mp3", 1, 0, "NotLiked", "Don Toliver - No Pole", null, "Seeder" },
                    { 2, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6002), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6002), new TimeSpan(0, 0, 0, 0, 0), "/music/Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人.mp3", 1, 0, "NotLiked", "Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人", null, "Seeder" },
                    { 3, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6011), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6012), new TimeSpan(0, 0, 0, 0, 0), "/music/Goblin Slayer - Rightfully _ Mili [Full].mp3", 1, 0, "NotLiked", "Goblin Slayer - Rightfully _ Mili [Full]", null, "Seeder" },
                    { 4, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6048), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6048), new TimeSpan(0, 0, 0, 0, 0), "/music/Goblins from Mars  - Put Your Love In Dreamz.mp3", 1, 0, "NotLiked", "Goblins from Mars  - Put Your Love In Dreamz", null, "Seeder" },
                    { 5, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6057), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6058), new TimeSpan(0, 0, 0, 0, 0), "/music/Goblins from Mars - Cold Blooded Love (ft. Krista Marina).mp3", 1, 0, "NotLiked", "Goblins from Mars - Cold Blooded Love (ft. Krista Marina)", null, "Seeder" },
                    { 6, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6066), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6067), new TimeSpan(0, 0, 0, 0, 0), "/music/Goblins from Mars - Heart Afire When The Bassjumps.mp3", 1, 0, "NotLiked", "Goblins from Mars - Heart Afire When The Bassjumps", null, "Seeder" },
                    { 7, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6077), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6078), new TimeSpan(0, 0, 0, 0, 0), "/music/Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC].mp3", 1, 0, "NotLiked", "Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC]", null, "Seeder" },
                    { 8, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6085), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6085), new TimeSpan(0, 0, 0, 0, 0), "/music/Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC].mp3", 1, 0, "NotLiked", "Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC]", null, "Seeder" },
                    { 9, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6092), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6092), new TimeSpan(0, 0, 0, 0, 0), "/music/grandson - Despicable.mp3", 1, 0, "NotLiked", "grandson - Despicable", null, "Seeder" },
                    { 10, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6101), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6101), new TimeSpan(0, 0, 0, 0, 0), "/music/Greatest Battle Music Of All Times Saijaku Muhai.mp3", 1, 0, "NotLiked", "Greatest Battle Music Of All Times Saijaku Muhai", null, "Seeder" },
                    { 11, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6108), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6108), new TimeSpan(0, 0, 0, 0, 0), "/music/Gundam - OP1 HD.mp3", 1, 0, "NotLiked", "Gundam - OP1 HD", null, "Seeder" },
                    { 12, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6115), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6115), new TimeSpan(0, 0, 0, 0, 0), "/music/Gundam - Seed.mp3", 1, 0, "NotLiked", "Gundam - Seed", null, "Seeder" },
                    { 13, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6122), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6122), new TimeSpan(0, 0, 0, 0, 0), "/music/Hans Zimmer - Flight.mp3", 1, 0, "NotLiked", "Hans Zimmer - Flight", null, "Seeder" },
                    { 14, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6130), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6130), new TimeSpan(0, 0, 0, 0, 0), "/music/Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music", null, "Seeder" },
                    { 15, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6138), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6138), new TimeSpan(0, 0, 0, 0, 0), "/music/Hiroyuki Sawano Impure King Suite Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano Impure King Suite Epic Battle Music", null, "Seeder" },
                    { 16, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6146), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6146), new TimeSpan(0, 0, 0, 0, 0), "/music/HOPE.mp3", 1, 0, "NotLiked", "HOPE", null, "Seeder" },
                    { 17, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6153), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6154), new TimeSpan(0, 0, 0, 0, 0), "/music/HOTD - Pentakill .mp3", 1, 0, "NotLiked", "HOTD - Pentakill ", null, "Seeder" },
                    { 18, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6206), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6206), new TimeSpan(0, 0, 0, 0, 0), "/music/i feel like i did too much Don Toliver - No Idea (Lyrics).mp3", 1, 0, "NotLiked", "i feel like i did too much Don Toliver - No Idea (Lyrics)", null, "Seeder" },
                    { 19, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6213), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6213), new TimeSpan(0, 0, 0, 0, 0), "/music/I NEED U (Official MV).mp3", 1, 0, "NotLiked", "I NEED U (Official MV)", null, "Seeder" },
                    { 20, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6220), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6220), new TimeSpan(0, 0, 0, 0, 0), "/music/IDOL Official MV.mp3", 1, 0, "NotLiked", "IDOL Official MV", null, "Seeder" },
                    { 21, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6229), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6229), new TimeSpan(0, 0, 0, 0, 0), "/music/Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix].mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix]", null, "Seeder" },
                    { 22, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6237), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6237), new TimeSpan(0, 0, 0, 0, 0), "/music/Imagine Dragons - Believer.mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer", null, "Seeder" },
                    { 23, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6245), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6245), new TimeSpan(0, 0, 0, 0, 0), "/music/ISLAND OST - Island Opening Full「Eien no Hitotsu」.mp3", 1, 0, "NotLiked", "ISLAND OST - Island Opening Full「Eien no Hitotsu」", null, "Seeder" },
                    { 24, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6252), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6252), new TimeSpan(0, 0, 0, 0, 0), "/music/ISLAND OST - Lasting Memories FULL.mp3", 1, 0, "NotLiked", "ISLAND OST - Lasting Memories FULL", null, "Seeder" },
                    { 25, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6258), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6258), new TimeSpan(0, 0, 0, 0, 0), "/music/J.Fla  - Havana.mp3", 1, 0, "NotLiked", "J.Fla  - Havana", null, "Seeder" },
                    { 26, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6265), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6265), new TimeSpan(0, 0, 0, 0, 0), "/music/Jacob Lee - Demons.mp3", 1, 0, "NotLiked", "Jacob Lee - Demons", null, "Seeder" },
                    { 27, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6272), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6272), new TimeSpan(0, 0, 0, 0, 0), "/music/Jaden - GOKU.mp3", 1, 0, "NotLiked", "Jaden - GOKU", null, "Seeder" },
                    { 28, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6279), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0), "/music/Justin Stone - Lungs (Prod. Alex Collins).mp3", 1, 0, "NotLiked", "Justin Stone - Lungs (Prod. Alex Collins)", null, "Seeder" },
                    { 29, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6286), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6287), new TimeSpan(0, 0, 0, 0, 0), "/music/Kaguya-Sama - Love is war (feat. Masayuki Suzuki) .mp3", 1, 0, "NotLiked", "Kaguya-Sama - Love is war (feat. Masayuki Suzuki) ", null, "Seeder" },
                    { 30, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6296), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6296), new TimeSpan(0, 0, 0, 0, 0), "/music/Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki.mp3", 1, 0, "NotLiked", "Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki", null, "Seeder" },
                    { 31, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6345), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6345), new TimeSpan(0, 0, 0, 0, 0), "/music/Kakusei [Awakening].mp3", 1, 0, "NotLiked", "Kakusei [Awakening]", null, "Seeder" },
                    { 32, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6352), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6353), new TimeSpan(0, 0, 0, 0, 0), "/music/Kamikaze Feat. Lox Chatterbox.mp3", 1, 0, "NotLiked", "Kamikaze Feat. Lox Chatterbox", null, "Seeder" },
                    { 33, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6359), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6360), new TimeSpan(0, 0, 0, 0, 0), "/music/KANA-BOON - Silhouette.mp3", 1, 0, "NotLiked", "KANA-BOON - Silhouette", null, "Seeder" },
                    { 34, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6370), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6370), new TimeSpan(0, 0, 0, 0, 0), "/music/KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends.mp3", 1, 0, "NotLiked", "KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends", null, "Seeder" },
                    { 35, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6379), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6379), new TimeSpan(0, 0, 0, 0, 0), "/music/Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP.mp3", 1, 0, "NotLiked", "Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP", null, "Seeder" },
                    { 36, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6386), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6386), new TimeSpan(0, 0, 0, 0, 0), "/music/khai dreams - sunkissed.mp3", 1, 0, "NotLiked", "khai dreams - sunkissed", null, "Seeder" },
                    { 37, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6393), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6393), new TimeSpan(0, 0, 0, 0, 0), "/music/Kibou No Uta Lyrics.mp3", 1, 0, "NotLiked", "Kibou No Uta Lyrics", null, "Seeder" },
                    { 38, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6400), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6400), new TimeSpan(0, 0, 0, 0, 0), "/music/Krewella - Calm Down (SKAN Remix).mp3", 1, 0, "NotLiked", "Krewella - Calm Down (SKAN Remix)", null, "Seeder" },
                    { 39, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6407), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6407), new TimeSpan(0, 0, 0, 0, 0), "/music/KSI & Randolph - Champagne (Official Audio).mp3", 1, 0, "NotLiked", "KSI & Randolph - Champagne (Official Audio)", null, "Seeder" },
                    { 40, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6414), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6414), new TimeSpan(0, 0, 0, 0, 0), "/music/KUURO - Afraid of the Dark (feat. Sophiya) .mp3", 1, 0, "NotLiked", "KUURO - Afraid of the Dark (feat. Sophiya) ", null, "Seeder" },
                    { 41, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6420), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6420), new TimeSpan(0, 0, 0, 0, 0), "/music/KUURO - What U Wanna Do.mp3", 1, 0, "NotLiked", "KUURO - What U Wanna Do", null, "Seeder" },
                    { 42, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6426), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6427), new TimeSpan(0, 0, 0, 0, 0), "/music/LAYTO - Little Poor Me.mp3", 1, 0, "NotLiked", "LAYTO - Little Poor Me", null, "Seeder" },
                    { 43, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6436), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6436), new TimeSpan(0, 0, 0, 0, 0), "/music/Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends.mp3", 1, 0, "NotLiked", "Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends", null, "Seeder" },
                    { 44, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6460), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6460), new TimeSpan(0, 0, 0, 0, 0), "/music/Leonhart - Grancrest Senki OST - Hope.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST - Hope", null, "Seeder" },
                    { 45, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6468), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6468), new TimeSpan(0, 0, 0, 0, 0), "/music/Leonhart - Grancrest Senki OST.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST", null, "Seeder" },
                    { 46, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6475), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6475), new TimeSpan(0, 0, 0, 0, 0), "/music/Liam Ferrari - I Like The Way.mp3", 1, 0, "NotLiked", "Liam Ferrari - I Like The Way", null, "Seeder" },
                    { 47, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6482), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6483), new TimeSpan(0, 0, 0, 0, 0), "/music/Lil Nas X Billy Ray Cyrus - Old Town Road (Remix).mp3", 1, 0, "NotLiked", "Lil Nas X Billy Ray Cyrus - Old Town Road (Remix)", null, "Seeder" },
                    { 48, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6489), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6489), new TimeSpan(0, 0, 0, 0, 0), "/music/LIL SKIES - Boss Up.mp3", 1, 0, "NotLiked", "LIL SKIES - Boss Up", null, "Seeder" },
                    { 49, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6495), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6495), new TimeSpan(0, 0, 0, 0, 0), "/music/LIL SKIES - Lust.mp3", 1, 0, "NotLiked", "LIL SKIES - Lust", null, "Seeder" },
                    { 50, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6502), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6502), new TimeSpan(0, 0, 0, 0, 0), "/music/Lil Uzi Vert - XO Tour Llif3 .mp3", 1, 0, "NotLiked", "Lil Uzi Vert - XO Tour Llif3 ", null, "Seeder" },
                    { 51, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6510), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6510), new TimeSpan(0, 0, 0, 0, 0), "/music/Lilianna Wilde - Grind Me Down (Jawster Remix).mp3", 1, 0, "NotLiked", "Lilianna Wilde - Grind Me Down (Jawster Remix)", null, "Seeder" },
                    { 52, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6516), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6516), new TimeSpan(0, 0, 0, 0, 0), "/music/LiSA - Catch the Moment.mp3", 1, 0, "NotLiked", "LiSA - Catch the Moment", null, "Seeder" },
                    { 53, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6523), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6523), new TimeSpan(0, 0, 0, 0, 0), "/music/LiSA - Crossing Field.mp3", 1, 0, "NotLiked", "LiSA - Crossing Field", null, "Seeder" },
                    { 54, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6529), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6529), new TimeSpan(0, 0, 0, 0, 0), "/music/Look Alive [BASS BOOSTED].mp3", 1, 0, "NotLiked", "Look Alive [BASS BOOSTED]", null, "Seeder" },
                    { 55, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6555), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6555), new TimeSpan(0, 0, 0, 0, 0), "/music/Lyrics Owari no Seraph OST - 108.mp3", 1, 0, "NotLiked", "Lyrics Owari no Seraph OST - 108", null, "Seeder" },
                    { 56, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6563), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6563), new TimeSpan(0, 0, 0, 0, 0), "/music/MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ.mp3", 1, 0, "NotLiked", "MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ", null, "Seeder" },
                    { 57, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6569), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6569), new TimeSpan(0, 0, 0, 0, 0), "/music/Magnolia.mp3", 1, 0, "NotLiked", "Magnolia", null, "Seeder" },
                    { 58, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6575), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6575), new TimeSpan(0, 0, 0, 0, 0), "/music/Maroon 5 - Sugar.mp3", 1, 0, "NotLiked", "Maroon 5 - Sugar", null, "Seeder" },
                    { 59, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6637), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6637), new TimeSpan(0, 0, 0, 0, 0), "/music/Maroon 5 Ft. Wiz Khalifa.mp3", 1, 0, "NotLiked", "Maroon 5 Ft. Wiz Khalifa", null, "Seeder" },
                    { 60, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6645), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6645), new TimeSpan(0, 0, 0, 0, 0), "/music/MHW ICEBORNE Safi Jiiva Battle Theme OST.mp3", 1, 0, "NotLiked", "MHW ICEBORNE Safi Jiiva Battle Theme OST", null, "Seeder" },
                    { 61, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6652), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6652), new TimeSpan(0, 0, 0, 0, 0), "/music/MIC Drop (Steve Aoki Remix) Official MV.mp3", 1, 0, "NotLiked", "MIC Drop (Steve Aoki Remix) Official MV", null, "Seeder" },
                    { 62, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6659), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6660), new TimeSpan(0, 0, 0, 0, 0), "/music/Migos - Get Right Witcha (G-REX X TOP $HELF Remix).mp3", 1, 0, "NotLiked", "Migos - Get Right Witcha (G-REX X TOP $HELF Remix)", null, "Seeder" },
                    { 63, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6666), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6667), new TimeSpan(0, 0, 0, 0, 0), "/music/MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura.mp3", 1, 0, "NotLiked", "MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura", null, "Seeder" },
                    { 64, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6673), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6673), new TimeSpan(0, 0, 0, 0, 0), "/music/Moonlight.mp3", 1, 0, "NotLiked", "Moonlight", null, "Seeder" },
                    { 65, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6681), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6681), new TimeSpan(0, 0, 0, 0, 0), "/music/Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records.mp3", 1, 0, "NotLiked", "Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records", null, "Seeder" },
                    { 66, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6689), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6690), new TimeSpan(0, 0, 0, 0, 0), "/music/Mrs. GREEN APPLE - インフェルノInferno.mp3", 1, 0, "NotLiked", "Mrs. GREEN APPLE - インフェルノInferno", null, "Seeder" },
                    { 67, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6697), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6697), new TimeSpan(0, 0, 0, 0, 0), "/music/My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2).mp3", 1, 0, "NotLiked", "My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2)", null, "Seeder" },
                    { 68, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6704), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6704), new TimeSpan(0, 0, 0, 0, 0), "/music/My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version).mp3", 1, 0, "NotLiked", "My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version)", null, "Seeder" },
                    { 69, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6711), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6711), new TimeSpan(0, 0, 0, 0, 0), "/music/Namirin  - Renai Circulation「恋愛サーキュレーショ.mp3", 1, 0, "NotLiked", "Namirin  - Renai Circulation「恋愛サーキュレーショ", null, "Seeder" },
                    { 70, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6752), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6752), new TimeSpan(0, 0, 0, 0, 0), "/music/Nanatsu no Taizai S2 - Escanor Theme (Rearrangement).mp3", 1, 0, "NotLiked", "Nanatsu no Taizai S2 - Escanor Theme (Rearrangement)", null, "Seeder" },
                    { 71, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6759), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6760), new TimeSpan(0, 0, 0, 0, 0), "/music/NEFFEX - Fight Back.mp3", 1, 0, "NotLiked", "NEFFEX - Fight Back", null, "Seeder" },
                    { 72, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6766), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6766), new TimeSpan(0, 0, 0, 0, 0), "/music/NEFFEX - Myself.mp3", 1, 0, "NotLiked", "NEFFEX - Myself", null, "Seeder" },
                    { 73, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6775), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6776), new TimeSpan(0, 0, 0, 0, 0), "/music/Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro).mp3", 1, 0, "NotLiked", "Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro)", null, "Seeder" },
                    { 74, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6782), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6782), new TimeSpan(0, 0, 0, 0, 0), "/music/Nightcore - Control.mp3", 1, 0, "NotLiked", "Nightcore - Control", null, "Seeder" },
                    { 75, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6789), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6790), new TimeSpan(0, 0, 0, 0, 0), "/music/Nightcore - Rockefeller Street.mp3", 1, 0, "NotLiked", "Nightcore - Rockefeller Street", null, "Seeder" },
                    { 76, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6796), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6796), new TimeSpan(0, 0, 0, 0, 0), "/music/No Game No Life Opening Full.mp3", 1, 0, "NotLiked", "No Game No Life Opening Full", null, "Seeder" },
                    { 77, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6803), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6803), new TimeSpan(0, 0, 0, 0, 0), "/music/Not Today Official MV.mp3", 1, 0, "NotLiked", "Not Today Official MV", null, "Seeder" },
                    { 78, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6810), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6810), new TimeSpan(0, 0, 0, 0, 0), "/music/Nto - Trauma (Worakls Remix).mp3", 1, 0, "NotLiked", "Nto - Trauma (Worakls Remix)", null, "Seeder" },
                    { 79, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6817), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6818), new TimeSpan(0, 0, 0, 0, 0), "/music/Owari no Seraph OST - 1hundredknight M [終わりのセラフ].mp3", 1, 0, "NotLiked", "Owari no Seraph OST - 1hundredknight M [終わりのセラフ]", null, "Seeder" },
                    { 80, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6825), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6826), new TimeSpan(0, 0, 0, 0, 0), "/music/Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack.mp3", 1, 0, "NotLiked", "Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack", null, "Seeder" },
                    { 81, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6832), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6832), new TimeSpan(0, 0, 0, 0, 0), "/music/Post Malone - Better Now.mp3", 1, 0, "NotLiked", "Post Malone - Better Now", null, "Seeder" },
                    { 82, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6839), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6839), new TimeSpan(0, 0, 0, 0, 0), "/music/Post Malone_ 21 Savage - Rockstar.mp3", 1, 0, "NotLiked", "Post Malone_ 21 Savage - Rockstar", null, "Seeder" },
                    { 83, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6845), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6845), new TimeSpan(0, 0, 0, 0, 0), "/music/Reverse feat. G-Eazy.mp3", 1, 0, "NotLiked", "Reverse feat. G-Eazy", null, "Seeder" },
                    { 84, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6851), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6852), new TimeSpan(0, 0, 0, 0, 0), "/music/Rich The Kid - Plug Walk (Audio).mp3", 1, 0, "NotLiked", "Rich The Kid - Plug Walk (Audio)", null, "Seeder" },
                    { 85, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6858), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6858), new TimeSpan(0, 0, 0, 0, 0), "/music/Right Now.mp3", 1, 0, "NotLiked", "Right Now", null, "Seeder" },
                    { 86, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6891), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6891), new TimeSpan(0, 0, 0, 0, 0), "/music/RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends.mp3", 1, 0, "NotLiked", "RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends", null, "Seeder" },
                    { 87, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6899), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6899), new TimeSpan(0, 0, 0, 0, 0), "/music/Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST.mp3", 1, 0, "NotLiked", "Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST", null, "Seeder" },
                    { 88, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6905), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6906), new TimeSpan(0, 0, 0, 0, 0), "/music/SAD!.mp3", 1, 0, "NotLiked", "SAD!", null, "Seeder" },
                    { 89, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6912), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6912), new TimeSpan(0, 0, 0, 0, 0), "/music/Saijaku Muhai no Bahamut  - Saijaku Muhai OST.mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut  - Saijaku Muhai OST", null, "Seeder" },
                    { 90, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6920), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6921), new TimeSpan(0, 0, 0, 0, 0), "/music/Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only).mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only)", null, "Seeder" },
                    { 91, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6926), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6927), new TimeSpan(0, 0, 0, 0, 0), "/music/Sakura - 落ち着いて冷やす.mp3", 1, 0, "NotLiked", "Sakura - 落ち着いて冷やす", null, "Seeder" },
                    { 92, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6933), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6934), new TimeSpan(0, 0, 0, 0, 0), "/music/SAMAHTA - graffiti (feat. Melody Federer).mp3", 1, 0, "NotLiked", "SAMAHTA - graffiti (feat. Melody Federer)", null, "Seeder" },
                    { 93, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6942), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6942), new TimeSpan(0, 0, 0, 0, 0), "/music/Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte", null, "Seeder" },
                    { 94, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6948), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6948), new TimeSpan(0, 0, 0, 0, 0), "/music/Shawn Mendes - Mercy.mp3", 1, 0, "NotLiked", "Shawn Mendes - Mercy", null, "Seeder" },
                    { 95, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6954), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6954), new TimeSpan(0, 0, 0, 0, 0), "/music/Shawn Mendes - Stitches.mp3", 1, 0, "NotLiked", "Shawn Mendes - Stitches", null, "Seeder" },
                    { 96, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6961), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6961), new TimeSpan(0, 0, 0, 0, 0), "/music/Shawn Mendes - Theres Nothing Holdin Me Back.mp3", 1, 0, "NotLiked", "Shawn Mendes - Theres Nothing Holdin Me Back", null, "Seeder" },
                    { 97, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6967), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6967), new TimeSpan(0, 0, 0, 0, 0), "/music/Shawn Mendes - Treat You Better.mp3", 1, 0, "NotLiked", "Shawn Mendes - Treat You Better", null, "Seeder" },
                    { 98, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6973), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(6973), new TimeSpan(0, 0, 0, 0, 0), "/music/Sheck Wes - Mo Bamba.mp3", 1, 0, "NotLiked", "Sheck Wes - Mo Bamba", null, "Seeder" },
                    { 99, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7027), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7027), new TimeSpan(0, 0, 0, 0, 0), "/music/Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte", null, "Seeder" },
                    { 100, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7033), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7034), new TimeSpan(0, 0, 0, 0, 0), "/music/Sickick - Infected.mp3", 1, 0, "NotLiked", "Sickick - Infected", null, "Seeder" },
                    { 101, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7040), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7040), new TimeSpan(0, 0, 0, 0, 0), "/music/Sickick - Mind Games.mp3", 1, 0, "NotLiked", "Sickick - Mind Games", null, "Seeder" },
                    { 102, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7046), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7046), new TimeSpan(0, 0, 0, 0, 0), "/music/SickickMusic - Lost My Way.mp3", 1, 0, "NotLiked", "SickickMusic - Lost My Way", null, "Seeder" },
                    { 103, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7053), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7053), new TimeSpan(0, 0, 0, 0, 0), "/music/Skan & Krale - No Glory (feat. M.I.M.E & Drama B).mp3", 1, 0, "NotLiked", "Skan & Krale - No Glory (feat. M.I.M.E & Drama B)", null, "Seeder" },
                    { 104, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7060), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7060), new TimeSpan(0, 0, 0, 0, 0), "/music/SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW.mp3", 1, 0, "NotLiked", "SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW", null, "Seeder" },
                    { 105, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7066), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7067), new TimeSpan(0, 0, 0, 0, 0), "/music/SKRILLEX - Bangarang feat. Sirah.mp3", 1, 0, "NotLiked", "SKRILLEX - Bangarang feat. Sirah", null, "Seeder" },
                    { 106, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7073), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7073), new TimeSpan(0, 0, 0, 0, 0), "/music/Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix).mp3", 1, 0, "NotLiked", "Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix)", null, "Seeder" },
                    { 107, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7081), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7081), new TimeSpan(0, 0, 0, 0, 0), "/music/Soredemo sekai wa utsukushii - Beautiful rain full ver..mp3", 1, 0, "NotLiked", "Soredemo sekai wa utsukushii - Beautiful rain full ver.", null, "Seeder" },
                    { 108, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7088), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7088), new TimeSpan(0, 0, 0, 0, 0), "/music/Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna].mp3", 1, 0, "NotLiked", "Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna]", null, "Seeder" },
                    { 109, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7094), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7095), new TimeSpan(0, 0, 0, 0, 0), "/music/STéLOUSE - Sociopath (feat. Bryce Fox).mp3", 1, 0, "NotLiked", "STéLOUSE - Sociopath (feat. Bryce Fox)", null, "Seeder" },
                    { 110, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7101), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7101), new TimeSpan(0, 0, 0, 0, 0), "/music/Sufian Suhaimi - Di Matamu.mp3", 1, 0, "NotLiked", "Sufian Suhaimi - Di Matamu", null, "Seeder" },
                    { 111, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7132), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7133), new TimeSpan(0, 0, 0, 0, 0), "/music/Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting", null, "Seeder" },
                    { 112, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7141), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7141), new TimeSpan(0, 0, 0, 0, 0), "/music/Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub", null, "Seeder" },
                    { 113, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7148), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7149), new TimeSpan(0, 0, 0, 0, 0), "/music/Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION.mp3", 1, 0, "NotLiked", "Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION", null, "Seeder" },
                    { 114, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7155), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7155), new TimeSpan(0, 0, 0, 0, 0), "/music/TETRA-FANG - Supernova.mp3", 1, 0, "NotLiked", "TETRA-FANG - Supernova", null, "Seeder" },
                    { 115, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7162), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7162), new TimeSpan(0, 0, 0, 0, 0), "/music/The Mirza - Lelah Mengalah.mp3", 1, 0, "NotLiked", "The Mirza - Lelah Mengalah", null, "Seeder" },
                    { 116, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7169), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7169), new TimeSpan(0, 0, 0, 0, 0), "/music/The Soul of Wind -  🗻 The Mountains 🗻.mp3", 1, 0, "NotLiked", "The Soul of Wind -  🗻 The Mountains 🗻", null, "Seeder" },
                    { 117, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7176), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7176), new TimeSpan(0, 0, 0, 0, 0), "/music/TheFatRat - Fly Away feat. Anjulie.mp3", 1, 0, "NotLiked", "TheFatRat - Fly Away feat. Anjulie", null, "Seeder" },
                    { 118, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7182), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7183), new TimeSpan(0, 0, 0, 0, 0), "/music/TheFatRat - Monody (feat. Laura Brehm).mp3", 1, 0, "NotLiked", "TheFatRat - Monody (feat. Laura Brehm)", null, "Seeder" },
                    { 119, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7188), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7189), new TimeSpan(0, 0, 0, 0, 0), "/music/TheFatRat - Time Lapse.mp3", 1, 0, "NotLiked", "TheFatRat - Time Lapse", null, "Seeder" },
                    { 120, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7195), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7195), new TimeSpan(0, 0, 0, 0, 0), "/music/TheFatRat - Unity.mp3", 1, 0, "NotLiked", "TheFatRat - Unity", null, "Seeder" },
                    { 121, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7201), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7201), new TimeSpan(0, 0, 0, 0, 0), "/music/TIIMO - Bangin In the Club.mp3", 1, 0, "NotLiked", "TIIMO - Bangin In the Club", null, "Seeder" },
                    { 122, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7207), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7208), new TimeSpan(0, 0, 0, 0, 0), "/music/Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-].mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-]", null, "Seeder" },
                    { 123, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7214), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7214), new TimeSpan(0, 0, 0, 0, 0), "/music/Tokyo Ghoul - Unravel (Marco B. Remix).mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (Marco B. Remix)", null, "Seeder" },
                    { 124, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7221), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7221), new TimeSpan(0, 0, 0, 0, 0), "/music/Tokyo Ghoul - Unravel (OP Piano) .mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (OP Piano) ", null, "Seeder" },
                    { 125, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7227), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7227), new TimeSpan(0, 0, 0, 0, 0), "/music/Tokyo Ghoul - Unravel 2.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel 2", null, "Seeder" },
                    { 126, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7277), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7277), new TimeSpan(0, 0, 0, 0, 0), "/music/Tokyo Ghoul - Unravel.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel", null, "Seeder" },
                    { 127, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7284), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7284), new TimeSpan(0, 0, 0, 0, 0), "/music/Tokyo Machine - FLY [Monstercat Release].mp3", 1, 0, "NotLiked", "Tokyo Machine - FLY [Monstercat Release]", null, "Seeder" },
                    { 128, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7291), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7292), new TimeSpan(0, 0, 0, 0, 0), "/music/Trapcity - Dead To Me (feat. Lox Chatterbox).mp3", 1, 0, "NotLiked", "Trapcity - Dead To Me (feat. Lox Chatterbox)", null, "Seeder" },
                    { 129, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7298), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7298), new TimeSpan(0, 0, 0, 0, 0), "/music/Trapcity - Samurai☯ Lofi.mp3", 1, 0, "NotLiked", "Trapcity - Samurai☯ Lofi", null, "Seeder" },
                    { 130, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7306), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7307), new TimeSpan(0, 0, 0, 0, 0), "/music/Trapcity - Trap Queen (Crankdat Remix).mp3", 1, 0, "NotLiked", "Trapcity - Trap Queen (Crankdat Remix)", null, "Seeder" },
                    { 131, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7313), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7314), new TimeSpan(0, 0, 0, 0, 0), "/music/Travis Scott - SICKO MODE.mp3", 1, 0, "NotLiked", "Travis Scott - SICKO MODE", null, "Seeder" },
                    { 132, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7320), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7320), new TimeSpan(0, 0, 0, 0, 0), "/music/Two Feet - I Feel Like Im Drowning.mp3", 1, 0, "NotLiked", "Two Feet - I Feel Like Im Drowning", null, "Seeder" },
                    { 133, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7327), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7327), new TimeSpan(0, 0, 0, 0, 0), "/music/Unlike Pluto ft. Mike Taylor - Everything Black.mp3", 1, 0, "NotLiked", "Unlike Pluto ft. Mike Taylor - Everything Black", null, "Seeder" },
                    { 134, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7333), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7334), new TimeSpan(0, 0, 0, 0, 0), "/music/Wishing Lyrics Rem(minase inori) ReZero.mp3", 1, 0, "NotLiked", "Wishing Lyrics Rem(minase inori) ReZero", null, "Seeder" },
                    { 135, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7340), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7340), new TimeSpan(0, 0, 0, 0, 0), "/music/XXXTENTACION - BAD!.mp3", 1, 0, "NotLiked", "XXXTENTACION - BAD!", null, "Seeder" },
                    { 136, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7347), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7347), new TimeSpan(0, 0, 0, 0, 0), "/music/Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics].mp3", 1, 0, "NotLiked", "Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics]", null, "Seeder" },
                    { 137, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7398), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7398), new TimeSpan(0, 0, 0, 0, 0), "/music/Yasuha - Flyday Chinatown.mp3", 1, 0, "NotLiked", "Yasuha - Flyday Chinatown", null, "Seeder" },
                    { 138, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7405), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7406), new TimeSpan(0, 0, 0, 0, 0), "/music/YOASOBI 夜に駆ける English & Romanji Lyrics.mp3", 1, 0, "NotLiked", "YOASOBI 夜に駆ける English & Romanji Lyrics", null, "Seeder" },
                    { 139, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7413), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7413), new TimeSpan(0, 0, 0, 0, 0), "/music/YOASOBIハルジオンOfficial Music Video.mp3", 1, 0, "NotLiked", "YOASOBIハルジオンOfficial Music Video", null, "Seeder" },
                    { 140, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7419), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7420), new TimeSpan(0, 0, 0, 0, 0), "/music/Yuna - Longing.mp3", 1, 0, "NotLiked", "Yuna - Longing", null, "Seeder" },
                    { 141, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7426), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7426), new TimeSpan(0, 0, 0, 0, 0), "/music/Yuna - Smile for you .mp3", 1, 0, "NotLiked", "Yuna - Smile for you ", null, "Seeder" },
                    { 142, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7433), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7433), new TimeSpan(0, 0, 0, 0, 0), "/music/タイニーリトルアシアンタム.mp3", 1, 0, "NotLiked", "タイニーリトルアシアンタム", null, "Seeder" },
                    { 143, null, 1, null, "Seeder", new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7439), new DateTime(2025, 2, 1, 16, 29, 34, 441, DateTimeKind.Local).AddTicks(7439), new TimeSpan(0, 0, 0, 0, 0), "/music/レペゼン地球66thシングルO2MEN.mp3", 1, 0, "NotLiked", "レペゼン地球66thシングルO2MEN", null, "Seeder" }
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
