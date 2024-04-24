using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrandTheftInfo.Infrastructure.Migrations
{
    public partial class IDChangeInGameModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a87523a-a2a7-4743-8c5f-aff061686200");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc07746a-9b68-44ae-b193-4cb4a65e3593");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7b5f7706-6119-4b0e-97a0-dc94f849668b", 0, "addc71d4-e819-4202-8914-844ff0b04cd8", "admin@mail.com", false, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEPhYt7OVdwH0UNY1k9wNKCcix7PvLnZDMse3AgB/w4kLzrYytoxeXpQA4bCgFEBw0Q==", null, false, "f19740f6-92b3-4656-a769-328534a2c47d", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dad13bb0-67a0-41d8-b5cf-2dca1ef9f439", 0, "3dcb258d-e415-4fed-97e0-488f4a753ba1", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEI09Q9jSMVghBCeCcGNXwYgPV/ZMUyXBl5ZKABw3rCVLWKrrx4RDnc7nhdJ0UrC/9A==", null, false, "1400f485-19c0-44e3-9a0e-faaa38904bb1", false, "guest@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0a87523a-a2a7-4743-8c5f-aff061686200", 0, "fe684972-26ff-4dc5-b2f1-30b83772a266", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEHKzih2RD5K6/pCg/LWvjajctgZPUmjRjob8FJfX/8mUAy6nWCCKpD6af9+yaT+Eew==", null, false, "ce8c60e8-a409-45dc-9384-27d0b3e0bb42", false, "guest@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dc07746a-9b68-44ae-b193-4cb4a65e3593", 0, "d6b785d5-0e6c-43a2-8c7c-eece6b138107", "admin@mail.com", false, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEC73LQUoNQl2jpE5WeyvdB8QNNDmDwzaU7UgIGJ2mmUq+++sZa5Hy/0tFtPj8ODzSw==", null, false, "1f1e02c1-dd35-46e2-a6ca-8c1365178d3b", false, "admin@mail.com" });
        }
    }
}
