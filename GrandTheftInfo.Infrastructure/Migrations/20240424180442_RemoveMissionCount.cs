using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrandTheftInfo.Infrastructure.Migrations
{
    public partial class RemoveMissionCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b5f7706-6119-4b0e-97a0-dc94f849668b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dad13bb0-67a0-41d8-b5cf-2dca1ef9f439");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "966f46aa-208b-4597-81ae-7a511d4d52cd", 0, "9d9acd9d-b598-4009-b168-f9f4884b3de4", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAELnfTKzh0faI9WZuod+LrxXUX5KJwVaOQKhaN/xwfEzF539Xm3r8oMRooM3MXfxeDw==", null, false, "4ef6b5a4-382e-4d01-95a3-ea0a5b16ae84", false, "guest@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a488be50-01c4-41b3-be17-ffe2dc297aad", 0, "a8525dc8-44c4-4141-add1-b79384044d9f", "admin@mail.com", false, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEFe9UqN1gy9GZO/HFeHBhlUr9XX09uC6+J8RkFGigdbIFfjCX8ywZpzJmbcrutCK2A==", null, false, "5ad307ea-8291-43f1-b55d-8fa620b26994", false, "admin@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "966f46aa-208b-4597-81ae-7a511d4d52cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a488be50-01c4-41b3-be17-ffe2dc297aad");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7b5f7706-6119-4b0e-97a0-dc94f849668b", 0, "addc71d4-e819-4202-8914-844ff0b04cd8", "admin@mail.com", false, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEPhYt7OVdwH0UNY1k9wNKCcix7PvLnZDMse3AgB/w4kLzrYytoxeXpQA4bCgFEBw0Q==", null, false, "f19740f6-92b3-4656-a769-328534a2c47d", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dad13bb0-67a0-41d8-b5cf-2dca1ef9f439", 0, "3dcb258d-e415-4fed-97e0-488f4a753ba1", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEI09Q9jSMVghBCeCcGNXwYgPV/ZMUyXBl5ZKABw3rCVLWKrrx4RDnc7nhdJ0UrC/9A==", null, false, "1400f485-19c0-44e3-9a0e-faaa38904bb1", false, "guest@mail.com" });
        }
    }
}
