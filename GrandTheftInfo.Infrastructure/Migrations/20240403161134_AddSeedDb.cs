using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrandTheftInfo.Infrastructure.Migrations
{
    public partial class AddSeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameName",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "GameName",
                table: "Cheats");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Missions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Cheats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "08a5c2c2-e783-4bca-ab20-430b199572fe", new DateTime(2024, 4, 3, 19, 11, 33, 888, DateTimeKind.Local).AddTicks(8026), null, "ApplicationUser", "guest@mail.com", false, "Guest", false, "Guestov", false, null, "Guestov", new DateTime(2024, 4, 3, 19, 11, 33, 888, DateTimeKind.Local).AddTicks(8064), "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEPwwOp87caqqjCVstXBda5TBz9VGBlyhCfVmzZs4QYLwuRVpvXs4HaPXegSIphpojg==", null, false, "f08bbb52-a9a4-46ab-ab45-51c4066f17c3", false, "guest@mail.com" },
                    { "e43ce836-997d-4927-ac59-74e8c41bbfd3", 0, "96b876f1-c501-4834-9a01-aee19a8a3a6d", new DateTime(2024, 4, 3, 19, 11, 33, 889, DateTimeKind.Local).AddTicks(7743), null, "ApplicationUser", "admin@mail.com", false, "Great", false, "Admin", false, null, "Adminov", new DateTime(2024, 4, 3, 19, 11, 33, 889, DateTimeKind.Local).AddTicks(7745), "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEBW0ovLk4dM/IO1QBGMT4YZXFQQhdjoLQ68f+0nRXaOsXqWRmJdwGHa1z6/lm3bm+g==", null, false, "32f8a789-5a76-4e70-bc31-9aab52ab8998", false, "admin@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Cheats",
                columns: new[] { "Id", "CheatCode", "GameId", "Name" },
                values: new object[,]
                {
                    { 1, "HESOYAM", 1, "Money cheat" },
                    { 2, "AEZAKMI", 1, "No police" },
                    { 3, "BAGUVIX", 1, "God mode cheat" },
                    { 4, "DEDAZNAM", 2, "Money cheat" },
                    { 5, "BALSAMGO", 2, "No police" },
                    { 6, "NIZNAM", 2, "God mode cheat" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "ImageUrl", "MissionCount", "Name", "YearPublished" },
                values: new object[,]
                {
                    { 1, "Los Santos CJ helps family take over.", "https://upload.wikimedia.org/wikipedia/en/c/c4/GTASABOX.jpg", 100, "GTA San Andreas", new DateTime(2004, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Niko helps cousing in Liberty City", "https://upload.wikimedia.org/wikipedia/en/b/b7/Grand_Theft_Auto_IV_cover.jpg", 69, "GTA IV", new DateTime(2008, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "Id", "Description", "GameId", "Name", "PlaytroughUrl" },
                values: new object[,]
                {
                    { 1, "Ride bikes", 1, "First SA Mission", "http://google.com" },
                    { 2, "Kill ballas", 1, "Second SA Mission", "http://google2.com" },
                    { 3, "Help cousing", 2, "First GTA 4 Mission", "http://google3.com" },
                    { 4, "Save cousing", 2, "Second GTA 4 Mission", "http://google4.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3");

            migrationBuilder.DeleteData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Cheats");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "GameName",
                table: "Missions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GameName",
                table: "Cheats",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
