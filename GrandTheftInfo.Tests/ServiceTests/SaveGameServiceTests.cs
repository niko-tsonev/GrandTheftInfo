using Azure.Storage.Blobs;
using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.SaveGame;
using GrandTheftInfo.Core.Services;
using GrandTheftInfo.Infrastructure.Data.Common;
using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GrandTheftInfo.Tests.ServiceTests
{
    public class SaveGameServiceTests
    {
        private ISaveGameService _saveGameService;
        private IRepository _repo;
        private Mock<BlobServiceClient> _blobServiceClientMock;
        private Mock<BlobContainerClient> _blobContainerClientMock;

        [SetUp]
        public void Setup()
        {
            _repo = new Repository(DatabaseMock.Instance);

            //blobServiceClient must be here but its not because VS prevents secrets pushing
            _blobContainerClientMock = new Mock<BlobContainerClient>(new Uri("https://youraccount.blob.core.windows.net/yourcontainer"), null);

            _saveGameService = new SaveGameService(_repo, _blobServiceClientMock.Object);

            DatabaseMock.Instance.Database.EnsureDeleted();
            DatabaseMock.Instance.Database.EnsureCreated();
        }

        [Test]
        public async Task GetFilesAsync_Returns_All_SaveGames()
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

            var saveGames = new List<SaveGame>
            {
                new SaveGame { Id = 1, FileName = "File1", Description = "Description 1", BlobUri = "BlobUri1", GameId = 1, Game = game },
                new SaveGame { Id = 2, FileName = "File2", Description = "Description 2", BlobUri = "BlobUri2", GameId = 1, Game = game }
            };

            foreach (var saveGame in saveGames)
            {
                await _repo.AddAsync(saveGame);
            }
            await _repo.SaveChangesAsync();

            // Act
            var result = await _saveGameService.GetFilesAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(saveGames.Count));

            foreach (var expectedSaveGame in saveGames)
            {
                var actualSaveGame = result.FirstOrDefault(s => s.Id == expectedSaveGame.Id);
                Assert.NotNull(actualSaveGame);
                Assert.That(actualSaveGame.FileName, Is.EqualTo(expectedSaveGame.FileName));
                Assert.That(actualSaveGame.Description, Is.EqualTo(expectedSaveGame.Description));
                Assert.That(actualSaveGame.BlobUri, Is.EqualTo(expectedSaveGame.BlobUri));
                Assert.That(actualSaveGame.GameName, Is.EqualTo(expectedSaveGame.Game.Name));
                Assert.That(actualSaveGame.GameId, Is.EqualTo(expectedSaveGame.Game.Id));
            }
        }

        [Test]
        public async Task GetModelByIdAsync_Returns_Correct_SaveGame_Model()
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

            var saveGameId = 1;
            var saveGame = new SaveGame { Id = saveGameId, FileName = "TestFile", Description = "Test Description", BlobUri = "TestBlobUri", GameId = 1, Game = game };
            await _repo.AddAsync(saveGame);
            await _repo.SaveChangesAsync();

            // Act
            var result = await _saveGameService.GetModelByIdAsync(saveGameId);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.FileName, Is.EqualTo(saveGame.FileName));
            Assert.That(result.Description, Is.EqualTo(saveGame.Description));
        }

        [Test]
        public async Task EditAsync_Updates_Existing_SaveGame()
        {
            // Arrange
            var saveGameId = 1;
            var saveGame = new SaveGame { Id = saveGameId, FileName = "TestFile", Description = "Test Description", BlobUri = "TestBlobUri", GameId = 1 };
            await _repo.AddAsync(saveGame);
            await _repo.SaveChangesAsync();

            var model = new SaveGameEditModel
            {
                Id = saveGameId,
                Description = "Edited Description",
                GameId = 2
            };

            // Act
            await _saveGameService.EditAsync(saveGameId, model);
            var updatedSaveGame = await _repo.GetByIdAsync<SaveGame>(saveGameId);

            // Assert
            Assert.NotNull(updatedSaveGame);
            Assert.That(updatedSaveGame.Description, Is.EqualTo("Edited Description"));
            Assert.That(updatedSaveGame.GameId, Is.EqualTo(2));
        }

        [TearDown]
        public void TearDown()
        {
            DatabaseMock.Instance.Dispose();
        }
    }
}
