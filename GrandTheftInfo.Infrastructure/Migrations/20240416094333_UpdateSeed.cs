using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrandTheftInfo.Infrastructure.Migrations
{
    public partial class UpdateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3");

            migrationBuilder.DropColumn(
                name: "MissionCount",
                table: "Games");

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "Cheats",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "77d7b30a-b6a2-4bee-b28d-ee9633edccb4", 0, "4e488824-abb6-4087-8d48-7648e375d194", new DateTime(2024, 4, 16, 12, 43, 33, 293, DateTimeKind.Local).AddTicks(6801), null, "ApplicationUser", "guest@mail.com", false, "Guest", false, "Guestov", false, null, "Guestov", new DateTime(2024, 4, 16, 12, 43, 33, 293, DateTimeKind.Local).AddTicks(6841), "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEGrgT3VBRetYAMIODCIpKS9zUa/pLsf6S4MIclxFb0ZH4YgUoHcwF+EeCpss21Qujg==", null, false, "5d6aa6e6-a1c2-4c8e-88f4-a3fc48ea6c0a", false, "guest@mail.com" },
                    { "9c50d1a8-bcd9-4146-8388-b050b12d74bd", 0, "727976f8-4daf-4e68-aa27-ce62629aa768", new DateTime(2024, 4, 16, 12, 43, 33, 294, DateTimeKind.Local).AddTicks(6483), null, "ApplicationUser", "admin@mail.com", false, "Great", false, "Admin", false, null, "Adminov", new DateTime(2024, 4, 16, 12, 43, 33, 294, DateTimeKind.Local).AddTicks(6485), "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEF3UiXSU2kIvOMbgTqBKgRG935BNWd2uJ+sK+T/ur06KQ73uMVDZNsLXFsAp2qaJ2Q==", null, false, "b9a18838-c35b-4212-9dab-15b65ee9d2a6", false, "admin@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Platform",
                value: "PC");

            migrationBuilder.UpdateData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 2,
                column: "Platform",
                value: "PC");

            migrationBuilder.UpdateData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Platform",
                value: "PC");

            migrationBuilder.UpdateData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 4,
                column: "Platform",
                value: "PC");

            migrationBuilder.UpdateData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 5,
                column: "Platform",
                value: "PC");

            migrationBuilder.UpdateData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 6,
                column: "Platform",
                value: "PC");

            migrationBuilder.InsertData(
                table: "Cheats",
                columns: new[] { "Id", "CheatCode", "GameId", "Name", "Platform" },
                values: new object[,]
                {
                    { 7, "Down, X, Right, Left, Right, R1, Right, Down, Up, Triangle", 1, "God mode cheat", "Playstation" },
                    { 8, "R1, R2, L1, X, LEFT, DOWN, RIGHT, UP, LEFT, DOWN, RIGHT, UP", 1, "Money cheat", "Playstation" },
                    { 9, "468-555-0100", 2, "Change weather", "Playstation" },
                    { 10, "486-555-0150", 2, "Weapons 1", "Playstation" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Missions_GameId",
                table: "Missions",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Cheats_GameId",
                table: "Cheats",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cheats_Games_GameId",
                table: "Cheats",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Games_GameId",
                table: "Missions",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cheats_Games_GameId",
                table: "Cheats");

            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Games_GameId",
                table: "Missions");

            migrationBuilder.DropIndex(
                name: "IX_Missions_GameId",
                table: "Missions");

            migrationBuilder.DropIndex(
                name: "IX_Cheats_GameId",
                table: "Cheats");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77d7b30a-b6a2-4bee-b28d-ee9633edccb4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c50d1a8-bcd9-4146-8388-b050b12d74bd");

            migrationBuilder.DeleteData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cheats",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Platform",
                table: "Cheats");

            migrationBuilder.AddColumn<int>(
                name: "MissionCount",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "08a5c2c2-e783-4bca-ab20-430b199572fe", new DateTime(2024, 4, 3, 19, 11, 33, 888, DateTimeKind.Local).AddTicks(8026), null, "ApplicationUser", "guest@mail.com", false, "Guest", false, "Guestov", false, null, "Guestov", new DateTime(2024, 4, 3, 19, 11, 33, 888, DateTimeKind.Local).AddTicks(8064), "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEPwwOp87caqqjCVstXBda5TBz9VGBlyhCfVmzZs4QYLwuRVpvXs4HaPXegSIphpojg==", null, false, "f08bbb52-a9a4-46ab-ab45-51c4066f17c3", false, "guest@mail.com" },
                    { "e43ce836-997d-4927-ac59-74e8c41bbfd3", 0, "96b876f1-c501-4834-9a01-aee19a8a3a6d", new DateTime(2024, 4, 3, 19, 11, 33, 889, DateTimeKind.Local).AddTicks(7743), null, "ApplicationUser", "admin@mail.com", false, "Great", false, "Admin", false, null, "Adminov", new DateTime(2024, 4, 3, 19, 11, 33, 889, DateTimeKind.Local).AddTicks(7745), "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEBW0ovLk4dM/IO1QBGMT4YZXFQQhdjoLQ68f+0nRXaOsXqWRmJdwGHa1z6/lm3bm+g==", null, false, "32f8a789-5a76-4e70-bc31-9aab52ab8998", false, "admin@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "MissionCount",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "MissionCount",
                value: 69);
        }
    }
}
