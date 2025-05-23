using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRA.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacebookLink",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InstagramLink",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TwitterLink",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "YoutubeLink",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Likes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CommentId",
                table: "Likes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8903), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8908), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8912), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8915), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8919), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8922), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8926), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5700), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5698), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5707), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5706), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5712), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5711), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5718), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5716), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5723), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5722), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5740), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5739), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5745), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5744), new DateTime(2025, 5, 23, 16, 42, 33, 60, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d511add9-41f5-4910-981b-f7b1b87ce211");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9315cb61-e510-48a2-ba09-13f130ad5305");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "5da2be25-e7e9-441e-b770-fba351958794");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "d1f8ccbf-ab9f-4c2f-8ddc-6a77b30b27c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "4e02be21-b1b7-4244-8ced-82ad2d1c05e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "95f7e067-051c-4a9c-a319-c44e503ef34a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "83458386-81c6-41c8-bb42-d1eafbf67d91");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "c4371684-42b6-4deb-8873-0e3d114ed65f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "6cf54b66-c0f3-4d94-9c6f-5afc275ac423");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "3f43c007-0ca3-4d45-9bf9-8bd254329173");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "fd9ab20e-423c-4348-bfde-273d1422246e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "36ff12ef-cc2d-4164-9411-0b36cdd0be0e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "44e2ae22-f7be-46a8-8a61-4bb8181d210e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "7f23c5a3-7ba0-4bcf-ae56-c3037196c068");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "a6da1616-9d87-40f6-97e1-72d6a653f196");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "8927a7c8-d548-4186-94b1-dcae51bd572a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "f5c5848a-5999-4510-ba8b-9f4b0f6da9d8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "e9ce205c-99c2-4681-8fd9-d99ca22ab675");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "103a2b8e-8fad-4fa7-aad4-d173a4ae69f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "2db22009-e94d-4304-80f7-bdac0c2b1697");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "4990b335-0069-4ad4-b0e1-0c73f56ad934");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "7dd95621-2689-460b-b269-9470be3f7698");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d32c3ea2-30f5-48b3-9408-bb7214093c4f", "AQAAAAIAAYagAAAAEK0g/gyE1vZCMOjFrqvDm3tNjazB8sxnCMckqVELfrT1uZsYBWZzaHf7Q3+pUWlQxw==", "5ff8ad74-b2ea-4690-9a5b-ae5f1756f133" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6235b59f-e69b-4f8c-a3cd-e0366784d07a", "AQAAAAIAAYagAAAAEMy8nzMgp5sK21woVnoQnt/5So5EVSLcw+CTus4ZJDrLcTBAreA28XnkUWB2HIe0/A==", "e7526b4b-6bf6-4caa-860c-c2f86a931e70" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91b83bc0-144d-4ae8-bcca-8341051aeffe", "AQAAAAIAAYagAAAAEOXkhK53YRS7HHcABB/H65N7VdC0YV9eyBp9ma4iTd+mn7F0CA8mErnnCJBRsJm19A==", "e28eaa22-120e-404b-93a8-75358de86534" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacebookLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YoutubeLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Likes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CommentId",
                table: "Likes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2378), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2382), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2384), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2387), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2389), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2391), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2394), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1036), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1033), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1041), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1040), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1047), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1045), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1050), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1049), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1054), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1053), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1057), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1056), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1061), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1060), new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "52835445-c626-4fd3-8110-15c34232730a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9b364e67-c210-4eb2-bc91-3c245da04b0e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "2c2ca3e9-ef85-49a8-b1e2-e27a295d179e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "0c4e9a64-6bd5-4752-8d18-71ebd1d58412");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "dd663ce0-6608-4f52-8258-89a2f92eb0a8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "dc650c79-ee90-4a4b-a03c-db8563497f0d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "a2731662-ca92-405b-aa9b-ba1a1bbff145");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "75f1c25c-3d0f-4832-b740-60ab368ba65c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "ee594128-c8b3-4db7-a3e2-45e31917e75f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "df129047-e098-4fd4-9366-dc0087f349a2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "e36ab727-8174-40f1-918c-ce46e0f95fee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "f2347943-ecd7-475b-accb-cc0f5903e3fe");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "621bf266-a19c-4cc2-9af8-40fb2f0e55ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "32be0e26-002a-4631-8064-354c371103d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "d00f8be7-6b0b-4bb2-bf19-daf776d0cc23");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "b6c7636b-d358-4cd6-8707-19ddf5acb79d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "b1b21f32-e3a1-473e-9f76-279cc0d9e2d1");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "b6d2bc1e-5410-4909-b58b-bf5a327b2c3b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "b41be95a-2024-4e1f-be5e-cbfbfa52a7a0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "d89bc0bd-8141-4259-bf53-effbecde0ac2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "5ce0ff2f-a738-4d77-9449-b8fc6ce403fa");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "8ade6c98-4514-4e7e-b320-8fde57b3ab6d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "FacebookLink", "InstagramLink", "PasswordHash", "SecurityStamp", "TwitterLink", "YoutubeLink" },
                values: new object[] { "09954d92-a96d-4cf2-9d01-cc88957e0ce1", "https://facebook.com/adminuser", "https://instagram.com/adminuser", "AQAAAAIAAYagAAAAEF7horcDPDvq9veDdxDlF+xoOcD4fdlQ0AQ12HK0M4j9t2Re2O9fbO6A9UFcwEp3fA==", "ece1dd0a-079a-455a-be5c-27bd48b3bb69", "https://twitter.com/adminuser", "https://youtube.com/adminuser" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "FacebookLink", "InstagramLink", "PasswordHash", "SecurityStamp", "TwitterLink", "YoutubeLink" },
                values: new object[] { "e651ec71-e2d9-4f06-a7a9-bbc97c35217b", "https://facebook.com/editoruser", "https://instagram.com/editoruser", "AQAAAAIAAYagAAAAEBgNrfbqLDTR4i4jdeFWXxJsEdwa5gv82r+Rcb5cVPfs/rvdOcVV/cQ2CjQriAt4nw==", "ee2030dd-667d-4f0f-b90a-6c723ff5b1fa", "https://twitter.com/editoruser", "https://youtube.com/editoruser" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "FacebookLink", "InstagramLink", "PasswordHash", "SecurityStamp", "TwitterLink", "YoutubeLink" },
                values: new object[] { "dfc32dac-113a-4be1-b1f6-8e9d43c6f9e0", "https://facebook.com/testuser", "https://instagram.com/testuser", "AQAAAAIAAYagAAAAEJwn22V58e/gbu8XkKO8zK+I1B6w1AfpRlTKPpN9EOwkrrDP7dc4meajtsJPTmLj8Q==", "49d25d87-7f5f-4bae-841d-25b441305401", "https://twitter.com/testuser", "https://youtube.com/testuser" });
        }
    }
}
