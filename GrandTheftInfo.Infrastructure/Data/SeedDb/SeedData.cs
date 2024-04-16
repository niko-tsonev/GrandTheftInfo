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
    }
}
