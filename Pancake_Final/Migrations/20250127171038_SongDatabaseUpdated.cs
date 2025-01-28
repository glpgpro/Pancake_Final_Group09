using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pancake_Final.Migrations
{
    /// <inheritdoc />
    public partial class SongDatabaseUpdated : Migration
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "b38f3d7d-ec3a-477c-b224-0edb9fb05f73", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFvpY2G+q9Wbx3LEg8X/fYVEjJikg/qlxv4nMyF9mtvF0Gsyvupq7NxWafpD6I7q2Q==", null, false, "5a4da099-098f-466a-acb3-9d553a6d9d0e", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "AlbumID", "ArtistId", "ArtistsArtistID", "CreatedBy", "DateCreated", "DateUpdated", "Duration", "FilePath", "GenID", "Id", "LikedS", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { 1, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2835), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2851), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Don Toliver - No Pole.mp3", 1, 0, "NotLiked", "Don Toliver - No Pole", "Seeder" },
                    { 2, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2863), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2864), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人.mp3", 1, 0, "NotLiked", "Genshin Impact丨Zhongli Theme musicListenerOST原神钟离听书人", "Seeder" },
                    { 3, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2866), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2867), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Goblin Slayer - Rightfully _ Mili [Full].mp3", 1, 0, "NotLiked", "Goblin Slayer - Rightfully _ Mili [Full]", "Seeder" },
                    { 4, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2869), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2870), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Goblins from Mars  - Put Your Love In Dreamz.mp3", 1, 0, "NotLiked", "Goblins from Mars  - Put Your Love In Dreamz", "Seeder" },
                    { 5, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2872), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2872), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Goblins from Mars - Cold Blooded Love (ft. Krista Marina).mp3", 1, 0, "NotLiked", "Goblins from Mars - Cold Blooded Love (ft. Krista Marina)", "Seeder" },
                    { 6, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2877), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2877), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Goblins from Mars - Heart Afire When The Bassjumps.mp3", 1, 0, "NotLiked", "Goblins from Mars - Heart Afire When The Bassjumps", "Seeder" },
                    { 7, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2947), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2948), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC].mp3", 1, 0, "NotLiked", "Gotoubun no Hanayome Ending Full SignCandy Flavor - Aya Uchida Lyrics [CC]", "Seeder" },
                    { 8, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2950), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2950), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC].mp3", 1, 0, "NotLiked", "Grancrest Senki Opening 2 Full _ Rin - ASCA Lyrics [CC]", "Seeder" },
                    { 9, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2952), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2953), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\grandson - Despicable.mp3", 1, 0, "NotLiked", "grandson - Despicable", "Seeder" },
                    { 10, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2957), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2957), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Greatest Battle Music Of All Times Saijaku Muhai.mp3", 1, 0, "NotLiked", "Greatest Battle Music Of All Times Saijaku Muhai", "Seeder" },
                    { 11, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2959), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2960), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Gundam - OP1 HD.mp3", 1, 0, "NotLiked", "Gundam - OP1 HD", "Seeder" },
                    { 12, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2961), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2962), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Gundam - Seed.mp3", 1, 0, "NotLiked", "Gundam - Seed", "Seeder" },
                    { 13, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2963), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2964), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Hans Zimmer - Flight.mp3", 1, 0, "NotLiked", "Hans Zimmer - Flight", "Seeder" },
                    { 14, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2966), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2967), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano ashes Suite [vocal gemie] Epic Battle Music", "Seeder" },
                    { 15, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2969), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2969), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Hiroyuki Sawano Impure King Suite Epic Battle Music.mp3", 1, 0, "NotLiked", "Hiroyuki Sawano Impure King Suite Epic Battle Music", "Seeder" },
                    { 16, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2971), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2972), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\HOPE.mp3", 1, 0, "NotLiked", "HOPE", "Seeder" },
                    { 17, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2974), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2974), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\HOTD - Pentakill .mp3", 1, 0, "NotLiked", "HOTD - Pentakill ", "Seeder" },
                    { 18, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2977), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2978), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\i feel like i did too much Don Toliver - No Idea (Lyrics).mp3", 1, 0, "NotLiked", "i feel like i did too much Don Toliver - No Idea (Lyrics)", "Seeder" },
                    { 19, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2979), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2980), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\I NEED U (Official MV).mp3", 1, 0, "NotLiked", "I NEED U (Official MV)", "Seeder" },
                    { 20, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2981), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\IDOL Official MV.mp3", 1, 0, "NotLiked", "IDOL Official MV", "Seeder" },
                    { 21, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2983), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2984), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix].mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer (Romy Wave Cover) [Not So Good Remix]", "Seeder" },
                    { 22, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2985), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2986), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Imagine Dragons - Believer.mp3", 1, 0, "NotLiked", "Imagine Dragons - Believer", "Seeder" },
                    { 23, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2988), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2988), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\ISLAND OST - Island Opening Full「Eien no Hitotsu」.mp3", 1, 0, "NotLiked", "ISLAND OST - Island Opening Full「Eien no Hitotsu」", "Seeder" },
                    { 24, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2990), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2990), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\ISLAND OST - Lasting Memories FULL.mp3", 1, 0, "NotLiked", "ISLAND OST - Lasting Memories FULL", "Seeder" },
                    { 25, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2992), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2992), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\J.Fla  - Havana.mp3", 1, 0, "NotLiked", "J.Fla  - Havana", "Seeder" },
                    { 26, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2994), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2994), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Jacob Lee - Demons.mp3", 1, 0, "NotLiked", "Jacob Lee - Demons", "Seeder" },
                    { 27, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2996), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2997), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Jaden - GOKU.mp3", 1, 0, "NotLiked", "Jaden - GOKU", "Seeder" },
                    { 28, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2999), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(2999), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Justin Stone - Lungs (Prod. Alex Collins).mp3", 1, 0, "NotLiked", "Justin Stone - Lungs (Prod. Alex Collins)", "Seeder" },
                    { 29, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3001), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3001), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Kaguya-Sama - Love is war (feat. Masayuki Suzuki) .mp3", 1, 0, "NotLiked", "Kaguya-Sama - Love is war (feat. Masayuki Suzuki) ", "Seeder" },
                    { 30, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3003), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3004), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki.mp3", 1, 0, "NotLiked", "Kaguya-sama Love is War Season 2 - Opening FullDADDY! DADDY! DO!by Masayuki Suzuki", "Seeder" },
                    { 31, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3005), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3006), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Kakusei [Awakening].mp3", 1, 0, "NotLiked", "Kakusei [Awakening]", "Seeder" },
                    { 32, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3008), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3008), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Kamikaze Feat. Lox Chatterbox.mp3", 1, 0, "NotLiked", "Kamikaze Feat. Lox Chatterbox", "Seeder" },
                    { 33, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3010), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3010), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\KANA-BOON - Silhouette.mp3", 1, 0, "NotLiked", "KANA-BOON - Silhouette", "Seeder" },
                    { 34, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3014), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3015), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends.mp3", 1, 0, "NotLiked", "KDA - POPSTARS (ft. Madison Beer, (G)I-DLE, Jaira Burns) Music Video - League of Legends", "Seeder" },
                    { 35, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3017), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3017), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP.mp3", 1, 0, "NotLiked", "Kenshi Yonezu (米津玄師) - Peace Sign (KanRomEng Lyrics)Boku no Hero Academia Season 2 OP", "Seeder" },
                    { 36, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3019), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3019), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\khai dreams - sunkissed.mp3", 1, 0, "NotLiked", "khai dreams - sunkissed", "Seeder" },
                    { 37, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3021), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3021), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Kibou No Uta Lyrics.mp3", 1, 0, "NotLiked", "Kibou No Uta Lyrics", "Seeder" },
                    { 38, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3023), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3023), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Krewella - Calm Down (SKAN Remix).mp3", 1, 0, "NotLiked", "Krewella - Calm Down (SKAN Remix)", "Seeder" },
                    { 39, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3025), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3026), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\KSI & Randolph - Champagne (Official Audio).mp3", 1, 0, "NotLiked", "KSI & Randolph - Champagne (Official Audio)", "Seeder" },
                    { 40, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3027), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3028), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\KUURO - Afraid of the Dark (feat. Sophiya) .mp3", 1, 0, "NotLiked", "KUURO - Afraid of the Dark (feat. Sophiya) ", "Seeder" },
                    { 41, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3029), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3030), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\KUURO - What U Wanna Do.mp3", 1, 0, "NotLiked", "KUURO - What U Wanna Do", "Seeder" },
                    { 42, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3032), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3032), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\LAYTO - Little Poor Me.mp3", 1, 0, "NotLiked", "LAYTO - Little Poor Me", "Seeder" },
                    { 43, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3110), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3110), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends.mp3", 1, 0, "NotLiked", "Legends Never Die (ft. Against The Current) [OFFICIAL AUDIO] Worlds 2017 - League of Legends", "Seeder" },
                    { 44, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3112), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3113), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Leonhart - Grancrest Senki OST - Hope.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST - Hope", "Seeder" },
                    { 45, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3114), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3115), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Leonhart - Grancrest Senki OST.mp3", 1, 0, "NotLiked", "Leonhart - Grancrest Senki OST", "Seeder" },
                    { 46, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3117), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3117), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Liam Ferrari - I Like The Way.mp3", 1, 0, "NotLiked", "Liam Ferrari - I Like The Way", "Seeder" },
                    { 47, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3119), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3119), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Lil Nas X Billy Ray Cyrus - Old Town Road (Remix).mp3", 1, 0, "NotLiked", "Lil Nas X Billy Ray Cyrus - Old Town Road (Remix)", "Seeder" },
                    { 48, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3121), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3122), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\LIL SKIES - Boss Up.mp3", 1, 0, "NotLiked", "LIL SKIES - Boss Up", "Seeder" },
                    { 49, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3123), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3124), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\LIL SKIES - Lust.mp3", 1, 0, "NotLiked", "LIL SKIES - Lust", "Seeder" },
                    { 50, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3125), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3126), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Lil Uzi Vert - XO Tour Llif3 .mp3", 1, 0, "NotLiked", "Lil Uzi Vert - XO Tour Llif3 ", "Seeder" },
                    { 51, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3127), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3128), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Lilianna Wilde - Grind Me Down (Jawster Remix).mp3", 1, 0, "NotLiked", "Lilianna Wilde - Grind Me Down (Jawster Remix)", "Seeder" },
                    { 52, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3129), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3130), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\LiSA - Catch the Moment.mp3", 1, 0, "NotLiked", "LiSA - Catch the Moment", "Seeder" },
                    { 53, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3131), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3132), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\LiSA - Crossing Field.mp3", 1, 0, "NotLiked", "LiSA - Crossing Field", "Seeder" },
                    { 54, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3134), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3134), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Look Alive [BASS BOOSTED].mp3", 1, 0, "NotLiked", "Look Alive [BASS BOOSTED]", "Seeder" },
                    { 55, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3135), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3136), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Lyrics Owari no Seraph OST - 108.mp3", 1, 0, "NotLiked", "Lyrics Owari no Seraph OST - 108", "Seeder" },
                    { 56, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3138), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3138), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ.mp3", 1, 0, "NotLiked", "MADKID - RISE Tate no Yuusha no Nariagari Full [OpeningApertura] HQ", "Seeder" },
                    { 57, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3140), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3141), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Magnolia.mp3", 1, 0, "NotLiked", "Magnolia", "Seeder" },
                    { 58, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3142), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3143), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Maroon 5 - Sugar.mp3", 1, 0, "NotLiked", "Maroon 5 - Sugar", "Seeder" },
                    { 59, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3144), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3145), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Maroon 5 Ft. Wiz Khalifa.mp3", 1, 0, "NotLiked", "Maroon 5 Ft. Wiz Khalifa", "Seeder" },
                    { 60, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3147), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3147), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\MHW ICEBORNE Safi Jiiva Battle Theme OST.mp3", 1, 0, "NotLiked", "MHW ICEBORNE Safi Jiiva Battle Theme OST", "Seeder" },
                    { 61, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3149), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3149), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\MIC Drop (Steve Aoki Remix) Official MV.mp3", 1, 0, "NotLiked", "MIC Drop (Steve Aoki Remix) Official MV", "Seeder" },
                    { 62, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3151), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3151), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Migos - Get Right Witcha (G-REX X TOP $HELF Remix).mp3", 1, 0, "NotLiked", "Migos - Get Right Witcha (G-REX X TOP $HELF Remix)", "Seeder" },
                    { 63, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3153), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3154), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura.mp3", 1, 0, "NotLiked", "MODEL DLMMD Ai no Uta 愛の詩YYB Miku Futura", "Seeder" },
                    { 64, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3155), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3156), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Moonlight.mp3", 1, 0, "NotLiked", "Moonlight", "Seeder" },
                    { 65, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3158), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3158), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records.mp3", 1, 0, "NotLiked", "Most Outstanding OST of All Time Rokudenashi Majutsu Koushi to Akashic Records", "Seeder" },
                    { 66, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3162), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3162), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Mrs. GREEN APPLE - インフェルノInferno.mp3", 1, 0, "NotLiked", "Mrs. GREEN APPLE - インフェルノInferno", "Seeder" },
                    { 67, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3164), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3164), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2).mp3", 1, 0, "NotLiked", "My Hero Academia OST - You Say Run + Jet Set Run (You Say Run v2)", "Seeder" },
                    { 68, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3166), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3167), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version).mp3", 1, 0, "NotLiked", "My Hero Academia Season 4 OST - Deku vs. Overhaul (Edited Version)", "Seeder" },
                    { 69, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3168), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3169), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Namirin  - Renai Circulation「恋愛サーキュレーショ.mp3", 1, 0, "NotLiked", "Namirin  - Renai Circulation「恋愛サーキュレーショ", "Seeder" },
                    { 70, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3171), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3171), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Nanatsu no Taizai S2 - Escanor Theme (Rearrangement).mp3", 1, 0, "NotLiked", "Nanatsu no Taizai S2 - Escanor Theme (Rearrangement)", "Seeder" },
                    { 71, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3173), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3173), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\NEFFEX - Fight Back.mp3", 1, 0, "NotLiked", "NEFFEX - Fight Back", "Seeder" },
                    { 72, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3174), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3175), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\NEFFEX - Myself.mp3", 1, 0, "NotLiked", "NEFFEX - Myself", "Seeder" },
                    { 73, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3177), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3177), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro).mp3", 1, 0, "NotLiked", "Neon Dreams - High (feat. Waka Flocka Flame & Dylan Guthro)", "Seeder" },
                    { 74, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3181), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3182), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Nightcore - Control.mp3", 1, 0, "NotLiked", "Nightcore - Control", "Seeder" },
                    { 75, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3184), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3184), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Nightcore - Rockefeller Street.mp3", 1, 0, "NotLiked", "Nightcore - Rockefeller Street", "Seeder" },
                    { 76, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3186), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3186), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\No Game No Life Opening Full.mp3", 1, 0, "NotLiked", "No Game No Life Opening Full", "Seeder" },
                    { 77, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3188), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3188), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Not Today Official MV.mp3", 1, 0, "NotLiked", "Not Today Official MV", "Seeder" },
                    { 78, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3190), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3190), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Nto - Trauma (Worakls Remix).mp3", 1, 0, "NotLiked", "Nto - Trauma (Worakls Remix)", "Seeder" },
                    { 79, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3231), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3232), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Owari no Seraph OST - 1hundredknight M [終わりのセラフ].mp3", 1, 0, "NotLiked", "Owari no Seraph OST - 1hundredknight M [終わりのセラフ]", "Seeder" },
                    { 80, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3233), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3234), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack.mp3", 1, 0, "NotLiked", "Portals Theme Doom Eternal Ancient Gods Part 2 Soundtrack", "Seeder" },
                    { 81, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3236), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3236), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Post Malone - Better Now.mp3", 1, 0, "NotLiked", "Post Malone - Better Now", "Seeder" },
                    { 82, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3238), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3238), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Post Malone_ 21 Savage - Rockstar.mp3", 1, 0, "NotLiked", "Post Malone_ 21 Savage - Rockstar", "Seeder" },
                    { 83, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3240), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3240), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Reverse feat. G-Eazy.mp3", 1, 0, "NotLiked", "Reverse feat. G-Eazy", "Seeder" },
                    { 84, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3242), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3242), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Rich The Kid - Plug Walk (Audio).mp3", 1, 0, "NotLiked", "Rich The Kid - Plug Walk (Audio)", "Seeder" },
                    { 85, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3244), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3245), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Right Now.mp3", 1, 0, "NotLiked", "Right Now", "Seeder" },
                    { 86, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3247), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3247), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends.mp3", 1, 0, "NotLiked", "RISE (ft. The Glitch Mob, Mako, and The Word Alive) Worlds 2018 - League of Legends", "Seeder" },
                    { 87, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3249), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3250), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST.mp3", 1, 0, "NotLiked", "Saber Alter vs Berserker Theme - Fatestay Night Movie Heaven's Feel II. Lost Butterfly OST", "Seeder" },
                    { 88, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3252), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3252), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\SAD!.mp3", 1, 0, "NotLiked", "SAD!", "Seeder" },
                    { 89, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3255), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3256), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Saijaku Muhai no Bahamut  - Saijaku Muhai OST.mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut  - Saijaku Muhai OST", "Seeder" },
                    { 90, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3258), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3259), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only).mp3", 1, 0, "NotLiked", "Saijaku Muhai no Bahamut Opening Hiryuu no Kishi - Extended(Sound only)", "Seeder" },
                    { 91, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3260), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3261), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sakura - 落ち着いて冷やす.mp3", 1, 0, "NotLiked", "Sakura - 落ち着いて冷やす", "Seeder" },
                    { 92, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3263), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3263), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\SAMAHTA - graffiti (feat. Melody Federer).mp3", 1, 0, "NotLiked", "SAMAHTA - graffiti (feat. Melody Federer)", "Seeder" },
                    { 93, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3265), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3266), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Seishun Buta Yarou wa Bunny Girl Senpai no Yume wo Minai ED [Part Section]Fukashigi no Carte", "Seeder" },
                    { 94, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3268), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3268), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Shawn Mendes - Mercy.mp3", 1, 0, "NotLiked", "Shawn Mendes - Mercy", "Seeder" },
                    { 95, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3270), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3270), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Shawn Mendes - Stitches.mp3", 1, 0, "NotLiked", "Shawn Mendes - Stitches", "Seeder" },
                    { 96, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3272), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3273), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Shawn Mendes - Theres Nothing Holdin Me Back.mp3", 1, 0, "NotLiked", "Shawn Mendes - Theres Nothing Holdin Me Back", "Seeder" },
                    { 97, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3274), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3275), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Shawn Mendes - Treat You Better.mp3", 1, 0, "NotLiked", "Shawn Mendes - Treat You Better", "Seeder" },
                    { 98, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3276), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3277), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sheck Wes - Mo Bamba.mp3", 1, 0, "NotLiked", "Sheck Wes - Mo Bamba", "Seeder" },
                    { 99, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3279), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3279), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte.mp3", 1, 0, "NotLiked", "Shoko Makinohara ED Solo FULL 牧之原 翔子 ソロ - 不可思議のカルテ Fukashigi no Carte", "Seeder" },
                    { 100, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3281), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3281), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sickick - Infected.mp3", 1, 0, "NotLiked", "Sickick - Infected", "Seeder" },
                    { 101, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3283), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3283), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sickick - Mind Games.mp3", 1, 0, "NotLiked", "Sickick - Mind Games", "Seeder" },
                    { 102, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3285), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3285), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\SickickMusic - Lost My Way.mp3", 1, 0, "NotLiked", "SickickMusic - Lost My Way", "Seeder" },
                    { 103, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3287), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3288), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Skan & Krale - No Glory (feat. M.I.M.E & Drama B).mp3", 1, 0, "NotLiked", "Skan & Krale - No Glory (feat. M.I.M.E & Drama B)", "Seeder" },
                    { 104, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3289), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3290), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW.mp3", 1, 0, "NotLiked", "SKI MASK THE SLUMP GOD x LIL PUMP - WHERE'S THE BLOW", "Seeder" },
                    { 105, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3292), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3292), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\SKRILLEX - Bangarang feat. Sirah.mp3", 1, 0, "NotLiked", "SKRILLEX - Bangarang feat. Sirah", "Seeder" },
                    { 106, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3294), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3294), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix).mp3", 1, 0, "NotLiked", "Slim Jesus - Drill Time (T-Mass & Wildfellaz Remix)", "Seeder" },
                    { 107, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3296), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3296), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Soredemo sekai wa utsukushii - Beautiful rain full ver..mp3", 1, 0, "NotLiked", "Soredemo sekai wa utsukushii - Beautiful rain full ver.", "Seeder" },
                    { 108, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3298), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3299), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna].mp3", 1, 0, "NotLiked", "Soredemo sekai wa Utsukushii - [Beautiful World - Koike Joanna]", "Seeder" },
                    { 109, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3300), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3301), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\STéLOUSE - Sociopath (feat. Bryce Fox).mp3", 1, 0, "NotLiked", "STéLOUSE - Sociopath (feat. Bryce Fox)", "Seeder" },
                    { 110, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3302), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3303), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sufian Suhaimi - Di Matamu.mp3", 1, 0, "NotLiked", "Sufian Suhaimi - Di Matamu", "Seeder" },
                    { 111, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3305), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3305), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization - War of Underworld Ending FullLiSA - unlasting", "Seeder" },
                    { 112, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3307), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3308), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub.mp3", 1, 0, "NotLiked", "Sword Art Online Alicization Opening FullLiSA - ADAMASENG Sub", "Seeder" },
                    { 113, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3310), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3310), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION.mp3", 1, 0, "NotLiked", "Tengen Toppa Gurren Lagann OST Sorairo Days FULL VERSION", "Seeder" },
                    { 114, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3312), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3312), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\TETRA-FANG - Supernova.mp3", 1, 0, "NotLiked", "TETRA-FANG - Supernova", "Seeder" },
                    { 115, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3314), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3315), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\The Mirza - Lelah Mengalah.mp3", 1, 0, "NotLiked", "The Mirza - Lelah Mengalah", "Seeder" },
                    { 116, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3316), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3317), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\The Soul of Wind -  🗻 The Mountains 🗻.mp3", 1, 0, "NotLiked", "The Soul of Wind -  🗻 The Mountains 🗻", "Seeder" },
                    { 117, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3318), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3319), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\TheFatRat - Fly Away feat. Anjulie.mp3", 1, 0, "NotLiked", "TheFatRat - Fly Away feat. Anjulie", "Seeder" },
                    { 118, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3360), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3361), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\TheFatRat - Monody (feat. Laura Brehm).mp3", 1, 0, "NotLiked", "TheFatRat - Monody (feat. Laura Brehm)", "Seeder" },
                    { 119, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3363), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3363), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\TheFatRat - Time Lapse.mp3", 1, 0, "NotLiked", "TheFatRat - Time Lapse", "Seeder" },
                    { 120, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3365), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3366), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\TheFatRat - Unity.mp3", 1, 0, "NotLiked", "TheFatRat - Unity", "Seeder" },
                    { 121, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3367), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3368), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\TIIMO - Bangin In the Club.mp3", 1, 0, "NotLiked", "TIIMO - Bangin In the Club", "Seeder" },
                    { 122, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3369), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3370), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-].mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Glassy Sky [東京喰種 -トーキョーグール-]", "Seeder" },
                    { 123, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3372), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3372), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Unravel (Marco B. Remix).mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (Marco B. Remix)", "Seeder" },
                    { 124, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3374), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3374), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Unravel (OP Piano) .mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel (OP Piano) ", "Seeder" },
                    { 125, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3375), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3376), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Unravel 2.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel 2", "Seeder" },
                    { 126, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3377), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3378), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tokyo Ghoul - Unravel.mp3", 1, 0, "NotLiked", "Tokyo Ghoul - Unravel", "Seeder" },
                    { 127, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3380), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3380), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Tokyo Machine - FLY [Monstercat Release].mp3", 1, 0, "NotLiked", "Tokyo Machine - FLY [Monstercat Release]", "Seeder" },
                    { 128, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3382), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3383), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Trapcity - Dead To Me (feat. Lox Chatterbox).mp3", 1, 0, "NotLiked", "Trapcity - Dead To Me (feat. Lox Chatterbox)", "Seeder" },
                    { 129, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3384), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3385), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Trapcity - Samurai☯ Lofi.mp3", 1, 0, "NotLiked", "Trapcity - Samurai☯ Lofi", "Seeder" },
                    { 130, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3388), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3388), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Trapcity - Trap Queen (Crankdat Remix).mp3", 1, 0, "NotLiked", "Trapcity - Trap Queen (Crankdat Remix)", "Seeder" },
                    { 131, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3390), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3390), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Travis Scott - SICKO MODE.mp3", 1, 0, "NotLiked", "Travis Scott - SICKO MODE", "Seeder" },
                    { 132, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3392), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3392), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Two Feet - I Feel Like Im Drowning.mp3", 1, 0, "NotLiked", "Two Feet - I Feel Like Im Drowning", "Seeder" },
                    { 133, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3394), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3395), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Unlike Pluto ft. Mike Taylor - Everything Black.mp3", 1, 0, "NotLiked", "Unlike Pluto ft. Mike Taylor - Everything Black", "Seeder" },
                    { 134, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3396), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3397), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Wishing Lyrics Rem(minase inori) ReZero.mp3", 1, 0, "NotLiked", "Wishing Lyrics Rem(minase inori) ReZero", "Seeder" },
                    { 135, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3398), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3399), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\XXXTENTACION - BAD!.mp3", 1, 0, "NotLiked", "XXXTENTACION - BAD!", "Seeder" },
                    { 136, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3401), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3402), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics].mp3", 1, 0, "NotLiked", "Yama-春を告げる(Haru wo tsugeru) [KanjiRomajiEnglish Lyrics]", "Seeder" },
                    { 137, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3403), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3404), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Yasuha - Flyday Chinatown.mp3", 1, 0, "NotLiked", "Yasuha - Flyday Chinatown", "Seeder" },
                    { 138, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3405), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3405), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\YOASOBI 夜に駆ける English & Romanji Lyrics.mp3", 1, 0, "NotLiked", "YOASOBI 夜に駆ける English & Romanji Lyrics", "Seeder" },
                    { 139, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3407), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3408), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\YOASOBIハルジオンOfficial Music Video.mp3", 1, 0, "NotLiked", "YOASOBIハルジオンOfficial Music Video", "Seeder" },
                    { 140, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3409), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3410), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Yuna - Longing.mp3", 1, 0, "NotLiked", "Yuna - Longing", "Seeder" },
                    { 141, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3411), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3412), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\Yuna - Smile for you .mp3", 1, 0, "NotLiked", "Yuna - Smile for you ", "Seeder" },
                    { 142, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3413), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3414), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\タイニーリトルアシアンタム.mp3", 1, 0, "NotLiked", "タイニーリトルアシアンタム", "Seeder" },
                    { 143, 1, 1, null, "Seeder", new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3415), new DateTime(2025, 1, 28, 1, 10, 36, 614, DateTimeKind.Local).AddTicks(3416), new TimeSpan(0, 0, 0, 0, 0), "C:\\Users\\ghost\\Source\\Repos\\glpgpro\\Pancake_Final_Group09\\Pancake_Final\\wwwroot\\music\\レペゼン地球66thシングルO2MEN.mp3", 1, 0, "NotLiked", "レペゼン地球66thシングルO2MEN", "Seeder" }
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
