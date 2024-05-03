using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TRA.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedByName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MachineName = table.Column<string>(type: "text", nullable: false),
                    Logged = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Level = table.Column<string>(type: "text", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    Logger = table.Column<string>(type: "text", nullable: false),
                    Callsite = table.Column<string>(type: "text", nullable: false),
                    Exception = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Picture = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    FirstName = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    UserName = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    About = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    YoutubeLink = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    TwitterLink = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    InstagramLink = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    FacebookLink = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    WebsiteLink = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "character varying(600)", maxLength: 600, nullable: false),
                    Place = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Thumbnail = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ViewCount = table.Column<int>(type: "integer", nullable: false),
                    CommentCount = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    IsPinned = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedByName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LoginProvider = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikedItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostId = table.Column<int>(type: "integer", nullable: false),
                    IsLiked = table.Column<bool>(type: "boolean", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedByName = table.Column<string>(type: "text", nullable: false),
                    ModifiedByName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikedItems_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikedItems_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikedItems_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    PostId = table.Column<int>(type: "integer", nullable: false),
                    LikedItemId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedByName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_LikedItems_LikedItemId",
                        column: x => x.LikedItemId,
                        principalTable: "LikedItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(105), "Hiking routes and experiences", true, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(106), "Hiking" },
                    { 2, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(108), "Cycling routes and experiences", true, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(109), "Bicycle" },
                    { 3, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(111), "Driving routes and experiences", true, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(111), "Drive" },
                    { 4, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(113), "Kayaking routes and experiences", true, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(114), "Kayak" },
                    { 5, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(116), "Skiing routes and experiences", true, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(116), "Ski" },
                    { 6, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(118), "Water Skiing routes and experiences", true, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(119), "Water Ski" },
                    { 7, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(120), "Swimming routes and experiences", true, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(121), "Swim" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FacebookLink", "FirstName", "InstagramLink", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwitterLink", "TwoFactorEnabled", "UserName", "WebsiteLink", "YoutubeLink" },
                values: new object[,]
                {
                    { 1, "Admin User of Travel App", 0, "5a791862-0eef-4073-aa99-22ab70535ce4", "adminuser@gmail.com", true, "https://facebook.com/adminuser", "Admin", "https://instagram.com/adminuser", "User", false, null, "ADMINUSER@GMAIL.COM", "ADMINUSER", "AQAAAAIAAYagAAAAEEwDhAu1/MJIaHcKiS8F8fh26dKHJ19Q+wYF7q29gvvs/rTnZmEGstB/7HStNFOOsw==", "+905555555555", true, "img/userImages/defaultUser.png", "fb1d61ed-2e21-46b7-b007-f6f2080814f5", "https://twitter.com/adminuser", false, "adminuser", "https://programmersblog.com/", "https://youtube.com/adminuser" },
                    { 2, "Editor User of ProgrammersBlog", 0, "7ebf0da8-d02a-460d-8d31-1061ec9e2add", "editoruser@gmail.com", true, "https://facebook.com/editoruser", "Admin", "https://instagram.com/editoruser", "User", false, null, "EDITORUSER@GMAIL.COM", "EDITORUSER", "AQAAAAIAAYagAAAAEFnKa+2qWqDPbMfEYnpsU0TjtEftsHu7Re+zRb21DaS9eiEpRHUo4eCWGARaSbIpqA==", "+905555555555", true, "img/userImages/defaultUser.png", "29edf36b-727c-4457-a191-1048d6789abc", "https://twitter.com/editoruser", false, "editoruser", "https://programmersblog.com/", "https://youtube.com/editoruser" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "IsActive", "IsDeleted", "IsPinned", "ModifiedByName", "ModifiedDate", "Place", "Thumbnail", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { 1, 1, 0, "Camino de Santiago is a collection of ancient pilgrimage routes that converge at the Santiago de Compostela Cathedral in northwest Spain, the burial site of St. James. Some pilgrims carry a scallop shell during the journey, as its lines symbolize their own trek, and those of other pilgrims around the world. This is another long-distance adventure — to do the approximately 500-mile route in full may take 30 days or more.", "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8800), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8798), true, false, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8800), "Spain", "img/postImages/defaultThumbnail.jpg", "Hiking trail in Spain", 1, 0 },
                    { 2, 2, 0, "This cycling tour takes you along the Ourthe River from its mouth into the Meuse in Liège to Vieuxville and back. Highlights include cycling paths along the river bank, quiet climbs with views across the Condroz and Ardennes, the view at Roche au Faucons (last few meters access on foot only), and the rock faces at the river near Sy. The route uses RAVeL cycling paths along the river banks, but also includes climbs on both sides of the valley with great views.", "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8807), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8806), true, false, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8807), "Belgium", "img/postImages/defaultThumbnail.jpg", "Bicycle route in Belgium", 1, 0 },
                    { 3, 3, 0, "In terms of a best directon of travel, the Grossglockner pass is so good, it really doesnt matter which way you drive it.  We tend to prefer an approach from the south, as the rise up to the summit is longer and more sweeping, so that bit more fun to drive.  Having said that, it tends to be more popular going the other way, as people make their way south from Germany, through Austria and into the Dolomites, just south of the pass.", "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8810), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8810), true, false, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8811), "Austria", "img/postImages/defaultThumbnail.jpg", "Driving route in Austria", 1, 0 },
                    { 4, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas porttitor iaculis nisl a ultrices. Vivamus non aliquet ante, sit amet malesuada risus. Nunc sollicitudin sed ante vel bibendum. Etiam vehicula faucibus lacus, efficitur porta dui auctor vitae. Proin auctor dapibus ligula. Quisque dignissim tincidunt lectus tempus auctor. Morbi suscipit facilisis lorem, ac lacinia quam venenatis quis. Curabitur accumsan dui nec dui.", "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8814), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8813), true, false, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8814), "Canada", "img/postImages/defaultThumbnail.jpg", "Kayaking spot in Canada", 1, 1 },
                    { 5, 5, 2, "In volutpat luctus finibus. Cras pulvinar, mi in elementum congue, quam quam ultrices enim, id dictum nunc nisl a ex. Proin convallis suscipit venenatis. Duis mattis eu lacus eget interdum. Etiam tincidunt, justo convallis pretium posuere, nibh orci tincidunt ligula, non pulvinar elit diam vel nibh. Fusce vel maximus mi.", "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8817), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8816), true, false, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8818), "France", "img/postImages/defaultThumbnail.jpg", "Skiing place in France", 1, 2 },
                    { 6, 6, 1, "Suspendisse dolor odio, dapibus eget risus ut, interdum porttitor felis. In nulla magna, commodo ac faucibus eget, pretium sit amet arcu. Integer odio ante, dapibus aliquam congue at, viverra at lectus. Pellentesque sit amet elementum mi. Phasellus purus urna, aliquam id metus et, sagittis faucibus nisi.", "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8820), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8819), true, false, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8821), "Turkey", "img/postImages/defaultThumbnail.jpg", "Water Skii in Turkey", 1, 2 },
                    { 7, 7, 2, "Aliquam erat volutpat. Etiam vitae auctor tellus, vel cursus mi. Integer ex eros, bibendum ac luctus ut, condimentum eu nibh. Etiam nibh neque, consectetur sed augue eu, lacinia lobortis ante. Integer ut molestie nunc.", "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8824), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8823), true, false, false, "InitialCreate", new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8824), "Greece", "img/postImages/defaultThumbnail.jpg", "Swimming areas in Greece", 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_LikedItemId",
                table: "Comments",
                column: "LikedItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedItems_CategoryId",
                table: "LikedItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedItems_PostId",
                table: "LikedItems",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedItems_UserId",
                table: "LikedItems",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "LikedItems");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
