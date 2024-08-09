using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TRA.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_LikedItems_LikedItemId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "LikedItems");

            migrationBuilder.DropIndex(
                name: "IX_Comments_LikedItemId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "LikedItemId",
                table: "Comments");

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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8131), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8134), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8137), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8139), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8142), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8144), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8147), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6893), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6892), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6929), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6928), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6934), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6933), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6937), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6936), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6941), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6940), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6944), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6943), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6948), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6947), new DateTime(2024, 8, 9, 10, 36, 18, 878, DateTimeKind.Utc).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f488d5cc-28f7-48ce-874d-66bdcc027a7b", "AQAAAAIAAYagAAAAEOcNPnvNHBrHm+L5fMqcZrOiGSQnt2rtIyC9GhV12IIJK2T1Abh03cz+WWAmLGHoVw==", "07c2c19f-d609-4efa-a8da-4e19cadc81b7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6824d04-2991-43a5-90ae-db7ddbdfa5e7", "AQAAAAIAAYagAAAAEEpvIWBI1143cijOosR/OMvH++ABqJ/gYvlrOcUavkDcxl58Oelo5EjYTw+ZIj26XQ==", "67fddc4c-d86a-4149-b627-9553d3fceabf" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Follows");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.AddColumn<int>(
                name: "LikedItemId",
                table: "Comments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LikedItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    PostId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedByName = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsLiked = table.Column<bool>(type: "boolean", nullable: false),
                    ModifiedByName = table.Column<string>(type: "text", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(105), new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(108), new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(111), new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(113), new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(116), new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(118), new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 4, 21, 21, 25, 23, 289, DateTimeKind.Utc).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8800), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8798), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8807), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8806), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8810), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8810), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8814), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8813), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8817), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8816), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8820), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8819), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8824), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8823), new DateTime(2024, 4, 21, 21, 25, 23, 288, DateTimeKind.Utc).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a791862-0eef-4073-aa99-22ab70535ce4", "AQAAAAIAAYagAAAAEEwDhAu1/MJIaHcKiS8F8fh26dKHJ19Q+wYF7q29gvvs/rTnZmEGstB/7HStNFOOsw==", "fb1d61ed-2e21-46b7-b007-f6f2080814f5" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ebf0da8-d02a-460d-8d31-1061ec9e2add", "AQAAAAIAAYagAAAAEFnKa+2qWqDPbMfEYnpsU0TjtEftsHu7Re+zRb21DaS9eiEpRHUo4eCWGARaSbIpqA==", "29edf36b-727c-4457-a191-1048d6789abc" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_LikedItemId",
                table: "Comments",
                column: "LikedItemId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_LikedItems_LikedItemId",
                table: "Comments",
                column: "LikedItemId",
                principalTable: "LikedItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
