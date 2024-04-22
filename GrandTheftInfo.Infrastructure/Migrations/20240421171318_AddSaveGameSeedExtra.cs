using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrandTheftInfo.Infrastructure.Migrations
{
    public partial class AddSaveGameSeedExtra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c587c054-fd8a-4638-955f-7f2427990c5a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffd97e69-bf4e-452c-9a20-45e8a539eddc");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "SaveGames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b716d45e-9ce1-4c6f-941c-179c769c398c", 0, "368cb798-be1e-4894-87a3-707e45374207", new DateTime(2024, 4, 21, 20, 13, 18, 473, DateTimeKind.Local).AddTicks(3022), null, "ApplicationUser", "guest@mail.com", false, "Guest", false, "Guestov", false, null, "Guestov", new DateTime(2024, 4, 21, 20, 13, 18, 473, DateTimeKind.Local).AddTicks(3055), "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEDI/ZptQiaDCPCYpP77m3jR3GF24s/L0Ug2KXhYHl0euDOL6WH8AByjSzB27T+gz2g==", null, false, "36b6b4d1-73cd-48d1-af36-444aef95ceca", false, "guest@mail.com" },
                    { "c830173a-5a63-4252-afdb-c362be52c30c", 0, "8f9d5be0-3590-4954-9025-9543dbedcd4a", new DateTime(2024, 4, 21, 20, 13, 18, 474, DateTimeKind.Local).AddTicks(2673), null, "ApplicationUser", "admin@mail.com", false, "Great", false, "Admin", false, null, "Adminov", new DateTime(2024, 4, 21, 20, 13, 18, 474, DateTimeKind.Local).AddTicks(2675), "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEB2r3YDChnL7imyowrbtxUtxRj870ZwX1z12LwAltlcdzV7cb44bDAnjBrel6SBdkw==", null, false, "0d97891d-cee7-4746-a44d-7c688b31bd47", false, "admin@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "SaveGames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BlobUri", "GameId", "UploadDate" },
                values: new object[] { "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test1.rar", 1, new DateTime(2024, 4, 21, 20, 13, 18, 484, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.InsertData(
                table: "SaveGames",
                columns: new[] { "Id", "BlobUri", "Description", "FileName", "GameId", "UploadDate" },
                values: new object[] { 2, "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test2.rar", "Niko Max Missions ALL", "test2", 2, new DateTime(2024, 4, 21, 20, 13, 18, 484, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.CreateIndex(
                name: "IX_SaveGames_GameId",
                table: "SaveGames",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_SaveGames_Games_GameId",
                table: "SaveGames",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaveGames_Games_GameId",
                table: "SaveGames");

            migrationBuilder.DropIndex(
                name: "IX_SaveGames_GameId",
                table: "SaveGames");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b716d45e-9ce1-4c6f-941c-179c769c398c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c830173a-5a63-4252-afdb-c362be52c30c");

            migrationBuilder.DeleteData(
                table: "SaveGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "SaveGames");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c587c054-fd8a-4638-955f-7f2427990c5a", 0, "4db079a4-67e5-4703-9855-defffb1063af", new DateTime(2024, 4, 21, 13, 50, 4, 29, DateTimeKind.Local).AddTicks(3852), null, "ApplicationUser", "guest@mail.com", false, "Guest", false, "Guestov", false, null, "Guestov", new DateTime(2024, 4, 21, 13, 50, 4, 29, DateTimeKind.Local).AddTicks(3892), "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEN2OsoCo53AiHriz03ERgwlIfcCK8l1akwJLm7j7PIdOCM/ln+Gj5Zhd0c/Fr6H3lw==", null, false, "161016c0-d712-4dd3-903a-d5c667d90f99", false, "guest@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ffd97e69-bf4e-452c-9a20-45e8a539eddc", 0, "2b16b0e5-6de5-4a28-981e-866d4f52df04", new DateTime(2024, 4, 21, 13, 50, 4, 30, DateTimeKind.Local).AddTicks(3538), null, "ApplicationUser", "admin@mail.com", false, "Great", false, "Admin", false, null, "Adminov", new DateTime(2024, 4, 21, 13, 50, 4, 30, DateTimeKind.Local).AddTicks(3540), "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAENb2rlBIGlLBzEuhqCF5hg8ns8MTJ8v3ZUV+QQC6MVBJkRrs8xfKvpzLcxzvAw4HyQ==", null, false, "44a06930-e7c3-40e2-a4be-55c5fbc6f3c5", false, "admin@mail.com" });

            migrationBuilder.UpdateData(
                table: "SaveGames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BlobUri", "UploadDate" },
                values: new object[] { "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test.rar", new DateTime(2024, 4, 21, 13, 50, 4, 41, DateTimeKind.Local).AddTicks(632) });
        }
    }
}
