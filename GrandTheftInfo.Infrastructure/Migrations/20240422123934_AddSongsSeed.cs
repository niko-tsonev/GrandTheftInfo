using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrandTheftInfo.Infrastructure.Migrations
{
    public partial class AddSongsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b716d45e-9ce1-4c6f-941c-179c769c398c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c830173a-5a63-4252-afdb-c362be52c30c");

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Radio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RadioImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11365df0-d857-4abc-8126-f6d89169c591", 0, "1d262554-c9c0-4526-b9ef-c92acd9f2891", new DateTime(2024, 4, 22, 15, 39, 33, 768, DateTimeKind.Local).AddTicks(4628), null, "ApplicationUser", "admin@mail.com", false, "Great", false, "Admin", false, null, "Adminov", new DateTime(2024, 4, 22, 15, 39, 33, 768, DateTimeKind.Local).AddTicks(4630), "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAECHwZcu4hm9OPQ8PnVaZaKEZTv6KzeIAJadPYaIzMriTdS+x3NktDQqW1L6M5ffn4A==", null, false, "4010d73c-9162-43a7-bdda-b3196925e7c8", false, "admin@mail.com" },
                    { "4c0d567a-f038-4db9-83c3-93f0bc13b551", 0, "fcca2f71-696a-4615-bc09-c1e006dd537d", new DateTime(2024, 4, 22, 15, 39, 33, 767, DateTimeKind.Local).AddTicks(4868), null, "ApplicationUser", "guest@mail.com", false, "Guest", false, "Guestov", false, null, "Guestov", new DateTime(2024, 4, 22, 15, 39, 33, 767, DateTimeKind.Local).AddTicks(4903), "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEIa7ifP0x8YFCqqO+jwVGNy3PCovL7yM2e7Rq0rfLFA0FOr9YCysPJ2OEDBc3tu4cA==", null, false, "b893d948-aab4-4709-b9cc-cfed8228e58b", false, "guest@mail.com" }
                });

            migrationBuilder.UpdateData(
                table: "SaveGames",
                keyColumn: "Id",
                keyValue: 1,
                column: "UploadDate",
                value: new DateTime(2024, 4, 22, 15, 39, 33, 779, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "SaveGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadDate",
                value: new DateTime(2024, 4, 22, 15, 39, 33, 779, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "GameId", "Name", "Radio", "RadioImageUrl", "VideoUrl" },
                values: new object[,]
                {
                    { 1, 1, "Rick James - Cold Blooded", "Bounce FM", "https://i1.sndcdn.com/artworks-000072126799-6e0z41-t500x500.jpg", "https://www.youtube.com/watch?v=Vm4jJQFXWp4&ab_channel=Micahisgod" },
                    { 2, 1, "Ohio Players - Love Rollercoaster", "Bounce FM", "https://i1.sndcdn.com/artworks-000072126799-6e0z41-t500x500.jpg", "https://www.youtube.com/watch?v=Gm8lcoPZtBY&ab_channel=drewsmusical" },
                    { 3, 2, "Mobb Deep - Dirty New Yorker", "The Beat 102.7", "https://i.ibb.co/sjXcxBw/The-Beat-102-7-29.png", "https://www.youtube.com/watch?v=o1kO1JM1T6A&ab_channel=VevoMusicGroup" },
                    { 4, 2, "Nas - War Is Necessary", "The Beat 102.7", "https://i.ibb.co/sjXcxBw/The-Beat-102-7-29.png", "https://www.youtube.com/watch?v=PIwb70xCqaQ&ab_channel=RapIsTheRealShit" },
                    { 5, 1, "Cypress Hill - How I Could Just Kill a Man", "Radio Los Santos", "https://i.scdn.co/image/ab67706c0000da84cb4d487c981320e512939ee3", "https://www.youtube.com/watch?v=Yg-RIOATCbU&ab_channel=CypressHillVEVO" },
                    { 6, 2, "Aphex Twin - Z Twig", "Radio Los Santos", "https://i.ibb.co/9c7V6s1/The-Journey.png", "https://www.youtube.com/watch?v=j2i8eb5b84A&ab_channel=capcamarat715wa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GameId",
                table: "Songs",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11365df0-d857-4abc-8126-f6d89169c591");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c0d567a-f038-4db9-83c3-93f0bc13b551");

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
                column: "UploadDate",
                value: new DateTime(2024, 4, 21, 20, 13, 18, 484, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "SaveGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "UploadDate",
                value: new DateTime(2024, 4, 21, 20, 13, 18, 484, DateTimeKind.Local).AddTicks(7796));
        }
    }
}
