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
                    UserName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
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
                name: "Follows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FollowerId = table.Column<int>(type: "integer", nullable: false),
                    FolloweeId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Follows_Users_FolloweeId",
                        column: x => x.FolloweeId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Follows_Users_FollowerId",
                        column: x => x.FollowerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "character varying(600)", maxLength: 600, nullable: false),
                    Location = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Thumbnail = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Balance = table.Column<int>(type: "integer", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    Duration = table.Column<int>(type: "integer", nullable: false),
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
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    PostId = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    PostId = table.Column<int>(type: "integer", nullable: false),
                    CommentId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likes_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8109), "Hiking routes and experiences", true, false, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8110), "Hiking" },
                    { 2, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8113), "Cycling routes and experiences", true, false, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8113), "Bicycle" },
                    { 3, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8115), "Driving routes and experiences", true, false, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8116), "Drive" },
                    { 4, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8118), "Kayaking routes and experiences", true, false, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8119), "Kayak" },
                    { 5, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8121), "Skiing routes and experiences", true, false, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8121), "Ski" },
                    { 6, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8123), "Water Skiing routes and experiences", true, false, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8124), "Water Ski" },
                    { 7, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8150), "Swimming routes and experiences", true, false, "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8151), "Swim" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "788f28a4-d5ed-469a-b93b-619f90316980", "Category.Create", "CATEGORY.CREATE" },
                    { 2, "5c2d7836-67eb-44ff-8886-f908b1ba92a3", "Category.Read", "CATEGORY.READ" },
                    { 3, "ee997002-cff3-4f53-b29a-53cff4992759", "Category.Update", "CATEGORY.UPDATE" },
                    { 4, "80599c10-0b8d-40be-ae1c-38936a39850c", "Category.Delete", "CATEGORY.DELETE" },
                    { 5, "52911886-d75b-414a-9432-09b61154b061", "Post.Create", "POST.CREATE" },
                    { 6, "5d376106-d10a-4301-b88a-e580024cb170", "Post.Read", "POST.READ" },
                    { 7, "75bef8e2-91f0-4b04-a79a-0bbb0a4eae37", "Post.Update", "POST.UPDATE" },
                    { 8, "e6b35a85-3868-490f-999c-1303e3c15958", "Post.Delete", "POST.DELETE" },
                    { 9, "e486d879-c911-4712-95fd-7f8b3396fd8b", "User.Create", "USER.CREATE" },
                    { 10, "b03ebffd-77de-4e19-88b4-741d6c88a9f4", "User.Read", "USER.READ" },
                    { 11, "c5667f95-1afe-49a0-ab83-c2307adb80cb", "User.Update", "USER.UPDATE" },
                    { 12, "ff1a4075-6dc6-4e68-bcbc-c246061b57d2", "User.Delete", "USER.DELETE" },
                    { 13, "2acdbbca-8eb6-4b8f-b265-fd5b06d2b572", "Role.Create", "ROLE.CREATE" },
                    { 14, "bfdc5879-5c56-49a7-a4a8-a45c6398f2df", "Role.Read", "ROLE.READ" },
                    { 15, "ab0b42cc-927d-45e7-b5c6-2bf2885f6092", "Role.Update", "ROLE.UPDATE" },
                    { 16, "c5537b9a-a80b-4b89-b012-cd73c2843381", "Role.Delete", "ROLE.DELETE" },
                    { 17, "216de620-886f-44a0-ae63-408ea319157e", "Comment.Create", "COMMENT.CREATE" },
                    { 18, "376a59fe-d967-464c-b485-05c7ec97b165", "Comment.Read", "COMMENT.READ" },
                    { 19, "fc2eb524-f284-45ba-877b-36cfa305e1f5", "Comment.Update", "COMMENT.UPDATE" },
                    { 20, "2754769f-e909-4137-b396-fd6b5b895214", "Comment.Delete", "COMMENT.DELETE" },
                    { 21, "6249ea0e-8be7-4333-ae95-a275916b23ff", "AdminArea.Home.Read", "ADMINAREA.HOME.READ" },
                    { 22, "bb7bf276-63ac-4de0-a86e-c6958f391615", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FacebookLink", "FirstName", "InstagramLink", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Picture", "SecurityStamp", "TwitterLink", "TwoFactorEnabled", "UserName", "WebsiteLink", "YoutubeLink" },
                values: new object[,]
                {
                    { 1, "Admin User of Travel App", 0, "bba03a58-2ee8-4895-bbe8-942153bb96bf", "adminuser@gmail.com", true, "https://facebook.com/adminuser", "Admin", "https://instagram.com/adminuser", "User", false, null, "ADMINUSER@GMAIL.COM", "ADMINUSER", "AQAAAAIAAYagAAAAEOmiWX0Vb38rdBlsymTIQGvBwJx24+ZsjBcQugbg2Jh0iWYUikN95ef/A1UY1fOM0Q==", "+905555555555", true, "img/userImages/defaultUser.png", "51b5f174-1de5-47b0-bb32-c036da37242d", "https://twitter.com/adminuser", false, "adminuser", "https://travelapp.com/", "https://youtube.com/adminuser" },
                    { 2, "Editor User of Travel App", 0, "79db06cb-6ed8-47cb-922e-9210f51c93bb", "editoruser@gmail.com", true, "https://facebook.com/editoruser", "Editor", "https://instagram.com/editoruser", "User", false, null, "EDITORUSER@GMAIL.COM", "EDITORUSER", "AQAAAAIAAYagAAAAEE+3RQBGHirmt1tmhRvF0A3cDh2SRob7+WU16ON1cmZTgdH/YE3eEls56P8OMqrAYQ==", "+905555555555", true, "img/userImages/defaultUser.png", "e53d591c-bc51-4613-a23d-7b3d720af482", "https://twitter.com/editoruser", false, "editoruser", "https://travelapp.com/", "https://youtube.com/editoruser" },
                    { 3, "Test User of Travel App", 0, "7e69d38f-c593-403c-8593-21287f14a47a", "testuser@gmail.com", true, "https://facebook.com/testuser", "Test", "https://instagram.com/testuser", "User", false, null, "TESTUSER@GMAIL.COM", "TESTUSER", "AQAAAAIAAYagAAAAEBRcHtdlCWe7Amh0IFCWOZsw8HRtkWIVbCisXmC9AwzNVRtw04pW/IM12bWKOOObUQ==", "+905555555555", true, "img/userImages/defaultUser.png", "5517f5da-c216-468c-9642-84889f64fd2a", "https://twitter.com/testuser", false, "testUser", "https://travelapp.com/", "https://youtube.com/testuser" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Balance", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedDate", "Date", "Duration", "IsActive", "IsDeleted", "IsPinned", "Location", "ModifiedByName", "ModifiedDate", "Rating", "Thumbnail", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { 1, 0, 1, 0, "Camino de Santiago is a collection of ancient pilgrimage routes that converge at the Santiago de Compostela Cathedral in northwest Spain, the burial site of St. James. Some pilgrims carry a scallop shell during the journey, as its lines symbolize their own trek, and those of other pilgrims around the world. This is another long-distance adventure — to do the approximately 500-mile route in full may take 30 days or more.", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6787), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6783), 0, true, false, false, "Spain", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6788), 0, "img/postImages/defaultPostImage.jpg", "Hiking trail in Spain", 1, 0 },
                    { 2, 0, 2, 0, "This cycling tour takes you along the Ourthe River from its mouth into the Meuse in Liège to Vieuxville and back. Highlights include cycling paths along the river bank, quiet climbs with views across the Condroz and Ardennes, the view at Roche au Faucons (last few meters access on foot only), and the rock faces at the river near Sy. The route uses RAVeL cycling paths along the river banks, but also includes climbs on both sides of the valley with great views.", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6792), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6791), 0, true, false, false, "Belgium", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6793), 0, "img/postImages/defaultPostImage.jpg", "Bicycle route in Belgium", 1, 0 },
                    { 3, 0, 3, 0, "In terms of a best directon of travel, the Grossglockner pass is so good, it really doesnt matter which way you drive it.  We tend to prefer an approach from the south, as the rise up to the summit is longer and more sweeping, so that bit more fun to drive.  Having said that, it tends to be more popular going the other way, as people make their way south from Germany, through Austria and into the Dolomites, just south of the pass.", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6835), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6834), 0, true, false, false, "Austria", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6836), 0, "img/postImages/defaultPostImage.jpg", "Driving route in Austria", 1, 0 },
                    { 4, 0, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas porttitor iaculis nisl a ultrices. Vivamus non aliquet ante, sit amet malesuada risus. Nunc sollicitudin sed ante vel bibendum. Etiam vehicula faucibus lacus, efficitur porta dui auctor vitae. Proin auctor dapibus ligula. Quisque dignissim tincidunt lectus tempus auctor. Morbi suscipit facilisis lorem, ac lacinia quam venenatis quis. Curabitur accumsan dui nec dui.", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6839), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6838), 0, true, false, false, "Canada", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6840), 0, "img/postImages/defaultPostImage.jpg", "Kayaking spot in Canada", 1, 1 },
                    { 5, 0, 5, 2, "In volutpat luctus finibus. Cras pulvinar, mi in elementum congue, quam quam ultrices enim, id dictum nunc nisl a ex. Proin convallis suscipit venenatis. Duis mattis eu lacus eget interdum. Etiam tincidunt, justo convallis pretium posuere, nibh orci tincidunt ligula, non pulvinar elit diam vel nibh. Fusce vel maximus mi.", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6843), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6842), 0, true, false, false, "France", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6843), 0, "img/postImages/defaultPostImage.jpg", "Skiing place in France", 1, 2 },
                    { 6, 0, 6, 1, "Suspendisse dolor odio, dapibus eget risus ut, interdum porttitor felis. In nulla magna, commodo ac faucibus eget, pretium sit amet arcu. Integer odio ante, dapibus aliquam congue at, viverra at lectus. Pellentesque sit amet elementum mi. Phasellus purus urna, aliquam id metus et, sagittis faucibus nisi.", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6846), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6845), 0, true, false, false, "Turkey", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6846), 0, "img/postImages/defaultPostImage.jpg", "Water Skii in Turkey", 1, 2 },
                    { 7, 0, 7, 2, "Aliquam erat volutpat. Etiam vitae auctor tellus, vel cursus mi. Integer ex eros, bibendum ac luctus ut, condimentum eu nibh. Etiam nibh neque, consectetur sed augue eu, lacinia lobortis ante. Integer ut molestie nunc.", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6849), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6848), 0, true, false, false, "Greece", "InitialCreate", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6850), 0, "img/postImages/defaultPostImage.jpg", "Swimming areas in Greece", 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 1 },
                    { 16, 1 },
                    { 17, 1 },
                    { 18, 1 },
                    { 19, 1 },
                    { 20, 1 },
                    { 21, 1 },
                    { 22, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 },
                    { 17, 2 },
                    { 18, 2 },
                    { 19, 2 },
                    { 20, 2 },
                    { 21, 2 },
                    { 2, 3 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 3 },
                    { 8, 3 },
                    { 17, 3 },
                    { 18, 3 },
                    { 19, 3 },
                    { 20, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_FolloweeId",
                table: "Follows",
                column: "FolloweeId");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_FollowerId",
                table: "Follows",
                column: "FollowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_CommentId",
                table: "Likes",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_PostId",
                table: "Likes",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UserId",
                table: "Likes",
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
                name: "Follows");

            migrationBuilder.DropTable(
                name: "Likes");

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
                name: "Comments");

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
