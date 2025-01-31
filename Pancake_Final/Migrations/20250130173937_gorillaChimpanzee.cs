using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pancake_Final.Migrations
{
    /// <inheritdoc />
    public partial class gorillaChimpanzee : Migration
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
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    AlbumID = table.Column<int>(type: "int", nullable: false),
                    GenID = table.Column<int>(type: "int", nullable: false),
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "6fd37fbb-8195-4cc7-995e-5d8e1530f463", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPjWgGZsFW/JUONZ/CNnbywz7S5vozMmSyOxhRQjlXf/CqIqEp1Nfi2RXNZWV9RZaw==", null, false, "3c5f84fb-e616-4e95-8f0f-fbad184be31c", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumID", "ArtistId", "ArtistsArtistID", "CreatedBy", "DateCreated", "DateUpdated", "Duration", "FilePath", "GenID", "Id", "LikedS", "Name", "PlaylistID", "UpdateBy" },
                values: new object[,]
                {
                    { 1, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8613), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8625), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Don Toliver - No Pole", null, "Seeder" },
                    { 2, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8632), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8633), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人", null, "Seeder" },
                    { 3, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8635), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8635), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Goblin Slayer - Rightfully _ Mili [Full]", null, "Seeder" },
                    { 4, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8637), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8637), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Goblins from Mars  - Put Your Love In Dreamz", null, "Seeder" },
                    { 5, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8639), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8639), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Goblins from Mars - Cold Blooded Love (ft. Krista Marina)", null, "Seeder" },
                    { 6, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8642), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8642), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Goblins from Mars - Heart Afire When The Bassjumps", null, "Seeder" },
                    { 7, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8644), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8645), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC]", null, "Seeder" },
                    { 8, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8646), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8647), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC]", null, "Seeder" },
                    { 9, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8648), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8649), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "grandson - Despicable", null, "Seeder" },
                    { 10, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8651), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8652), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Greatest Battle Music Of All Times Saijaku Muhai", null, "Seeder" },
                    { 11, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8653), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8654), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Gundam - OP1 HD", null, "Seeder" },
                    { 12, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8691), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8691), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Gundam - Seed", null, "Seeder" },
                    { 13, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8693), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8693), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Hans Zimmer - Flight", null, "Seeder" },
                    { 14, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8695), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8696), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music", null, "Seeder" },
                    { 15, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8697), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8698), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Hiroyuki Sawano Impure King Suite Epic Battle Music", null, "Seeder" },
                    { 16, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8699), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8700), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "HOPE", null, "Seeder" },
                    { 17, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8702), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8702), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "HOTD - Pentakill ", null, "Seeder" },
                    { 18, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8705), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8705), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "i feel like i did too much Don Toliver - No Idea (Lyrics)", null, "Seeder" },
                    { 19, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8707), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8707), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "I NEED U (Official MV)", null, "Seeder" },
                    { 20, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8708), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8709), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "IDOL Official MV", null, "Seeder" },
                    { 21, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8711), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8711), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix]", null, "Seeder" },
                    { 22, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8713), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8713), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Imagine Dragons - Believer", null, "Seeder" },
                    { 23, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8715), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8716), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "ISLAND OST - Island Opening Full「Eien no Hitotsu」", null, "Seeder" },
                    { 24, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8717), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8718), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "ISLAND OST - Lasting Memories FULL", null, "Seeder" },
                    { 25, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8719), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8719), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "J.Fla  - Havana", null, "Seeder" },
                    { 26, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8721), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8721), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Jacob Lee - Demons", null, "Seeder" },
                    { 27, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8723), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8723), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Jaden - GOKU", null, "Seeder" },
                    { 28, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8725), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8725), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Justin Stone - Lungs (Prod. Alex Collins)", null, "Seeder" },
                    { 29, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8727), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8727), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kaguya-Sama - Love is war (feat. Masayuki Suzuki) ", null, "Seeder" },
                    { 30, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8729), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8729), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki", null, "Seeder" },
                    { 31, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8731), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8731), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kakusei [Awakening]", null, "Seeder" },
                    { 32, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8733), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8733), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kamikaze Feat. Lox Chatterbox", null, "Seeder" },
                    { 33, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8735), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8735), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KANA-BOON - Silhouette", null, "Seeder" },
                    { 34, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8738), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8738), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends", null, "Seeder" },
                    { 35, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8740), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8740), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP", null, "Seeder" },
                    { 36, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8742), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8742), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "khai dreams - sunkissed", null, "Seeder" },
                    { 37, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8744), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8744), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kibou No Uta Lyrics", null, "Seeder" },
                    { 38, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8746), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8746), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Krewella - Calm Down (SKAN Remix)", null, "Seeder" },
                    { 39, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8748), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8748), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KSI & Randolph - Champagne (Official Audio)", null, "Seeder" },
                    { 40, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8750), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8750), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KUURO - Afraid of the Dark (feat. Sophiya) ", null, "Seeder" },
                    { 41, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8751), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8752), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KUURO - What U Wanna Do", null, "Seeder" },
                    { 42, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8753), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8754), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LAYTO - Little Poor Me", null, "Seeder" },
                    { 43, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8755), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8756), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends", null, "Seeder" },
                    { 44, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8757), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8758), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST - Hope", null, "Seeder" },
                    { 45, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8760), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8760), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST", null, "Seeder" },
                    { 46, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8762), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8762), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Liam Ferrari - I Like The Way", null, "Seeder" },
                    { 47, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8764), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8764), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Lil Nas X Billy Ray Cyrus - Old Town Road (Remix)", null, "Seeder" },
                    { 48, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8765), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8766), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LIL SKIES - Boss Up", null, "Seeder" },
                    { 49, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8793), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8793), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LIL SKIES - Lust", null, "Seeder" },
                    { 50, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8795), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8795), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Lil Uzi Vert - XO Tour Llif3 ", null, "Seeder" },
                    { 51, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8796), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8797), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Lilianna Wilde - Grind Me Down (Jawster Remix)", null, "Seeder" },
                    { 52, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8798), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8799), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LiSA - Catch the Moment", null, "Seeder" },
                    { 53, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8800), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8801), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LiSA - Crossing Field", null, "Seeder" },
                    { 54, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8802), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8803), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Look Alive [BASS BOOSTED]", null, "Seeder" },
                    { 55, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8804), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8805), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Lyrics Owari no Seraph OST - 108", null, "Seeder" },
                    { 56, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8806), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8807), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ", null, "Seeder" },
                    { 57, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8808), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8809), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Magnolia", null, "Seeder" },
                    { 58, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8810), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8811), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Maroon 5 - Sugar", null, "Seeder" },
                    { 59, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8812), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8812), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Maroon 5 Ft. Wiz Khalifa", null, "Seeder" },
                    { 60, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8814), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8814), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "MHW ICEBORNE Safi Jiiva Battle Theme OST", null, "Seeder" },
                    { 61, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8816), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8816), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "MIC Drop (Steve Aoki Remix) Official MV", null, "Seeder" },
                    { 62, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8818), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8818), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Migos - Get Right Witcha (G-REX X TOP $HELF Remix)", null, "Seeder" },
                    { 63, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8820), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8820), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura", null, "Seeder" },
                    { 64, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8822), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8822), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Moonlight", null, "Seeder" },
                    { 65, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8824), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8824), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records", null, "Seeder" },
                    { 66, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8827), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8827), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Mrs. GREEN APPLE - インフェルノInferno", null, "Seeder" },
                    { 67, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8829), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8829), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2)", null, "Seeder" },
                    { 68, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8831), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8831), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version)", null, "Seeder" },
                    { 69, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8833), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8833), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Namirin  - Renai Circulation「恋愛サーキュレーショ", null, "Seeder" },
                    { 70, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8835), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8835), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Nanatsu no Taizai S2 - Escanor Theme (Rearrangement)", null, "Seeder" },
                    { 71, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8836), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8837), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "NEFFEX - Fight Back", null, "Seeder" },
                    { 72, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8838), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8839), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "NEFFEX - Myself", null, "Seeder" },
                    { 73, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8841), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8841), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro)", null, "Seeder" },
                    { 74, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8843), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8843), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Nightcore - Control", null, "Seeder" },
                    { 75, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8845), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8845), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Nightcore - Rockefeller Street", null, "Seeder" },
                    { 76, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8846), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8847), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "No Game No Life Opening Full", null, "Seeder" },
                    { 77, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8848), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8849), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Not Today Official MV", null, "Seeder" },
                    { 78, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8850), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8851), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Nto - Trauma (Worakls Remix)", null, "Seeder" },
                    { 79, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8852), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8853), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Owari no Seraph OST - 1hundredknight M [終わりのセラフ]", null, "Seeder" },
                    { 80, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8854), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8855), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack", null, "Seeder" },
                    { 81, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8856), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8857), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Post Malone - Better Now", null, "Seeder" },
                    { 82, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8858), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8858), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Post Malone_ 21 Savage - Rockstar", null, "Seeder" },
                    { 83, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8860), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8860), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Reverse feat. G-Eazy", null, "Seeder" },
                    { 84, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8862), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8862), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Rich The Kid - Plug Walk (Audio)", null, "Seeder" },
                    { 85, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8889), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8889), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Right Now", null, "Seeder" },
                    { 86, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8891), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8891), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends", null, "Seeder" },
                    { 87, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8893), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8894), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST", null, "Seeder" },
                    { 88, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8895), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8896), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SAD!", null, "Seeder" },
                    { 89, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8897), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8898), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut  - Saijaku Muhai OST", null, "Seeder" },
                    { 90, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8899), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8900), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only)", null, "Seeder" },
                    { 91, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8901), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8902), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sakura - 落ち着いて冷やす", null, "Seeder" },
                    { 92, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8903), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8904), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SAMAHTA - graffiti (feat. Melody Federer)", null, "Seeder" },
                    { 93, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8905), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8906), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte", null, "Seeder" },
                    { 94, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8907), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8908), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shawn Mendes - Mercy", null, "Seeder" },
                    { 95, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8909), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8909), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shawn Mendes - Stitches", null, "Seeder" },
                    { 96, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8911), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8911), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shawn Mendes - Theres Nothing Holdin Me Back", null, "Seeder" },
                    { 97, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8913), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8913), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shawn Mendes - Treat You Better", null, "Seeder" },
                    { 98, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8915), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8915), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sheck Wes - Mo Bamba", null, "Seeder" },
                    { 99, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8917), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8917), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte", null, "Seeder" },
                    { 100, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8918), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8919), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sickick - Infected", null, "Seeder" },
                    { 101, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8921), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8921), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sickick - Mind Games", null, "Seeder" },
                    { 102, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8923), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8923), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SickickMusic - Lost My Way", null, "Seeder" },
                    { 103, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8925), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8925), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Skan & Krale - No Glory (feat. M.I.M.E & Drama B)", null, "Seeder" },
                    { 104, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8927), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8927), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW", null, "Seeder" },
                    { 105, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8928), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8929), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SKRILLEX - Bangarang feat. Sirah", null, "Seeder" },
                    { 106, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8930), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8931), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix)", null, "Seeder" },
                    { 107, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8932), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8933), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Soredemo sekai wa utsukushii - Beautiful rain full ver.", null, "Seeder" },
                    { 108, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8935), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8935), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna]", null, "Seeder" },
                    { 109, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8936), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8937), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "STéLOUSE - Sociopath (feat. Bryce Fox)", null, "Seeder" },
                    { 110, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8938), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8939), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sufian Suhaimi - Di Matamu", null, "Seeder" },
                    { 111, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8940), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8941), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting", null, "Seeder" },
                    { 112, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8942), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8943), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub", null, "Seeder" },
                    { 113, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8944), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8945), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION", null, "Seeder" },
                    { 114, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8946), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8946), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TETRA-FANG - Supernova", null, "Seeder" },
                    { 115, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8948), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8948), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "The Mirza - Lelah Mengalah", null, "Seeder" },
                    { 116, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8950), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8950), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "The Soul of Wind -  🗻 The Mountains 🗻", null, "Seeder" },
                    { 117, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8952), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8952), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TheFatRat - Fly Away feat. Anjulie", null, "Seeder" },
                    { 118, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8954), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8954), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TheFatRat - Monody (feat. Laura Brehm)", null, "Seeder" },
                    { 119, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8955), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8956), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TheFatRat - Time Lapse", null, "Seeder" },
                    { 120, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8957), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8958), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TheFatRat - Unity", null, "Seeder" },
                    { 121, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8959), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8959), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TIIMO - Bangin In the Club", null, "Seeder" },
                    { 122, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8961), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8961), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-]", null, "Seeder" },
                    { 123, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8963), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8963), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (Marco B. Remix)", null, "Seeder" },
                    { 124, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8989), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8990), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (OP Piano) ", null, "Seeder" },
                    { 125, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8991), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8991), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel 2", null, "Seeder" },
                    { 126, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8993), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8993), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel", null, "Seeder" },
                    { 127, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8995), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8995), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Machine - FLY [Monstercat Release]", null, "Seeder" },
                    { 128, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8997), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8997), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Trapcity - Dead To Me (feat. Lox Chatterbox)", null, "Seeder" },
                    { 129, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8998), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(8999), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Trapcity - Samurai☯ Lofi", null, "Seeder" },
                    { 130, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9002), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9002), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Trapcity - Trap Queen (Crankdat Remix)", null, "Seeder" },
                    { 131, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9004), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9004), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Travis Scott - SICKO MODE", null, "Seeder" },
                    { 132, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9006), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9006), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Two Feet - I Feel Like Im Drowning", null, "Seeder" },
                    { 133, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9008), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9008), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Unlike Pluto ft. Mike Taylor - Everything Black", null, "Seeder" },
                    { 134, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9010), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9010), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Wishing Lyrics Rem(minase inori) ReZero", null, "Seeder" },
                    { 135, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9012), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9012), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "XXXTENTACION - BAD!", null, "Seeder" },
                    { 136, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9013), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9014), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics]", null, "Seeder" },
                    { 137, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9015), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9016), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Yasuha - Flyday Chinatown", null, "Seeder" },
                    { 138, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9017), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9018), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "YOASOBI 夜に駆ける English & Romanji Lyrics", null, "Seeder" },
                    { 139, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9019), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9019), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "YOASOBIハルジオンOfficial Music Video", null, "Seeder" },
                    { 140, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9021), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9021), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Yuna - Longing", null, "Seeder" },
                    { 141, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9023), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9023), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Yuna - Smile for you ", null, "Seeder" },
                    { 142, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9025), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9025), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "タイニーリトルアシアンタム", null, "Seeder" },
                    { 143, 0, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9027), new DateTime(2025, 1, 31, 1, 39, 34, 873, DateTimeKind.Local).AddTicks(9027), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "レペゼン地球66thシングルO2MEN", null, "Seeder" }
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
