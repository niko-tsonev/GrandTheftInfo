using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrandTheftInfo.Infrastructure.Migrations
{
    public partial class AddSaveGameSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21c8ab51-1056-4c31-8e79-c4e41c90d7fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f4bb76c-e097-485f-946d-c8631b8d253a");

            migrationBuilder.CreateTable(
                name: "SaveGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlobUri = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaveGames", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c587c054-fd8a-4638-955f-7f2427990c5a", 0, "4db079a4-67e5-4703-9855-defffb1063af", new DateTime(2024, 4, 21, 13, 50, 4, 29, DateTimeKind.Local).AddTicks(3852), null, "ApplicationUser", "guest@mail.com", false, "Guest", false, "Guestov", false, null, "Guestov", new DateTime(2024, 4, 21, 13, 50, 4, 29, DateTimeKind.Local).AddTicks(3892), "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEN2OsoCo53AiHriz03ERgwlIfcCK8l1akwJLm7j7PIdOCM/ln+Gj5Zhd0c/Fr6H3lw==", null, false, "161016c0-d712-4dd3-903a-d5c667d90f99", false, "guest@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ffd97e69-bf4e-452c-9a20-45e8a539eddc", 0, "2b16b0e5-6de5-4a28-981e-866d4f52df04", new DateTime(2024, 4, 21, 13, 50, 4, 30, DateTimeKind.Local).AddTicks(3538), null, "ApplicationUser", "admin@mail.com", false, "Great", false, "Admin", false, null, "Adminov", new DateTime(2024, 4, 21, 13, 50, 4, 30, DateTimeKind.Local).AddTicks(3540), "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAENb2rlBIGlLBzEuhqCF5hg8ns8MTJ8v3ZUV+QQC6MVBJkRrs8xfKvpzLcxzvAw4HyQ==", null, false, "44a06930-e7c3-40e2-a4be-55c5fbc6f3c5", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "SaveGames",
                columns: new[] { "Id", "BlobUri", "Description", "FileName", "UploadDate" },
                values: new object[] { 1, "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test.rar", "CJ Max Missions ALL", "test1", new DateTime(2024, 4, 21, 13, 50, 4, 41, DateTimeKind.Local).AddTicks(632) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaveGames");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c587c054-fd8a-4638-955f-7f2427990c5a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ffd97e69-bf4e-452c-9a20-45e8a539eddc");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "21c8ab51-1056-4c31-8e79-c4e41c90d7fb", 0, "c468aaae-462b-4d1d-b434-8efbf3cd9f87", new DateTime(2024, 4, 17, 16, 24, 33, 672, DateTimeKind.Local).AddTicks(2976), null, "ApplicationUser", "guest@mail.com", false, "Guest", false, "Guestov", false, null, "Guestov", new DateTime(2024, 4, 17, 16, 24, 33, 672, DateTimeKind.Local).AddTicks(3013), "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEIyWNwBephROhCknnCI33in0UH9gBAQrSNQ+CpTjIdf7VQTa2yL4AQH+JFUFzRXkrA==", null, false, "d3d87963-f432-456b-a824-900faab2fc64", false, "guest@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5f4bb76c-e097-485f-946d-c8631b8d253a", 0, "e4b6e88e-63bd-4135-8031-497e2c71f15d", new DateTime(2024, 4, 17, 16, 24, 33, 673, DateTimeKind.Local).AddTicks(2596), null, "ApplicationUser", "admin@mail.com", false, "Great", false, "Admin", false, null, "Adminov", new DateTime(2024, 4, 17, 16, 24, 33, 673, DateTimeKind.Local).AddTicks(2598), "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEDS1N8/od9eLiJ87KYuR32eYGumbLo/Cu1VAh4VRGQgAlVEC/MJNJBgrQ+zA2J8ceg==", null, false, "651d6770-c329-448d-8d63-d5f9734f45c4", false, "admin@mail.com" });
        }
    }
}
