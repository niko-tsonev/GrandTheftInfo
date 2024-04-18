using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrandTheftInfo.Infrastructure.Migrations
{
    public partial class AddEasterEggSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77d7b30a-b6a2-4bee-b28d-ee9633edccb4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c50d1a8-bcd9-4146-8388-b050b12d74bd");

            migrationBuilder.CreateTable(
                name: "EasterEggs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageUrlOne = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ImageUrlTwo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EasterEggs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EasterEggs_Games_GameId",
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
                    { "21c8ab51-1056-4c31-8e79-c4e41c90d7fb", 0, "c468aaae-462b-4d1d-b434-8efbf3cd9f87", new DateTime(2024, 4, 17, 16, 24, 33, 672, DateTimeKind.Local).AddTicks(2976), null, "ApplicationUser", "guest@mail.com", false, "Guest", false, "Guestov", false, null, "Guestov", new DateTime(2024, 4, 17, 16, 24, 33, 672, DateTimeKind.Local).AddTicks(3013), "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEIyWNwBephROhCknnCI33in0UH9gBAQrSNQ+CpTjIdf7VQTa2yL4AQH+JFUFzRXkrA==", null, false, "d3d87963-f432-456b-a824-900faab2fc64", false, "guest@mail.com" },
                    { "5f4bb76c-e097-485f-946d-c8631b8d253a", 0, "e4b6e88e-63bd-4135-8031-497e2c71f15d", new DateTime(2024, 4, 17, 16, 24, 33, 673, DateTimeKind.Local).AddTicks(2596), null, "ApplicationUser", "admin@mail.com", false, "Great", false, "Admin", false, null, "Adminov", new DateTime(2024, 4, 17, 16, 24, 33, 673, DateTimeKind.Local).AddTicks(2598), "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEDS1N8/od9eLiJ87KYuR32eYGumbLo/Cu1VAh4VRGQgAlVEC/MJNJBgrQ+zA2J8ceg==", null, false, "651d6770-c329-448d-8d63-d5f9734f45c4", false, "admin@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "EasterEggs",
                columns: new[] { "Id", "Description", "GameId", "ImageUrlOne", "ImageUrlTwo", "Name" },
                values: new object[,]
                {
                    { 1, "Located on Gant Bridge, this secret acts as something of a callback to Grand Theft Auto 3's iconic \"you weren't supposed to be able to get here you know\" Easter Egg. To find it, head over to Gant Bridge with a jetpack. Fly to the top of the first tower you pass under while crossing from the San Fierro side. Once you reach the top of the pillar, look to your right. You should see a small sign reading \"There are no Easter Eggs up here. Go away.\"", 1, "https://oyster.ignimgs.com/mediawiki/apis.ign.com/grand-theft-auto-san-andreas/c/c7/Grand_Theft_Auto_San_Andreas_Gant_Bridge_Easter_Egg.jpg?width=1920", null, "Secret Message on Gant Bridge" },
                    { 2, "Gant Bridge actually has a second Easter Egg that's worth seeking out. It can be found listed on a facts board on the San Fierro side of the bridge, close to the diner by Katie's house. Behind the diner is a set of steps, with the board overlooking the walkway. Read the board and you'll see some generic facts about the Gant Bridge. However, the factoids will conclude with something a little less conventional, noting that it \"takes up a staggering 1.27 MB of disk space.\"", 1, "https://oyster.ignimgs.com/mediawiki/apis.ign.com/grand-theft-auto-san-andreas/e/e1/Grand_Theft_Auto_San_Andreas_Gant_Bridge_Info_Board.jpg?width=1920", null, "Gant Bridge Information Board" },
                    { 3, "The Statue of Happiness's face bears a striking resemblance to former U.S. Secretary of State Hillary Clinton. This resemblance, along with the cup of coffee in her right hand, may be a reference to the Hot Coffee controversy which Clinton took investigation in, also suggesting that new regulations be put on video games.", 2, "https://static.wikia.nocookie.net/gtawiki/images/a/ab/StatueofHappiness-GTA4-statue%27sface.jpg/revision/latest/scale-to-width-down/1000?cb=20100401143154", "https://static.wikia.nocookie.net/gtawiki/images/f/fa/StatueofHappiness-GTAIV-Statue%27sTorch.jpg/revision/latest?cb=20130813211705", "Face of the statue & the Hot Coffee" },
                    { 4, "The southern door has a sign: \"No Hidden Content This Way\". This is similar to the sign on top of the Gant Bridge in GTA San Andreas and The Hidden Sign in GTA III.", 2, "https://static.wikia.nocookie.net/gtawiki/images/7/7b/StatueOfHappiness-GTAIV-NoHiddenContentThisWay.jpg/revision/latest?cb=20140512000301", null, "\"No Hidden Content This Way\" sign" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EasterEggs_GameId",
                table: "EasterEggs",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EasterEggs");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21c8ab51-1056-4c31-8e79-c4e41c90d7fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f4bb76c-e097-485f-946d-c8631b8d253a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "77d7b30a-b6a2-4bee-b28d-ee9633edccb4", 0, "4e488824-abb6-4087-8d48-7648e375d194", new DateTime(2024, 4, 16, 12, 43, 33, 293, DateTimeKind.Local).AddTicks(6801), null, "ApplicationUser", "guest@mail.com", false, "Guest", false, "Guestov", false, null, "Guestov", new DateTime(2024, 4, 16, 12, 43, 33, 293, DateTimeKind.Local).AddTicks(6841), "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEGrgT3VBRetYAMIODCIpKS9zUa/pLsf6S4MIclxFb0ZH4YgUoHcwF+EeCpss21Qujg==", null, false, "5d6aa6e6-a1c2-4c8e-88f4-a3fc48ea6c0a", false, "guest@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9c50d1a8-bcd9-4146-8388-b050b12d74bd", 0, "727976f8-4daf-4e68-aa27-ce62629aa768", new DateTime(2024, 4, 16, 12, 43, 33, 294, DateTimeKind.Local).AddTicks(6483), null, "ApplicationUser", "admin@mail.com", false, "Great", false, "Admin", false, null, "Adminov", new DateTime(2024, 4, 16, 12, 43, 33, 294, DateTimeKind.Local).AddTicks(6485), "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEF3UiXSU2kIvOMbgTqBKgRG935BNWd2uJ+sK+T/ur06KQ73uMVDZNsLXFsAp2qaJ2Q==", null, false, "b9a18838-c35b-4212-9dab-15b65ee9d2a6", false, "admin@mail.com" });
        }
    }
}
