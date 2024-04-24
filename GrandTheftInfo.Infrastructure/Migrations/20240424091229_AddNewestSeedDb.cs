using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrandTheftInfo.Infrastructure.Migrations
{
    public partial class AddNewestSeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cda64255-9e94-41bf-b0f3-fb667ef74c0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efcdbfc6-22c8-4104-8744-9679be0b32cb");

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09a8c032-fbf1-402d-b7fb-81d4f74fd137", 0, "53b644da-447d-4191-9bde-c2ed791e243d", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEObSkQG11VIBfoGNEva38AqMu26+UIXrdcatm/m5JuhuvPZwdeKnBW3McL2ymWIFzA==", null, false, "fe91f48b-1978-46d8-a0c7-b636c4d8e3f4", false, "guest@mail.com" },
                    { "c593f6fb-125c-4651-98d5-39ec62c3fe46", 0, "fe5db983-5b57-41d9-9ec0-676b4c29a4aa", "admin@mail.com", false, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEG7MPNevcvq+bRr7qxDAdckr0aRLxCWrdI6tthfnbYaNvce0qmz5uGzJlkCgtJOqxQ==", null, false, "04e9cfea-e8c1-4c53-880d-fb840c284f67", false, "admin@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "YearPublished" },
                values: new object[,]
                {
                    { 1, "Grand Theft Auto: San Andreas is a 2004 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the seventh title in the Grand Theft Auto series, following 2002's Grand Theft Auto: Vice City. Set within the fictional state of San Andreas, the game follows Carl \"CJ\" Johnson, who returns home after his mother's murder and finds his old gang has lost much of their territory. Over the course of the game, he attempts to re-establish the gang, clashes with corrupt authorities and powerful criminals, and gradually unravels the truth behind his mother's murder.", "https://upload.wikimedia.org/wikipedia/en/c/c4/GTASABOX.jpg", "GTA San Andreas", new DateTime(2004, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Grand Theft Auto IV is a 2008 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the sixth main entry in the Grand Theft Auto series, following 2004's Grand Theft Auto: San Andreas, and the eleventh instalment overall. Set in the fictional Liberty City, based on New York City, the single-player story follows Eastern European war veteran Niko Bellic and his attempts to escape his past while under pressure from high-profile criminals. The open world design lets players freely roam Liberty City, consisting of three main islands, and the neighbouring state of ", "https://upload.wikimedia.org/wikipedia/en/b/b7/Grand_Theft_Auto_IV_cover.jpg", "GTA IV", new DateTime(2008, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Cheats",
                columns: new[] { "Id", "CheatCode", "GameId", "Name", "Platform" },
                values: new object[,]
                {
                    { 1, "R1, R2, L1, X, LEFT, DOWN, RIGHT, UP, LEFT, DOWN, RIGHT, UP", 1, "Health, Armor, and Money ($250,000)", "Playstation" },
                    { 2, "L1, R1, SQUARE, R1, LEFT, R2, R1, LEFT, SQUARE, DOWN, L1, L1", 1, "Infinite Ammo", "Playstation" },
                    { 3, "Down, X, Right, Left, Right, R1, Right, Down, Up, Triangle", 1, "(Almost) Infinite Health", "Playstation" },
                    { 4, "HESOYAM", 1, "Health, Armor, and Money ($250,000)", "PC" },
                    { 5, "FULLCLIP", 1, "Infinite Ammo", "PC" },
                    { 6, "486-555-0150", 2, "Weapons 1", "Playstation" },
                    { 7, "265-555-2423", 2, "Presidente", "Playstation" },
                    { 8, "267-555-0150", 2, "Raise wanted level", "Playstation" },
                    { 9, "938-555-0100", 2, "Spawn a Jetmax boat", "PC" },
                    { 10, "486-555-0150", 2, "Weapons 1", "PC" }
                });

            migrationBuilder.InsertData(
                table: "EasterEggs",
                columns: new[] { "Id", "Description", "GameId", "ImageUrlOne", "ImageUrlTwo", "Name" },
                values: new object[,]
                {
                    { 1, "Located on Gant Bridge, this secret acts as something of a callback to Grand Theft Auto 3's iconic \"you weren't supposed to be able to get here you know\" Easter Egg. To find it, head over to Gant Bridge with a jetpack. Fly to the top of the first tower you pass under while crossing from the San Fierro side. Once you reach the top of the pillar, look to your right. You should see a small sign reading \"There are no Easter Eggs up here. Go away.\"", 1, "https://oyster.ignimgs.com/mediawiki/apis.ign.com/grand-theft-auto-san-andreas/c/c7/Grand_Theft_Auto_San_Andreas_Gant_Bridge_Easter_Egg.jpg?width=1920", null, "Secret Message on Gant Bridge" },
                    { 2, "Gant Bridge actually has a second Easter Egg that's worth seeking out. It can be found listed on a facts board on the San Fierro side of the bridge, close to the diner by Katie's house. Behind the diner is a set of steps, with the board overlooking the walkway. Read the board and you'll see some generic facts about the Gant Bridge. However, the factoids will conclude with something a little less conventional, noting that it \"takes up a staggering 1.27 MB of disk space.\"", 1, "https://oyster.ignimgs.com/mediawiki/apis.ign.com/grand-theft-auto-san-andreas/e/e1/Grand_Theft_Auto_San_Andreas_Gant_Bridge_Info_Board.jpg?width=1920", null, "Gant Bridge Information Board" },
                    { 3, "The Statue of Happiness's face bears a striking resemblance to former U.S. Secretary of State Hillary Clinton. This resemblance, along with the cup of coffee in her right hand, may be a reference to the Hot Coffee controversy which Clinton took investigation in, also suggesting that new regulations be put on video games.", 2, "https://static.wikia.nocookie.net/gtawiki/images/a/ab/StatueofHappiness-GTA4-statue%27sface.jpg", "https://static.wikia.nocookie.net/gtawiki/images/f/fa/StatueofHappiness-GTAIV-Statue%27sTorch.jpg", "Face of the statue & the Hot Coffee" },
                    { 4, "The southern door has a sign: \"No Hidden Content This Way\". This is similar to the sign on top of the Gant Bridge in GTA San Andreas and The Hidden Sign in GTA III.", 2, "https://static.wikia.nocookie.net/gtawiki/images/7/7b/StatueOfHappiness-GTAIV-NoHiddenContentThisWay.jpg", null, "\"No Hidden Content This Way\" sign" }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "Id", "Description", "GameId", "Name", "PlaytroughUrl" },
                values: new object[,]
                {
                    { 1, "Carl Johnson returns to Los Santos after spending five years in Liberty City when his brother Sweet Johnson informs him about his mother's death. However, when he reaches home to Grove Street, he gets captured by C.R.A.S.H. officers, who take his money and force him to get into their car before dropping him off at Jefferson, a Ballas territory.", 1, "In the Beginning", "https://www.youtube.com/embed/OpTizzox2Qo?si=K5xZIWQwL6kFdpgW" },
                    { 2, "Carl meets Ryder at his house in Grove Street, though Ryder is not that happy to see Carl back. Ryder tells Carl that a pizza owner keeps painting over Grove Street tags and decides to give him some shame.", 1, "Ryder", "https://www.youtube.com/embed/LbqKA7cYCQM?si=CIn-_iEtDviV6LUS" },
                    { 3, "Carl visits Sweet and Big Smoke at Sweet's house. Sweet questions Carl about what made him return to the hood, and gives him a spray can to let him spray over some enemy graffiti. Sweet, however, changes his mind and decides to go with him.", 1, "Tagging Up Turf", "https://www.youtube.com/embed/HRduC_IkmFA?si=-dFIz96gsCFNCgwP" },
                    { 4, "Sweet, Big Smoke, and Ryder are discussing the rise in crack cocaine in the city. After a brief argument, Ryder and CJ decide to take care of the business.", 1, "Cleaning the Hood", "https://www.youtube.com/embed/fUjfkGgZNIk?si=xrtBeDGMPzpePcOr" },
                    { 5, "Big Smoke, Sweet, and Ryder go to eat, and CJ joins them. They head to Cluckin' Bell and get some orders. While eating, they spot the same Ballas who chased them earlier heading towards Grove Street.", 1, "Drive-Thru", "https://www.youtube.com/embed/E1aTlYlfzRk?si=SwSKVp536zSowgDS" },
                    { 6, "Watch the Introduction, before meeting Roman Bellic and driving him to his apartment.", 2, "The Cousins Bellic", "https://www.youtube.com/embed/Qo_9uifCivI?si=WTKXuLH87oVARRO6" },
                    { 7, "Drive Roman to a hardware store, receive his old phone and escape from the loan sharks.", 2, "It's Your Call", "https://www.youtube.com/embed/c1_fKy1gcdI?si=uqo3XBtEymWZUnyL" },
                    { 8, "Pick up Mallorie Bardas and Michelle from the subway station, drive them to Michelle's place, and go buy new clothes.", 2, "Three's a Crowd", "https://www.youtube.com/embed/vQEVBOQTjfE?si=uuf7SCZJrVfTqE_N" }
                });

            migrationBuilder.InsertData(
                table: "SaveGames",
                columns: new[] { "Id", "BlobUri", "Description", "FileName", "GameId" },
                values: new object[,]
                {
                    { 1, "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test1.rar", "GTA San Andreas 100 Save", "test1.rar", 1 },
                    { 2, "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test2.rar", "GTA San Andreas 60 Save", "test2.rar", 1 },
                    { 3, "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test3.rar", "GTA 4 100 Save", "test3.rar", 2 }
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
                    { 5, 1, "The Edge - David McCallum", "Fusion FM", "https://static.wikia.nocookie.net/gtawiki/images/6/65/Fusion-FM-Logo%2C_IV.png", "https://www.youtube.com/embed/y05mMRJrUnE?si=w5bWjYkcXIzQdclZ" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09a8c032-fbf1-402d-b7fb-81d4f74fd137");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c593f6fb-125c-4651-98d5-39ec62c3fe46");

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
                table: "Missions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SaveGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SaveGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SaveGames",
                keyColumn: "Id",
                keyValue: 3);

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
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

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
                values: new object[] { "cda64255-9e94-41bf-b0f3-fb667ef74c0d", 0, "a4de7560-f568-48d1-82b1-5a40de191ada", new DateTime(2024, 4, 23, 20, 37, 59, 857, DateTimeKind.Local).AddTicks(8647), null, "ApplicationUser", "admin@mail.com", false, "Great", false, "Admin", false, null, "Adminov", new DateTime(2024, 4, 23, 20, 37, 59, 857, DateTimeKind.Local).AddTicks(8648), "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEP1eMbXFpzhZG8lTPG0sV4JKvbz8NN2DU2tneeWvT5Dmg3sIlCqc+ZztA+hNCzlzwg==", null, false, "311accdf-2045-48aa-a4db-bce7b77c4248", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "DeletedOn", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "ModifiedOn", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "efcdbfc6-22c8-4104-8744-9679be0b32cb", 0, "3d86a186-cb88-4dec-8a66-815a0e0e5e24", new DateTime(2024, 4, 23, 20, 37, 59, 856, DateTimeKind.Local).AddTicks(8956), null, "ApplicationUser", "guest@mail.com", false, "Guest", false, "Guestov", false, null, "Guestov", new DateTime(2024, 4, 23, 20, 37, 59, 856, DateTimeKind.Local).AddTicks(8993), "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEHKhlm0LR5jjiftk644O6Ju/TBFJxP4fb1phO34YJzISH9kjO5uucPNBE9NemTer7Q==", null, false, "fa3033f0-428a-4930-b001-dd42f3d2f1ac", false, "guest@mail.com" });
        }
    }
}
