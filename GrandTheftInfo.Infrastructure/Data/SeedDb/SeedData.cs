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

        public Song SongOne { get; set; } = null!;
        public Song SongTwo { get; set; } = null!;
        public Song SongThree { get; set; } = null!;
        public Song SongFour { get; set; } = null!;
        public Song SongFive { get; set; } = null!;
        public Song SongSix { get; set; } = null!;

        public ApplicationUser GuestUser { get; set; } = null!;

        public ApplicationUser AdminUser { get; set; } = null!;

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            GuestUser = new ApplicationUser()
            {
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com",
                FirstName = "Guest",
                MiddleName = "Guestov",
                LastName = "Guestov",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                IsDeleted = false
            };

            GuestUser.PasswordHash =
            hasher.HashPassword(GuestUser, "guest123");

            AdminUser = new ApplicationUser()
            {
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                FirstName = "Great",
                MiddleName = "Adminov",
                LastName = "Admin",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                IsDeleted = false
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
                Description = "Los Santos CJ helps family take over.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c4/GTASABOX.jpg",
                YearPublished = DateTime.Parse("11/26/2004")
            };

            GameTwo = new Game()
            {
                Id = 2,
                Name = "GTA IV",
                Description = "Niko helps cousing in Liberty City",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b7/Grand_Theft_Auto_IV_cover.jpg",
                YearPublished = DateTime.Parse("12/02/2008")
            };
        }

        private void SeedMissions()
        {
            MissionOne = new Mission()
            {
                Id = 1,
                Name = "First SA Mission",
                Description = "Ride bikes",
                PlaytroughUrl = "http://google.com",
                GameId = 1
            };

            MissionTwo = new Mission()
            {
                Id = 2,
                Name = "Second SA Mission",
                Description = "Kill ballas",
                PlaytroughUrl = "http://google2.com",
                GameId = 1
            };

            MissionThree = new Mission()
            {
                Id = 3,
                Name = "First GTA 4 Mission",
                Description = "Help cousing",
                PlaytroughUrl = "http://google3.com",
                GameId = 2
            };

            MissionFour = new Mission()
            {
                Id= 4,
                Name = "Second GTA 4 Mission",
                Description = "Save cousing",
                PlaytroughUrl = "http://google4.com",
                GameId = 2
            };
        }

        private void SeedCheats()
        {
            CheatOne = new Cheat()
            {
                Id = 1,
                Name = "Money cheat",
                CheatCode = "HESOYAM",
                Platform = "PC",
                GameId = 1
            };

            CheatTwo = new Cheat()
            {
                Id = 2,
                Name = "No police",
                CheatCode = "AEZAKMI",
                Platform = "PC",
                GameId = 1
            };

            CheatThree = new Cheat()
            {
                Id = 3,
                Name = "God mode cheat",
                CheatCode = "BAGUVIX",
                Platform = "PC",
                GameId = 1
            };

            CheatFour = new Cheat()
            {
                Id = 4,
                Name = "Money cheat",
                CheatCode = "DEDAZNAM",
                Platform = "PC",
                GameId = 2
            };

            CheatFive = new Cheat()
            {
                Id = 5,
                Name = "No police",
                CheatCode = "BALSAMGO",
                Platform = "PC",
                GameId = 2
            };

            CheatSix = new Cheat()
            {
                Id = 6,
                Name = "God mode cheat",
                CheatCode = "NIZNAM",
                Platform = "PC",
                GameId = 2
            };

            CheatSeven = new Cheat()
            {
                Id = 7,
                Name = "God mode cheat",
                CheatCode = "Down, X, Right, Left, Right, R1, Right, Down, Up, Triangle",
                Platform = "Playstation",
                GameId = 1
            };

            CheatEight = new Cheat()
            {
                Id = 8,
                Name = "Money cheat",
                CheatCode = "R1, R2, L1, X, LEFT, DOWN, RIGHT, UP, LEFT, DOWN, RIGHT, UP",
                Platform = "Playstation",
                GameId = 1
            };

            CheatNine = new Cheat()
            {
                Id = 9,
                Name = "Change weather",
                CheatCode = "468-555-0100",
                Platform = "Playstation",
                GameId = 2
            };

            CheatTen = new Cheat()
            {
                Id = 10,
                Name = "Weapons 1",
                CheatCode = "486-555-0150",
                Platform = "Playstation",
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
                ImageUrlOne = "https://static.wikia.nocookie.net/gtawiki/images/a/ab/StatueofHappiness-GTA4-statue%27sface.jpg/revision/latest/scale-to-width-down/1000?cb=20100401143154",
                ImageUrlTwo = "https://static.wikia.nocookie.net/gtawiki/images/f/fa/StatueofHappiness-GTAIV-Statue%27sTorch.jpg/revision/latest?cb=20130813211705",
                GameId = 2
            };

            EasterEggFour = new EasterEgg()
            {
                Id = 4,
                Name = "\"No Hidden Content This Way\" sign",
                Description = "The southern door has a sign: \"No Hidden Content This Way\". This is similar to the sign on top of the Gant Bridge in GTA San Andreas and The Hidden Sign in GTA III.",
                ImageUrlOne = "https://static.wikia.nocookie.net/gtawiki/images/7/7b/StatueOfHappiness-GTAIV-NoHiddenContentThisWay.jpg/revision/latest?cb=20140512000301",
                GameId = 2
            };
        }

        private void SeedSaveGames()
        {
            SaveGameOne = new SaveGame()
            {
                Id = 1,
                FileName = "test1",
                Description = "CJ Max Missions ALL",
                UploadDate = DateTime.Now,
                BlobUri = "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test1.rar",
                GameId = 1,
            };

            SaveGameTwo = new SaveGame()
            {
                Id = 2,
                FileName = "test2",
                Description = "Niko Max Missions ALL",
                UploadDate = DateTime.Now,
                BlobUri = "https://grandtheftinfo.blob.core.windows.net/blobgrandtheftinfo/test2.rar",
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
                Name = "Cypress Hill - How I Could Just Kill a Man",
                VideoUrl = "https://www.youtube.com/watch?v=Yg-RIOATCbU&ab_channel=CypressHillVEVO",
                Radio = "Radio Los Santos",
                RadioImageUrl = "https://i.scdn.co/image/ab67706c0000da84cb4d487c981320e512939ee3",
                GameId = 1
            };

            SongSix = new Song()
            {
                Id = 6,
                Name = "Aphex Twin - Z Twig",
                VideoUrl = "https://www.youtube.com/watch?v=j2i8eb5b84A&ab_channel=capcamarat715wa",
                Radio = "Radio Los Santos",
                RadioImageUrl = "https://i.ibb.co/9c7V6s1/The-Journey.png",
                GameId = 2
            };
        }
    }
}
