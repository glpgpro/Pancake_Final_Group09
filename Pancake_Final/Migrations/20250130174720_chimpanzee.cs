using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pancake_Final.Migrations
{
    /// <inheritdoc />
    public partial class chimpanzee : Migration
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f95d5abe-555c-4a15-a5fb-14e8e86403ed", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECaz5ad9J01T1M4IdtZrbFm53ts8arg8Ikwwo8K5k/0hrZJPv8VjPt7hIlMAIRcdAw==", null, false, "d9b91eb1-554e-4080-a2fa-7d436bb0dd4f", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumID", "ArtistId", "ArtistsArtistID", "CreatedBy", "DateCreated", "DateUpdated", "Duration", "FilePath", "GenID", "Id", "LikedS", "Name", "PlaylistID", "UpdateBy" },
                values: new object[,]
                {
                    { 1, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 658, DateTimeKind.Local).AddTicks(9962), new DateTime(2025, 1, 31, 1, 47, 18, 658, DateTimeKind.Local).AddTicks(9974), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Don Toliver - No Pole", null, "Seeder" },
                    { 2, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 658, DateTimeKind.Local).AddTicks(9986), new DateTime(2025, 1, 31, 1, 47, 18, 658, DateTimeKind.Local).AddTicks(9987), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人", null, "Seeder" },
                    { 3, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 658, DateTimeKind.Local).AddTicks(9989), new DateTime(2025, 1, 31, 1, 47, 18, 658, DateTimeKind.Local).AddTicks(9990), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Goblin Slayer - Rightfully _ Mili [Full]", null, "Seeder" },
                    { 4, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 658, DateTimeKind.Local).AddTicks(9992), new DateTime(2025, 1, 31, 1, 47, 18, 658, DateTimeKind.Local).AddTicks(9992), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Goblins from Mars  - Put Your Love In Dreamz", null, "Seeder" },
                    { 5, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(24), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(25), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Goblins from Mars - Cold Blooded Love (ft. Krista Marina)", null, "Seeder" },
                    { 6, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(28), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(29), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Goblins from Mars - Heart Afire When The Bassjumps", null, "Seeder" },
                    { 7, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(31), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(32), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC]", null, "Seeder" },
                    { 8, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(34), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(34), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC]", null, "Seeder" },
                    { 9, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(36), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(37), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "grandson - Despicable", null, "Seeder" },
                    { 10, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(40), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(41), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Greatest Battle Music Of All Times Saijaku Muhai", null, "Seeder" },
                    { 11, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(43), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(43), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Gundam - OP1 HD", null, "Seeder" },
                    { 12, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(45), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(45), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Gundam - Seed", null, "Seeder" },
                    { 13, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(47), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(48), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Hans Zimmer - Flight", null, "Seeder" },
                    { 14, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(55), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(56), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music", null, "Seeder" },
                    { 15, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(58), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(65), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Hiroyuki Sawano Impure King Suite Epic Battle Music", null, "Seeder" },
                    { 16, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(85), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(86), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "HOPE", null, "Seeder" },
                    { 17, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(88), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(89), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "HOTD - Pentakill ", null, "Seeder" },
                    { 18, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(92), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(92), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "i feel like i did too much Don Toliver - No Idea (Lyrics)", null, "Seeder" },
                    { 19, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(94), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(95), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "I NEED U (Official MV)", null, "Seeder" },
                    { 20, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(97), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(97), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "IDOL Official MV", null, "Seeder" },
                    { 21, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(100), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(100), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix]", null, "Seeder" },
                    { 22, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(102), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(103), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Imagine Dragons - Believer", null, "Seeder" },
                    { 23, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(105), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(105), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "ISLAND OST - Island Opening Full「Eien no Hitotsu」", null, "Seeder" },
                    { 24, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(107), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(108), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "ISLAND OST - Lasting Memories FULL", null, "Seeder" },
                    { 25, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(110), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(111), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "J.Fla  - Havana", null, "Seeder" },
                    { 26, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(113), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(113), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Jacob Lee - Demons", null, "Seeder" },
                    { 27, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(115), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(115), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Jaden - GOKU", null, "Seeder" },
                    { 28, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(122), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(123), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Justin Stone - Lungs (Prod. Alex Collins)", null, "Seeder" },
                    { 29, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(129), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(129), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kaguya-Sama - Love is war (feat. Masayuki Suzuki) ", null, "Seeder" },
                    { 30, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(147), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(147), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki", null, "Seeder" },
                    { 31, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(150), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(150), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kakusei [Awakening]", null, "Seeder" },
                    { 32, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(152), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(152), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kamikaze Feat. Lox Chatterbox", null, "Seeder" },
                    { 33, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(154), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(155), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KANA-BOON - Silhouette", null, "Seeder" },
                    { 34, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(158), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(158), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends", null, "Seeder" },
                    { 35, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(161), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(161), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP", null, "Seeder" },
                    { 36, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(214), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(215), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "khai dreams - sunkissed", null, "Seeder" },
                    { 37, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(218), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(219), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Kibou No Uta Lyrics", null, "Seeder" },
                    { 38, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(221), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(221), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Krewella - Calm Down (SKAN Remix)", null, "Seeder" },
                    { 39, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(223), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(224), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KSI & Randolph - Champagne (Official Audio)", null, "Seeder" },
                    { 40, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(226), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(226), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KUURO - Afraid of the Dark (feat. Sophiya) ", null, "Seeder" },
                    { 41, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(228), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(228), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "KUURO - What U Wanna Do", null, "Seeder" },
                    { 42, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(230), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(231), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LAYTO - Little Poor Me", null, "Seeder" },
                    { 43, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(233), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(233), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends", null, "Seeder" },
                    { 44, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(235), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(236), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST - Hope", null, "Seeder" },
                    { 45, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(238), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(238), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST", null, "Seeder" },
                    { 46, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(240), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(241), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Liam Ferrari - I Like The Way", null, "Seeder" },
                    { 47, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(242), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(243), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Lil Nas X Billy Ray Cyrus - Old Town Road (Remix)", null, "Seeder" },
                    { 48, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(245), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(245), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LIL SKIES - Boss Up", null, "Seeder" },
                    { 49, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(247), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(248), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LIL SKIES - Lust", null, "Seeder" },
                    { 50, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(249), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(250), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Lil Uzi Vert - XO Tour Llif3 ", null, "Seeder" },
                    { 51, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(252), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(252), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Lilianna Wilde - Grind Me Down (Jawster Remix)", null, "Seeder" },
                    { 52, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(254), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(255), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LiSA - Catch the Moment", null, "Seeder" },
                    { 53, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(256), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(257), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "LiSA - Crossing Field", null, "Seeder" },
                    { 54, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(259), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(259), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Look Alive [BASS BOOSTED]", null, "Seeder" },
                    { 55, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(261), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(262), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Lyrics Owari no Seraph OST - 108", null, "Seeder" },
                    { 56, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(264), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(264), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ", null, "Seeder" },
                    { 57, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(266), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(267), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Magnolia", null, "Seeder" },
                    { 58, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(268), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(269), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Maroon 5 - Sugar", null, "Seeder" },
                    { 59, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(271), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(271), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Maroon 5 Ft. Wiz Khalifa", null, "Seeder" },
                    { 60, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(273), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(274), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "MHW ICEBORNE Safi Jiiva Battle Theme OST", null, "Seeder" },
                    { 61, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(275), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(276), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "MIC Drop (Steve Aoki Remix) Official MV", null, "Seeder" },
                    { 62, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(278), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(278), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Migos - Get Right Witcha (G-REX X TOP $HELF Remix)", null, "Seeder" },
                    { 63, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(280), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(281), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura", null, "Seeder" },
                    { 64, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(283), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(283), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Moonlight", null, "Seeder" },
                    { 65, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(285), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(286), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records", null, "Seeder" },
                    { 66, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(289), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(290), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Mrs. GREEN APPLE - インフェルノInferno", null, "Seeder" },
                    { 67, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(292), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(293), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2)", null, "Seeder" },
                    { 68, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(294), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(295), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version)", null, "Seeder" },
                    { 69, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(336), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(337), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Namirin  - Renai Circulation「恋愛サーキュレーショ", null, "Seeder" },
                    { 70, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(339), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(339), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Nanatsu no Taizai S2 - Escanor Theme (Rearrangement)", null, "Seeder" },
                    { 71, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(341), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(342), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "NEFFEX - Fight Back", null, "Seeder" },
                    { 72, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(343), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(344), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "NEFFEX - Myself", null, "Seeder" },
                    { 73, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(346), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(346), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro)", null, "Seeder" },
                    { 74, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(348), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(349), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Nightcore - Control", null, "Seeder" },
                    { 75, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(350), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(351), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Nightcore - Rockefeller Street", null, "Seeder" },
                    { 76, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(353), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(353), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "No Game No Life Opening Full", null, "Seeder" },
                    { 77, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(355), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(355), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Not Today Official MV", null, "Seeder" },
                    { 78, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(357), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(358), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Nto - Trauma (Worakls Remix)", null, "Seeder" },
                    { 79, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(360), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(360), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Owari no Seraph OST - 1hundredknight M [終わりのセラフ]", null, "Seeder" },
                    { 80, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(362), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(363), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack", null, "Seeder" },
                    { 81, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(364), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(365), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Post Malone - Better Now", null, "Seeder" },
                    { 82, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(367), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(368), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Post Malone_ 21 Savage - Rockstar", null, "Seeder" },
                    { 83, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(370), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(370), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Reverse feat. G-Eazy", null, "Seeder" },
                    { 84, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(372), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(373), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Rich The Kid - Plug Walk (Audio)", null, "Seeder" },
                    { 85, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(375), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(375), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Right Now", null, "Seeder" },
                    { 86, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(377), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(378), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends", null, "Seeder" },
                    { 87, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(380), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(380), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST", null, "Seeder" },
                    { 88, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(382), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(383), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SAD!", null, "Seeder" },
                    { 89, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(385), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(385), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut  - Saijaku Muhai OST", null, "Seeder" },
                    { 90, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(387), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(388), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only)", null, "Seeder" },
                    { 91, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(389), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(390), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sakura - 落ち着いて冷やす", null, "Seeder" },
                    { 92, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(392), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(392), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SAMAHTA - graffiti (feat. Melody Federer)", null, "Seeder" },
                    { 93, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(394), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(395), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte", null, "Seeder" },
                    { 94, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(396), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(397), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shawn Mendes - Mercy", null, "Seeder" },
                    { 95, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(399), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(399), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shawn Mendes - Stitches", null, "Seeder" },
                    { 96, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(401), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(401), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shawn Mendes - Theres Nothing Holdin Me Back", null, "Seeder" },
                    { 97, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(403), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(404), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shawn Mendes - Treat You Better", null, "Seeder" },
                    { 98, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(405), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(406), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sheck Wes - Mo Bamba", null, "Seeder" },
                    { 99, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(408), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(408), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte", null, "Seeder" },
                    { 100, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(410), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(411), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sickick - Infected", null, "Seeder" },
                    { 101, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(412), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(413), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sickick - Mind Games", null, "Seeder" },
                    { 102, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(415), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(415), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SickickMusic - Lost My Way", null, "Seeder" },
                    { 103, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(417), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(418), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Skan & Krale - No Glory (feat. M.I.M.E & Drama B)", null, "Seeder" },
                    { 104, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(419), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(420), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW", null, "Seeder" },
                    { 105, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(422), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(422), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "SKRILLEX - Bangarang feat. Sirah", null, "Seeder" },
                    { 106, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(424), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(425), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix)", null, "Seeder" },
                    { 107, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(454), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(454), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Soredemo sekai wa utsukushii - Beautiful rain full ver.", null, "Seeder" },
                    { 108, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(456), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(457), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna]", null, "Seeder" },
                    { 109, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(459), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(459), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "STéLOUSE - Sociopath (feat. Bryce Fox)", null, "Seeder" },
                    { 110, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(461), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(462), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sufian Suhaimi - Di Matamu", null, "Seeder" },
                    { 111, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(464), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(464), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting", null, "Seeder" },
                    { 112, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(467), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(467), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub", null, "Seeder" },
                    { 113, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(469), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(470), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION", null, "Seeder" },
                    { 114, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(471), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(472), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TETRA-FANG - Supernova", null, "Seeder" },
                    { 115, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(474), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(474), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "The Mirza - Lelah Mengalah", null, "Seeder" },
                    { 116, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(476), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(476), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "The Soul of Wind -  🗻 The Mountains 🗻", null, "Seeder" },
                    { 117, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(478), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(479), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TheFatRat - Fly Away feat. Anjulie", null, "Seeder" },
                    { 118, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(481), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(481), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TheFatRat - Monody (feat. Laura Brehm)", null, "Seeder" },
                    { 119, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(483), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(484), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TheFatRat - Time Lapse", null, "Seeder" },
                    { 120, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(485), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(486), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TheFatRat - Unity", null, "Seeder" },
                    { 121, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(488), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(488), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "TIIMO - Bangin In the Club", null, "Seeder" },
                    { 122, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(490), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(490), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-]", null, "Seeder" },
                    { 123, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(492), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(493), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (Marco B. Remix)", null, "Seeder" },
                    { 124, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(495), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(495), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (OP Piano) ", null, "Seeder" },
                    { 125, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(497), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(498), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel 2", null, "Seeder" },
                    { 126, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(499), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(500), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel", null, "Seeder" },
                    { 127, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(502), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(502), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Tokyo Machine - FLY [Monstercat Release]", null, "Seeder" },
                    { 128, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(504), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(505), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Trapcity - Dead To Me (feat. Lox Chatterbox)", null, "Seeder" },
                    { 129, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(507), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(507), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Trapcity - Samurai☯ Lofi", null, "Seeder" },
                    { 130, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(510), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(511), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Trapcity - Trap Queen (Crankdat Remix)", null, "Seeder" },
                    { 131, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(513), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(513), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Travis Scott - SICKO MODE", null, "Seeder" },
                    { 132, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(515), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(516), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Two Feet - I Feel Like Im Drowning", null, "Seeder" },
                    { 133, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(517), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(518), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Unlike Pluto ft. Mike Taylor - Everything Black", null, "Seeder" },
                    { 134, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(547), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(547), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Wishing Lyrics Rem(minase inori) ReZero", null, "Seeder" },
                    { 135, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(549), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(550), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "XXXTENTACION - BAD!", null, "Seeder" },
                    { 136, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(552), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(552), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics]", null, "Seeder" },
                    { 137, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(554), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(555), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Yasuha - Flyday Chinatown", null, "Seeder" },
                    { 138, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(556), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(557), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "YOASOBI 夜に駆ける English & Romanji Lyrics", null, "Seeder" },
                    { 139, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(559), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(559), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "YOASOBIハルジオンOfficial Music Video", null, "Seeder" },
                    { 140, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(561), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(562), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Yuna - Longing", null, "Seeder" },
                    { 141, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(563), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(564), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "Yuna - Smile for you ", null, "Seeder" },
                    { 142, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(566), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(566), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "タイニーリトルアシアンタム", null, "Seeder" },
                    { 143, null, 1, null, "Seeder", new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(568), new DateTime(2025, 1, 31, 1, 47, 18, 659, DateTimeKind.Local).AddTicks(569), new TimeSpan(0, 0, 0, 0, 0), "", 1, 0, "NotLiked", "レペゼン地球66thシングルO2MEN", null, "Seeder" }
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
