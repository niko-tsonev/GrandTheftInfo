using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrandTheftInfo.Infrastructure.Migrations
{
    public partial class ClearDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11365df0-d857-4abc-8126-f6d89169c591");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c0d567a-f038-4db9-83c3-93f0bc13b551");

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

            migrationBuilder.DeleteData(
                table: "EasterEggs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EasterEggs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EasterEggs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EasterEggs",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.DeleteData(
                table: "SaveGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SaveGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
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

            migrationBuilder.DropColumn(
                name: "UploadDate",
                table: "SaveGames");

            migrationBuilder.AlterColumn<string>(
                name: "VideoUrl",
                table: "Songs",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RadioImageUrl",
                table: "Songs",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Radio",
                table: "Songs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Songs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "SaveGames",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SaveGames",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BlobUri",
                table: "SaveGames",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PlaytroughUrl",
                table: "Missions",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Missions",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Games",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "EasterEggs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrlOne",
                table: "EasterEggs",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "EasterEggs",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cda64255-9e94-41bf-b0f3-fb667ef74c0d", 0, "a4de7560-f568-48d1-82b1-5a40de191ada", new DateTime(2024, 4, 23, 20, 37, 59, 857, DateTimeKind.Local).AddTicks(8647), null, "ApplicationUser", "admin@mail.com", false, "Great", false, "Admin", false, null, "Adminov", new DateTime(2024, 4, 23, 20, 37, 59, 857, DateTimeKind.Local).AddTicks(8648), "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEP1eMbXFpzhZG8lTPG0sV4JKvbz8NN2DU2tneeWvT5Dmg3sIlCqc+ZztA+hNCzlzwg==", null, false, "311accdf-2045-48aa-a4db-bce7b77c4248", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "efcdbfc6-22c8-4104-8744-9679be0b32cb", 0, "3d86a186-cb88-4dec-8a66-815a0e0e5e24", new DateTime(2024, 4, 23, 20, 37, 59, 856, DateTimeKind.Local).AddTicks(8956), null, "ApplicationUser", "guest@mail.com", false, "Guest", false, "Guestov", false, null, "Guestov", new DateTime(2024, 4, 23, 20, 37, 59, 856, DateTimeKind.Local).AddTicks(8993), "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEHKhlm0LR5jjiftk644O6Ju/TBFJxP4fb1phO34YJzISH9kjO5uucPNBE9NemTer7Q==", null, false, "fa3033f0-428a-4930-b001-dd42f3d2f1ac", false, "guest@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cda64255-9e94-41bf-b0f3-fb667ef74c0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efcdbfc6-22c8-4104-8744-9679be0b32cb");

            migrationBuilder.AlterColumn<string>(
                name: "VideoUrl",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "RadioImageUrl",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Radio",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "SaveGames",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SaveGames",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600);

            migrationBuilder.AlterColumn<string>(
                name: "BlobUri",
                table: "SaveGames",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<DateTime>(
                name: "UploadDate",
                table: "SaveGames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "PlaytroughUrl",
                table: "Missions",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Missions",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Games",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "EasterEggs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrlOne",
                table: "EasterEggs",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "EasterEggs",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11365df0-d857-4abc-8126-f6d89169c591", 0, "1d262554-c9c0-4526-b9ef-c92acd9f2891", new DateTime(2024, 4, 22, 15, 39, 33, 768, DateTimeKind.Local).AddTicks(4628), null, "ApplicationUser", "admin@mail.com", false, "Great", false, "Admin", false, null, "Adminov", new DateTime(2024, 4, 22, 15, 39, 33, 768, DateTimeKind.Local).AddTicks(4630), "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAECHwZcu4hm9OPQ8PnVaZaKEZTv6KzeIAJadPYaIzMriTdS+x3NktDQqW1L6M5ffn4A==", null, false, "4010d73c-9162-43a7-bdda-b3196925e7c8", false, "admin@mail.com" },
                    { "4c0d567a-f038-4db9-83c3-93f0bc13b551", 0, "fcca2f71-696a-4615-bc09-c1e006dd537d", new DateTime(2024, 4, 22, 15, 39, 33, 767, DateTimeKind.Local).AddTicks(4868), null, "ApplicationUser", "guest@mail.com", false, "Guest", false, "Guestov", false, null, "Guestov", new DateTime(2024, 4, 22, 15, 39, 33, 767, DateTimeKind.Local).AddTicks(4903), "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEIa7ifP0x8YFCqqO+jwVGNy3PCovL7yM2e7Rq0rfLFA0FOr9YCysPJ2OEDBc3tu4cA==", null, false, "b893d948-aab4-4709-b9cc-cfed8228e58b", false, "guest@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "DatePublished" },
                values: new object[,]
                {
                    { 1, "Los Santos CJ helps family take over.", "https://upload.wikimedia.org/wikipedia/en/c/c4/GTASABOX.jpg", "GTA San Andreas", new DateTime(2004, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Niko helps cousing in Liberty City", "https://upload.wikimedia.org/wikipedia/en/b/b7/Grand_Theft_Auto_IV_cover.jpg", "GTA IV", new DateTime(2008, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Cheats",
                columns: new[] { "Id", "CheatCode", "GameId", "Name", "Platform" },
                values: new object[,]
                {
                    { 1, "HESOYAM", 1, "Money cheat", "PC" },
                    { 2, "AEZAKMI", 1, "No police", "PC" },
                    { 3, "BAGUVIX", 1, "God mode cheat", "PC" },
                    { 4, "DEDAZNAM", 2, "Money cheat", "PC" },
                    { 5, "BALSAMGO", 2, "No police", "PC" },
                    { 6, "NIZNAM", 2, "God mode cheat", "PC" },
                    { 7, "Down, X, Right, Left, Right, R1, Right, Down, Up, Triangle", 1, "God mode cheat", "Playstation" },
                    { 8, "R1, R2, L1, X, LEFT, DOWN, RIGHT, UP, LEFT, DOWN, RIGHT, UP", 1, "Money cheat", "Playstation" },
                    { 9, "468-555-0100", 2, "Change weather", "Playstation" },
                    { 10, "486-555-0150", 2, "Weapons 1", "Playstation" }
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

            migrationBuilder.InsertData(
                table: "SaveGames",
                columns: new[] { "Id", "BlobUri", "Description", "FileName", "GameId", "UploadDate" },
                values: new object[,]
                {
                    { 1, "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test1.rar", "CJ Max Missions ALL", "test1", 1, new DateTime(2024, 4, 22, 15, 39, 33, 779, DateTimeKind.Local).AddTicks(843) },
                    { 2, "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test2.rar", "Niko Max Missions ALL", "test2", 2, new DateTime(2024, 4, 22, 15, 39, 33, 779, DateTimeKind.Local).AddTicks(845) }
                });

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
        }
    }
}
