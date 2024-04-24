using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Cheat;
using GrandTheftInfo.Core.Services;
using GrandTheftInfo.Infrastructure.Data.Common;
using GrandTheftInfo.Infrastructure.Data.Models;

namespace GrandTheftInfo.Tests.ServiceTests
{
    public class CheatServiceTest
    {
        private ICheatService _cheatService;
        private IRepository _repo;

        [SetUp]
        public void Setup()
        {
            _repo = new Repository(DatabaseMock.Instance);
            _cheatService = new CheatService(_repo);

            DatabaseMock.Instance.Database.EnsureDeleted();
            DatabaseMock.Instance.Database.EnsureCreated();
        }

        [Test]
        public async Task AllAsync_Returns_All_Cheats()
        {
            // Arrange
            var game = new Game()
            {
                Id = 1,
                Name = "Game",
                Description = "Desc",
                DatePublished = DateTime.Now,
                ImageUrl = "ImgUrl"
            };

            var cheats = new List<Cheat>
            {
                new Cheat { Id = 1, Name = "Cheat 1", CheatCode = "CheatCode 1", Platform = "Platform 1", GameId = 1, Game = game },
                new Cheat { Id = 2, Name = "Cheat 2", CheatCode = "CheatCode 2", Platform = "Platform 2", GameId = 2, Game = game }
            };

            foreach (var cheat in cheats)
            {
                await _repo.AddAsync(cheat);
            }
            await _repo.SaveChangesAsync();

            // Act
            var result = await _cheatService.AllAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(cheats.Count));

            foreach (var expectedCheat in cheats)
            {
                var actualCheat = result.FirstOrDefault(c => c.Id == expectedCheat.Id);
                Assert.NotNull(actualCheat);
                Assert.That(actualCheat.Name, Is.EqualTo(expectedCheat.Name));
                Assert.That(actualCheat.CheatCode, Is.EqualTo(expectedCheat.CheatCode));
                Assert.That(actualCheat.Platform, Is.EqualTo(expectedCheat.Platform));
                Assert.That(actualCheat.GameName, Is.EqualTo(expectedCheat.Game.Name));
                Assert.That(actualCheat.GameId, Is.EqualTo(expectedCheat.Game.Id));
            }
        }

        [Test]
        public async Task AddAsync_Adds_New_Cheat()
        {
            // Arrange
            var newCheat = new CheatFormModel
            {
                Name = "New Cheat",
                CheatCode = "New CheatCode",
                Platform = "New Platform",
                GameId = 1
            };

            // Act
            var cheatId = await _cheatService.AddAsync(newCheat);
            var addedCheat = await _repo.GetByIdAsync<Cheat>(cheatId);

            // Assert
            Assert.NotNull(addedCheat);
            Assert.That(addedCheat.Name, Is.EqualTo(newCheat.Name));
            Assert.That(addedCheat.CheatCode, Is.EqualTo(newCheat.CheatCode));
            Assert.That(addedCheat.Platform, Is.EqualTo(newCheat.Platform));
            Assert.That(addedCheat.GameId, Is.EqualTo(newCheat.GameId));
        }

        [Test]
        public async Task GetFormModelByIdAsync_Returns_Correct_Cheat_Form_Model()
        {
            // Arrange
            var game = new Game()
            {
                Id = 1,
                Name = "Game",
                Description = "Desc",
                DatePublished = DateTime.Now,
                ImageUrl = "ImgUrl"
            };

            var cheatId = 1;
            var cheat = new Cheat { Id = cheatId, Name = "Test Cheat", CheatCode = "Test CheatCode", Platform = "Test Platform", GameId = 1, Game = game };
            await _repo.AddAsync(cheat);
            await _repo.SaveChangesAsync();

            // Act
            var result = await _cheatService.GetFormModelByIdAsync(cheatId);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Name, Is.EqualTo(cheat.Name));
            Assert.That(result.CheatCode, Is.EqualTo(cheat.CheatCode));
            Assert.That(result.Platform, Is.EqualTo(cheat.Platform));
            Assert.That(result.GameId, Is.EqualTo(cheat.GameId));
        }

        [Test]
        public async Task EditAsync_Updates_Existing_Cheat()
        {
            // Arrange
            var cheatId = 1;
            var cheat = new Cheat { Id = cheatId, Name = "Test Cheat", CheatCode = "Test CheatCode", Platform = "Test Platform", GameId = 1 };
            await _repo.AddAsync(cheat);
            await _repo.SaveChangesAsync();

            var editedCheat = new CheatFormModel
            {
                Id = cheatId,
                Name = "Edited Cheat",
                CheatCode = "Edited CheatCode",
                Platform = "Edited Platform",
                GameId = 2
            };

            // Act
            await _cheatService.EditAsync(cheatId, editedCheat);
            var updatedCheat = await _repo.GetByIdAsync<Cheat>(cheatId);

            // Assert
            Assert.NotNull(updatedCheat);
            Assert.That(updatedCheat.Name, Is.EqualTo(editedCheat.Name));
            Assert.That(updatedCheat.CheatCode, Is.EqualTo(editedCheat.CheatCode));
            Assert.That(updatedCheat.Platform, Is.EqualTo(editedCheat.Platform));
            Assert.That(updatedCheat.GameId, Is.EqualTo(editedCheat.GameId));
        }

        [Test]
        public async Task DeleteAsync_Removes_Cheat()
        {
            // Arrange
            var cheatId = 1;
            var cheat = new Cheat { Id = cheatId, Name = "Test Cheat", CheatCode = "Test CheatCode", Platform = "Test Platform", GameId = 1 };
            await _repo.AddAsync(cheat);
            await _repo.SaveChangesAsync();

            // Act
            await _cheatService.DeleteAsync(cheatId);
            var deletedCheat = await _repo.GetByIdAsync<Cheat>(cheatId);

            // Assert
            Assert.Null(deletedCheat);
        }

        [TearDown]
        public void TearDown()
        {
            DatabaseMock.Instance.Dispose();
        }
    }
}
