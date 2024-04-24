using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Game;
using GrandTheftInfo.Core.Services;
using GrandTheftInfo.Infrastructure.Data;
using GrandTheftInfo.Infrastructure.Data.Common;
using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Tests.ServiceTests
{
    public class GameServiceTest
    {
        private GrandTheftInfoDbContext applicationDbContext;
        private IGameService gameService;
        private IRepository repo;

        [SetUp]
        public void Setup()
        {
            repo = new Repository(DatabaseMock.Instance);
            gameService = new GameService(repo);

            DatabaseMock.Instance.Database.EnsureDeleted();
        }

        [Test]
        public async Task AllAsync_Returns_All_Games()
        {
            // Arrange
            var games = new List<Game>
            {
                new Game { Id = 1, Name = "Game 1", Description = "Description 1", ImageUrl = "Image 1", DatePublished = DateTime.Now },
                new Game { Id = 2, Name = "Game 2", Description = "Description 2", ImageUrl = "Image 2", DatePublished = DateTime.Now }
            };

            foreach (var game in games)
            {
                await repo.AddAsync(game);
            }
            await repo.SaveChangesAsync();

            // Act
            var result = await gameService.AllAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(games.Count));

            foreach (var expectedGame in games)
            {
                var actualGame = result.FirstOrDefault(g => g.Id == expectedGame.Id);
                Assert.NotNull(actualGame);
                Assert.That(actualGame.Name, Is.EqualTo(expectedGame.Name));
                Assert.That(actualGame.Description, Is.EqualTo(expectedGame.Description));
                Assert.That(actualGame.ImageUrl, Is.EqualTo(expectedGame.ImageUrl));
                Assert.That(actualGame.DatePublished, Is.EqualTo(expectedGame.DatePublished));
            }
        }

        [Test]
        public async Task AddAsync_Adds_New_Game()
        {
            // Arrange
            var newGame = new GameFormModel
            {
                Name = "New Game",
                Description = "New Description",
                ImageUrl = "New Image",
                DatePublished = DateTime.Now
            };

            // Act
            var gameId = await gameService.AddAsync(newGame);
            var addedGame = await repo.GetByIdAsync<Game>(gameId);

            // Assert
            Assert.NotNull(addedGame);
            Assert.That(addedGame.Name, Is.EqualTo(newGame.Name));
            Assert.That(addedGame.Description, Is.EqualTo(newGame.Description));
            Assert.That(addedGame.ImageUrl, Is.EqualTo(newGame.ImageUrl));
            Assert.That(addedGame.DatePublished, Is.EqualTo(newGame.DatePublished));
        }

        [Test]
        public async Task GetFormModelByIdAsync_Returns_Correct_Game_Form_Model()
        {
            // Arrange
            var gameId = 1;
            var game = new GameFormModel { Id = gameId, Name = "Test Game", Description = "Test Description", ImageUrl = "Test Image", DatePublished = DateTime.Now };
            await gameService.AddAsync(game);

            // Act
            var result = await repo.GetByIdAsync<Game>(gameId);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(game.Name, result.Name);
            Assert.AreEqual(game.Description, result.Description);
            Assert.AreEqual(game.ImageUrl, result.ImageUrl);
            Assert.AreEqual(game.DatePublished, result.DatePublished);
        }

        [Test]
        public async Task EditAsync_Updates_Existing_Game()
        {
            // Arrange
            var gameId = 1;
            var game = new GameFormModel { Id = gameId, Name = "Test Game", Description = "Test Description", ImageUrl = "Test Image", DatePublished = DateTime.Now };
            await gameService.AddAsync(game);

            var editedGame = new GameFormModel
            {
                Name = "Edited Game",
                Description = "Edited Description",
                ImageUrl = "Edited Image",
                DatePublished = DateTime.Now
            };

            // Act
            await gameService.EditAsync(gameId, editedGame);
            var updatedGame = await repo.GetByIdAsync<Game>(gameId);

            // Assert
            Assert.NotNull(updatedGame);
            Assert.AreEqual(editedGame.Name, updatedGame.Name);
            Assert.AreEqual(editedGame.Description, updatedGame.Description);
            Assert.AreEqual(editedGame.ImageUrl, updatedGame.ImageUrl);
            Assert.AreEqual(editedGame.DatePublished, updatedGame.DatePublished);
        }

        [Test]
        public async Task DeleteAsync_Removes_Game()
        {
            // Arrange
            var gameId = 1;
            var game = new GameFormModel { Id = gameId, Name = "Test Game", Description = "Test Description", ImageUrl = "Test Image", DatePublished = DateTime.Now };
            await gameService.AddAsync(game);

            // Act
            await gameService.DeleteAsync(gameId);
            var deletedGame = await repo.GetByIdAsync<Game>(gameId);

            // Assert
            Assert.Null(deletedGame);
        }

        [TearDown]
        public void TearDown()
        {
            DatabaseMock.Instance.Dispose();
        }
    }
}
