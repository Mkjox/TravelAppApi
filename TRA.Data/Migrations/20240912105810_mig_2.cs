using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TRA.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "YoutubeLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "TwitterLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "character varying(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "InstagramLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "character varying(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FacebookLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "Users",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(1000)",
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2378), "Hiking is a journey through nature's most serene landscapes—dense forests, rugged mountain peaks, hidden waterfalls—each one rewarding your effort with a beauty that can only be discovered on foot. As the sun sets and you reach the summit, the sense of accomplishment mixes with awe, reminding you of the power of simply walking through the world’s wonders.", new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2382), "Feel the wind in your hair and the world rushing past as you glide down open roads or twisty trails on a bicycle. Whether you’re navigating through charming countryside, coasting along the beach, or zipping through bustling city streets, biking gives you a front-row seat to experience your surroundings. It’s a thrill of speed and freedom, where every turn offers a new vista, and every pedal brings you closer to your next adventure.", new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2384), "The open road stretches ahead, promising new discoveries at every bend. There’s something intoxicating about a road trip—the thrill of spontaneous detours, the soundtrack of your favorite tunes, and the freedom to explore wherever your heart desires.", new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2387), "Whether you’re navigating tranquil lakes, winding rivers, or riding the exhilarating currents of the ocean, kayaking is a personal journey into the heart of nature. As you skim over the water’s surface, you become part of the landscape, able to reach secret coves, hidden islands, and serene spots inaccessible by any other means.", new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2389), "Slicing through fresh powder as you carve your way down a snow-covered mountain is a rush like no other. Skiing is the perfect blend of adrenaline and elegance—each swoop and turn making you feel weightless as the world becomes a blur of white and blue. From high alpine peaks with panoramic views to cozy mountain resorts where hot cocoa awaits, skiing offers a thrill that lingers long after the day’s last run.", new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2391), "Feel the exhilaration as you rise out of the water, your skis skimming across the surface, and you pick up speed behind a powerful boat. Water skiing is pure adrenaline—the rush of wind in your face and the splash of water at your feet as you cut through waves. Each turn and jump offers a new challenge, a test of balance, and an opportunity to push yourself. It's the ultimate way to combine water, speed, and thrill, leaving you craving more.", new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2394), "Underneath the surface, you’re free to lose yourself in the tranquility of the underwater world or power through a refreshing workout. Swimming is both a peaceful escape and a personal challenge, offering a sense of freedom that stays with you long after you leave the water.", new DateTime(2024, 9, 12, 10, 58, 9, 526, DateTimeKind.Utc).AddTicks(2394) });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "09954d92-a96d-4cf2-9d01-cc88957e0ce1", "AQAAAAIAAYagAAAAEF7horcDPDvq9veDdxDlF+xoOcD4fdlQ0AQ12HK0M4j9t2Re2O9fbO6A9UFcwEp3fA==", "~/img/userImages/defaultUser.png", "ece1dd0a-079a-455a-be5c-27bd48b3bb69" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "e651ec71-e2d9-4f06-a7a9-bbc97c35217b", "AQAAAAIAAYagAAAAEBgNrfbqLDTR4i4jdeFWXxJsEdwa5gv82r+Rcb5cVPfs/rvdOcVV/cQ2CjQriAt4nw==", "~/img/userImages/defaultUser.png", "ee2030dd-667d-4f0f-b90a-6c723ff5b1fa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "dfc32dac-113a-4be1-b1f6-8e9d43c6f9e0", "AQAAAAIAAYagAAAAEJwn22V58e/gbu8XkKO8zK+I1B6w1AfpRlTKPpN9EOwkrrDP7dc4meajtsJPTmLj8Q==", "~/img/userImages/defaultUser.png", "49d25d87-7f5f-4bae-841d-25b441305401" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "YoutubeLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TwitterLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InstagramLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FacebookLink",
                table: "Users",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "Users",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8109), "Hiking routes and experiences", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8113), "Cycling routes and experiences", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8115), "Driving routes and experiences", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8118), "Kayaking routes and experiences", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8121), "Skiing routes and experiences", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8123), "Water Skiing routes and experiences", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8150), "Swimming routes and experiences", new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6787), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6783), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6792), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6791), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6835), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6834), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6839), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6838), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6843), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6842), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6846), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6845), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Date", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6849), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6848), new DateTime(2024, 8, 27, 16, 44, 20, 687, DateTimeKind.Utc).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "788f28a4-d5ed-469a-b93b-619f90316980");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5c2d7836-67eb-44ff-8886-f908b1ba92a3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "ee997002-cff3-4f53-b29a-53cff4992759");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "80599c10-0b8d-40be-ae1c-38936a39850c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "52911886-d75b-414a-9432-09b61154b061");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "5d376106-d10a-4301-b88a-e580024cb170");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "75bef8e2-91f0-4b04-a79a-0bbb0a4eae37");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "e6b35a85-3868-490f-999c-1303e3c15958");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "e486d879-c911-4712-95fd-7f8b3396fd8b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "b03ebffd-77de-4e19-88b4-741d6c88a9f4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "c5667f95-1afe-49a0-ab83-c2307adb80cb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "ff1a4075-6dc6-4e68-bcbc-c246061b57d2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "2acdbbca-8eb6-4b8f-b265-fd5b06d2b572");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "bfdc5879-5c56-49a7-a4a8-a45c6398f2df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "ab0b42cc-927d-45e7-b5c6-2bf2885f6092");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 16,
                column: "ConcurrencyStamp",
                value: "c5537b9a-a80b-4b89-b012-cd73c2843381");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 17,
                column: "ConcurrencyStamp",
                value: "216de620-886f-44a0-ae63-408ea319157e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 18,
                column: "ConcurrencyStamp",
                value: "376a59fe-d967-464c-b485-05c7ec97b165");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 19,
                column: "ConcurrencyStamp",
                value: "fc2eb524-f284-45ba-877b-36cfa305e1f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 20,
                column: "ConcurrencyStamp",
                value: "2754769f-e909-4137-b396-fd6b5b895214");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 21,
                column: "ConcurrencyStamp",
                value: "6249ea0e-8be7-4333-ae95-a275916b23ff");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 22,
                column: "ConcurrencyStamp",
                value: "bb7bf276-63ac-4de0-a86e-c6958f391615");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "bba03a58-2ee8-4895-bbe8-942153bb96bf", "AQAAAAIAAYagAAAAEOmiWX0Vb38rdBlsymTIQGvBwJx24+ZsjBcQugbg2Jh0iWYUikN95ef/A1UY1fOM0Q==", "img/userImages/defaultUser.png", "51b5f174-1de5-47b0-bb32-c036da37242d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "79db06cb-6ed8-47cb-922e-9210f51c93bb", "AQAAAAIAAYagAAAAEE+3RQBGHirmt1tmhRvF0A3cDh2SRob7+WU16ON1cmZTgdH/YE3eEls56P8OMqrAYQ==", "img/userImages/defaultUser.png", "e53d591c-bc51-4613-a23d-7b3d720af482" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Picture", "SecurityStamp" },
                values: new object[] { "7e69d38f-c593-403c-8593-21287f14a47a", "AQAAAAIAAYagAAAAEBRcHtdlCWe7Amh0IFCWOZsw8HRtkWIVbCisXmC9AwzNVRtw04pW/IM12bWKOOObUQ==", "img/userImages/defaultUser.png", "5517f5da-c216-468c-9642-84889f64fd2a" });
        }
    }
}
