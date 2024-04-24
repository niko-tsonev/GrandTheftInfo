using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace GrandTheftInfo.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public SeedData()
        {
            SeedUsers();
            SeedGames();
            SeedMissions();
            SeedCheats();
            SeedEasterEggs();
            SeedSaveGames();
            SeedSongs();
        }

        public Game GameOne { get; set; } = null!;
        public Game GameTwo { get; set; } = null!;

        public Mission MissionOne { get; set; } = null!;
        public Mission MissionTwo { get; set; } = null!;
        public Mission MissionThree { get; set; } = null!;
        public Mission MissionFour { get; set; } = null!;
        public Mission MissionFive { get; set; } = null!;
        public Mission MissionSix { get; set; } = null!;
        public Mission MissionSeven { get; set; } = null!;
        public Mission MissionEight { get; set; } = null!;

        public Cheat CheatOne { get; set; } = null!;
        public Cheat CheatTwo { get; set; } = null!;
        public Cheat CheatThree { get; set; } = null!;
        public Cheat CheatFour { get; set; } = null!;
        public Cheat CheatFive { get; set; } = null!;
        public Cheat CheatSix { get; set; } = null!;
        public Cheat CheatSeven { get; set; } = null!;
        public Cheat CheatEight { get; set; } = null!;
        public Cheat CheatNine { get; set; } = null!;
        public Cheat CheatTen { get; set; } = null!;

        public EasterEgg EasterEggOne { get; set; } = null!;
        public EasterEgg EasterEggTwo { get; set; } = null!;
        public EasterEgg EasterEggThree { get; set; } = null!;
        public EasterEgg EasterEggFour { get; set; } = null!;

        public SaveGame SaveGameOne { get; set; } = null!;
        public SaveGame SaveGameTwo { get; set; } = null!;
        public SaveGame SaveGameThree { get; set; } = null!;

        public Song SongOne { get; set; } = null!;
        public Song SongTwo { get; set; } = null!;
        public Song SongThree { get; set; } = null!;
        public Song SongFour { get; set; } = null!;
        public Song SongFive { get; set; } = null!;

        public IdentityUser GuestUser { get; set; } = null!;

        public IdentityUser AdminUser { get; set; } = null!;

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            GuestUser = new IdentityUser()
            {
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            GuestUser.PasswordHash =
            hasher.HashPassword(GuestUser, "guest123");

            AdminUser = new IdentityUser()
            {
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM"
            };

            AdminUser.PasswordHash =
            hasher.HashPassword(AdminUser, "admin123");
        }

        private void SeedGames()
        {
            GameOne = new Game()
            {
                Id = 1,
                Name = "GTA San Andreas",
                Description = "Grand Theft Auto: San Andreas is a 2004 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the seventh title in the Grand Theft Auto series, following 2002's Grand Theft Auto: Vice City. Set within the fictional state of San Andreas, the game follows Carl \"CJ\" Johnson, who returns home after his mother's murder and finds his old gang has lost much of their territory. Over the course of the game, he attempts to re-establish the gang, clashes with corrupt authorities and powerful criminals, and gradually unravels the truth behind his mother's murder.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c4/GTASABOX.jpg",
                YearPublished = DateTime.Parse("11/26/2004")
            };

            GameTwo = new Game()
            {
                Id = 2,
                Name = "GTA IV",
                Description = "Grand Theft Auto IV is a 2008 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the sixth main entry in the Grand Theft Auto series, following 2004's Grand Theft Auto: San Andreas, and the eleventh instalment overall. Set in the fictional Liberty City, based on New York City, the single-player story follows Eastern European war veteran Niko Bellic and his attempts to escape his past while under pressure from high-profile criminals. The open world design lets players freely roam Liberty City, consisting of three main islands, and the neighbouring state of ",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b7/Grand_Theft_Auto_IV_cover.jpg",
                YearPublished = DateTime.Parse("12/02/2008")
            };
        }

        private void SeedMissions()
        {
            MissionOne = new Mission()
            {
                Id = 1,
                Name = "In the Beginning",
                Description = "Carl Johnson returns to Los Santos after spending five years in Liberty City when his brother Sweet Johnson informs him about his mother's death. However, when he reaches home to Grove Street, he gets captured by C.R.A.S.H. officers, who take his money and force him to get into their car before dropping him off at Jefferson, a Ballas territory.",
                PlaytroughUrl = "https://www.youtube.com/embed/OpTizzox2Qo?si=K5xZIWQwL6kFdpgW",
                GameId = 1
            };

            MissionTwo = new Mission()
            {
                Id = 2,
                Name = "Ryder",
                Description = "Carl meets Ryder at his house in Grove Street, though Ryder is not that happy to see Carl back. Ryder tells Carl that a pizza owner keeps painting over Grove Street tags and decides to give him some shame.",
                PlaytroughUrl = "https://www.youtube.com/embed/LbqKA7cYCQM?si=CIn-_iEtDviV6LUS",
                GameId = 1
            };

            MissionThree = new Mission()
            {
                Id = 3,
                Name = "Tagging Up Turf",
                Description = "Carl visits Sweet and Big Smoke at Sweet's house. Sweet questions Carl about what made him return to the hood, and gives him a spray can to let him spray over some enemy graffiti. Sweet, however, changes his mind and decides to go with him.",
                PlaytroughUrl = "https://www.youtube.com/embed/HRduC_IkmFA?si=-dFIz96gsCFNCgwP",
                GameId = 1
            };

            MissionFour = new Mission()
            {
                Id= 4,
                Name = "Cleaning the Hood",
                Description = "Sweet, Big Smoke, and Ryder are discussing the rise in crack cocaine in the city. After a brief argument, Ryder and CJ decide to take care of the business.",
                PlaytroughUrl = "https://www.youtube.com/embed/fUjfkGgZNIk?si=xrtBeDGMPzpePcOr",
                GameId = 1
            };

            MissionFive = new Mission()
            {
                Id = 5,
                Name = "Drive-Thru",
                Description = "Big Smoke, Sweet, and Ryder go to eat, and CJ joins them. They head to Cluckin' Bell and get some orders. While eating, they spot the same Ballas who chased them earlier heading towards Grove Street.",
                PlaytroughUrl = "https://www.youtube.com/embed/E1aTlYlfzRk?si=SwSKVp536zSowgDS",
                GameId = 1
            };

            MissionSix = new Mission()
            {
                Id = 6,
                Name = "The Cousins Bellic",
                Description = "Watch the Introduction, before meeting Roman Bellic and driving him to his apartment.",
                PlaytroughUrl = "https://www.youtube.com/embed/Qo_9uifCivI?si=WTKXuLH87oVARRO6",
                GameId = 2
            };

            MissionSeven = new Mission()
            {
                Id = 7,
                Name = "It's Your Call",
                Description = "Drive Roman to a hardware store, receive his old phone and escape from the loan sharks.",
                PlaytroughUrl = "https://www.youtube.com/embed/c1_fKy1gcdI?si=uqo3XBtEymWZUnyL",
                GameId = 2
            };

            MissionEight = new Mission()
            {
                Id = 8,
                Name = "Three's a Crowd",
                Description = "Pick up Mallorie Bardas and Michelle from the subway station, drive them to Michelle's place, and go buy new clothes.",
                PlaytroughUrl = "https://www.youtube.com/embed/vQEVBOQTjfE?si=uuf7SCZJrVfTqE_N",
                GameId = 2
            };
        }

        private void SeedCheats()
        {
            CheatOne = new Cheat()
            {
                Id = 1,
                Name = "Health, Armor, and Money ($250,000)",
                CheatCode = "R1, R2, L1, X, LEFT, DOWN, RIGHT, UP, LEFT, DOWN, RIGHT, UP",
                Platform = "Playstation",
                GameId = 1
            };

            CheatTwo = new Cheat()
            {
                Id = 2,
                Name = "Infinite Ammo",
                CheatCode = "L1, R1, SQUARE, R1, LEFT, R2, R1, LEFT, SQUARE, DOWN, L1, L1",
                Platform = "Playstation",
                GameId = 1
            };

            CheatThree = new Cheat()
            {
                Id = 3,
                Name = "(Almost) Infinite Health",
                CheatCode = "Down, X, Right, Left, Right, R1, Right, Down, Up, Triangle",
                Platform = "Playstation",
                GameId = 1
            };

            CheatFour = new Cheat()
            {
                Id = 4,
                Name = "Health, Armor, and Money ($250,000)",
                CheatCode = "HESOYAM",
                Platform = "PC",
                GameId = 1
            };

            CheatFive = new Cheat()
            {
                Id = 5,
                Name = "Infinite Ammo",
                CheatCode = "FULLCLIP",
                Platform = "PC",
                GameId = 1
            };

            CheatSix = new Cheat()
            {
                Id = 6,
                Name = "Weapons 1",
                CheatCode = "486-555-0150",
                Platform = "Playstation",
                GameId = 2
            };

            CheatSeven = new Cheat()
            {
                Id = 7,
                Name = "Presidente",
                CheatCode = "265-555-2423",
                Platform = "Playstation",
                GameId = 2
            };

            CheatEight = new Cheat()
            {
                Id = 8,
                Name = "Raise wanted level",
                CheatCode = "267-555-0150",
                Platform = "Playstation",
                GameId = 2
            };

            CheatNine = new Cheat()
            {
                Id = 9,
                Name = "Spawn a Jetmax boat",
                CheatCode = "938-555-0100",
                Platform = "PC",
                GameId = 2
            };

            CheatTen = new Cheat()
            {
                Id = 10,
                Name = "Weapons 1",
                CheatCode = "486-555-0150",
                Platform = "PC",
                GameId = 2
            };
        }

        private void SeedEasterEggs()
        {
            EasterEggOne = new EasterEgg()
            {
                Id = 1,
                Name = "Secret Message on Gant Bridge",
                Description = "Located on Gant Bridge, this secret acts as something of a callback to Grand Theft Auto 3's iconic \"you weren't supposed to be able to get here you know\" Easter Egg. To find it, head over to Gant Bridge with a jetpack. Fly to the top of the first tower you pass under while crossing from the San Fierro side. Once you reach the top of the pillar, look to your right. You should see a small sign reading \"There are no Easter Eggs up here. Go away.\"",
                ImageUrlOne = "https://oyster.ignimgs.com/mediawiki/apis.ign.com/grand-theft-auto-san-andreas/c/c7/Grand_Theft_Auto_San_Andreas_Gant_Bridge_Easter_Egg.jpg?width=1920",
                GameId = 1
            };

            EasterEggTwo = new EasterEgg()
            {
                Id = 2,
                Name = "Gant Bridge Information Board",
                Description = "Gant Bridge actually has a second Easter Egg that's worth seeking out. It can be found listed on a facts board on the San Fierro side of the bridge, close to the diner by Katie's house. Behind the diner is a set of steps, with the board overlooking the walkway. Read the board and you'll see some generic facts about the Gant Bridge. However, the factoids will conclude with something a little less conventional, noting that it \"takes up a staggering 1.27 MB of disk space.\"",
                ImageUrlOne = "https://oyster.ignimgs.com/mediawiki/apis.ign.com/grand-theft-auto-san-andreas/e/e1/Grand_Theft_Auto_San_Andreas_Gant_Bridge_Info_Board.jpg?width=1920",
                GameId = 1
            };

            EasterEggThree = new EasterEgg()
            {
                Id = 3,
                Name = "Face of the statue & the Hot Coffee",
                Description = "The Statue of Happiness's face bears a striking resemblance to former U.S. Secretary of State Hillary Clinton. This resemblance, along with the cup of coffee in her right hand, may be a reference to the Hot Coffee controversy which Clinton took investigation in, also suggesting that new regulations be put on video games.",
                ImageUrlOne = "https://static.wikia.nocookie.net/gtawiki/images/a/ab/StatueofHappiness-GTA4-statue%27sface.jpg",
                ImageUrlTwo = "https://static.wikia.nocookie.net/gtawiki/images/f/fa/StatueofHappiness-GTAIV-Statue%27sTorch.jpg",
                GameId = 2
            };

            EasterEggFour = new EasterEgg()
            {
                Id = 4,
                Name = "\"No Hidden Content This Way\" sign",
                Description = "The southern door has a sign: \"No Hidden Content This Way\". This is similar to the sign on top of the Gant Bridge in GTA San Andreas and The Hidden Sign in GTA III.",
                ImageUrlOne = "https://static.wikia.nocookie.net/gtawiki/images/7/7b/StatueOfHappiness-GTAIV-NoHiddenContentThisWay.jpg",
                GameId = 2
            };
        }

        private void SeedSaveGames()
        {
            SaveGameOne = new SaveGame()
            {
                Id = 1,
                FileName = "test1.rar",
                Description = "GTA San Andreas 100 Save",
                BlobUri = "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test1.rar",
                GameId = 1,
            };

            SaveGameTwo = new SaveGame()
            {
                Id = 2,
                FileName = "test2.rar",
                Description = "GTA San Andreas 60 Save",
                BlobUri = "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test2.rar",
                GameId = 1,
            };

            SaveGameThree = new SaveGame()
            {
                Id = 3,
                FileName = "test3.rar",
                Description = "GTA 4 100 Save",
                BlobUri = "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test3.rar",
                GameId = 2,
            };
        }

        private void SeedSongs()
        {
            SongOne = new Song()
            {
                Id = 1,
                Name = "Rick James - Cold Blooded",
                VideoUrl = "https://www.youtube.com/watch?v=Vm4jJQFXWp4&ab_channel=Micahisgod",
                Radio = "Bounce FM",
                RadioImageUrl = "https://i1.sndcdn.com/artworks-000072126799-6e0z41-t500x500.jpg",
                GameId = 1
            };

            SongTwo = new Song()
            {
                Id = 2,
                Name = "Ohio Players - Love Rollercoaster",
                VideoUrl = "https://www.youtube.com/watch?v=Gm8lcoPZtBY&ab_channel=drewsmusical",
                Radio = "Bounce FM",
                RadioImageUrl = "https://i1.sndcdn.com/artworks-000072126799-6e0z41-t500x500.jpg",
                GameId = 1
            };

            SongThree = new Song()
            {
                Id = 3,
                Name = "Mobb Deep - Dirty New Yorker",
                VideoUrl = "https://www.youtube.com/watch?v=o1kO1JM1T6A&ab_channel=VevoMusicGroup",
                Radio = "The Beat 102.7",
                RadioImageUrl = "https://i.ibb.co/sjXcxBw/The-Beat-102-7-29.png",
                GameId = 2
            };

            SongFour = new Song()
            {
                Id = 4,
                Name = "Nas - War Is Necessary",
                VideoUrl = "https://www.youtube.com/watch?v=PIwb70xCqaQ&ab_channel=RapIsTheRealShit",
                Radio = "The Beat 102.7",
                RadioImageUrl = "https://i.ibb.co/sjXcxBw/The-Beat-102-7-29.png",
                GameId = 2
            };

            SongFive = new Song()
            {
                Id = 5,
                Name = "The Edge - David McCallum",
                VideoUrl = "https://www.youtube.com/embed/y05mMRJrUnE?si=w5bWjYkcXIzQdclZ",
                Radio = "Fusion FM",
                RadioImageUrl = "https://static.wikia.nocookie.net/gtawiki/images/6/65/Fusion-FM-Logo%2C_IV.png",
                GameId = 1
            };
        }
    }
}
