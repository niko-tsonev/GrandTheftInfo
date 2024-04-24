using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.EasterEgg;
using GrandTheftInfo.Core.Services;
using GrandTheftInfo.Infrastructure.Data.Common;
using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrandTheftInfo.Tests.ServiceTests
{
    public class EasterEggServiceTest
    {
        private IEasterEggService _easterEggService;
        private IRepository _repo;

        [SetUp]
        public void Setup()
        {
            _repo = new Repository(DatabaseMock.Instance);
            _easterEggService = new EasterEggService(_repo);

            DatabaseMock.Instance.Database.EnsureDeleted();
            DatabaseMock.Instance.Database.EnsureCreated();
        }

        [Test]
        public async Task AllAsync_Returns_All_EasterEggs()
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

            var easterEggs = new List<EasterEgg>
            {
                new EasterEgg { Id = 1, Name = "EasterEgg 1", Description = "Description 1", ImageUrlOne = "Img1", ImageUrlTwo = "Img2", GameId = 1, Game = game },
                new EasterEgg { Id = 2, Name = "EasterEgg 2", Description = "Description 2", ImageUrlOne = "Img3", ImageUrlTwo = "Img4", GameId = 1, Game = game }
            };

            foreach (var easterEgg in easterEggs)
            {
                await _repo.AddAsync(easterEgg);
            }
            await _repo.SaveChangesAsync();

            // Act
            var result = await _easterEggService.AllAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(easterEggs.Count));

            foreach (var expectedEasterEgg in easterEggs)
            {
                var actualEasterEgg = result.FirstOrDefault(e => e.Id == expectedEasterEgg.Id);
                Assert.NotNull(actualEasterEgg);
                Assert.That(actualEasterEgg.Name, Is.EqualTo(expectedEasterEgg.Name));
                Assert.That(actualEasterEgg.Description, Is.EqualTo(expectedEasterEgg.Description));
                Assert.That(actualEasterEgg.ImageUrlOne, Is.EqualTo(expectedEasterEgg.ImageUrlOne));
                Assert.That(actualEasterEgg.ImageUrlTwo, Is.EqualTo(expectedEasterEgg.ImageUrlTwo));
                Assert.That(actualEasterEgg.GameName, Is.EqualTo(expectedEasterEgg.Game.Name));
                Assert.That(actualEasterEgg.GameId, Is.EqualTo(expectedEasterEgg.Game.Id));
            }
        }

        [Test]
        public async Task AddAsync_Adds_New_EasterEgg()
        {
            // Arrange
            var newEasterEgg = new EasterEggFormModel
            {
                Name = "New EasterEgg",
                Description = "New Description",
                ImageUrlOne = "New Img1",
                ImageUrlTwo = "New Img2",
                GameId = 1
            };

            // Act
            var easterEggId = await _easterEggService.AddAsync(newEasterEgg);
            var addedEasterEgg = await _repo.GetByIdAsync<EasterEgg>(easterEggId);

            // Assert
            Assert.NotNull(addedEasterEgg);
            Assert.That(addedEasterEgg.Name, Is.EqualTo(newEasterEgg.Name));
            Assert.That(addedEasterEgg.Description, Is.EqualTo(newEasterEgg.Description));
            Assert.That(addedEasterEgg.ImageUrlOne, Is.EqualTo(newEasterEgg.ImageUrlOne));
            Assert.That(addedEasterEgg.ImageUrlTwo, Is.EqualTo(newEasterEgg.ImageUrlTwo));
            Assert.That(addedEasterEgg.GameId, Is.EqualTo(newEasterEgg.GameId));
        }

        [Test]
        public async Task GetFormModelByIdAsync_Returns_Correct_EasterEgg_Form_Model()
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

            var easterEggId = 1;
            var easterEgg = new EasterEgg { Id = easterEggId, Name = "Test EasterEgg", Description = "Test Description", ImageUrlOne = "Img1", ImageUrlTwo = "Img2", GameId = 1, Game = game };
            await _repo.AddAsync(easterEgg);
            await _repo.SaveChangesAsync();

            // Act
            var result = await _easterEggService.GetFormModelByIdAsync(easterEggId);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Name, Is.EqualTo(easterEgg.Name));
            Assert.That(result.Description, Is.EqualTo(easterEgg.Description));
            Assert.That(result.ImageUrlOne, Is.EqualTo(easterEgg.ImageUrlOne));
            Assert.That(result.ImageUrlTwo, Is.EqualTo(easterEgg.ImageUrlTwo));
            Assert.That(result.GameId, Is.EqualTo(easterEgg.GameId));
        }

        [Test]
        public async Task EditAsync_Updates_Existing_EasterEgg()
        {
            // Arrange
            var easterEggId = 1;
            var easterEgg = new EasterEgg { Id = easterEggId, Name = "Test EasterEgg", Description = "Test Description", ImageUrlOne = "Img1", ImageUrlTwo = "Img2", GameId = 1 };
            await _repo.AddAsync(easterEgg);
            await _repo.SaveChangesAsync();

            var editedEasterEgg = new EasterEggFormModel
            {
                Id = easterEggId,
                Name = "Edited EasterEgg",
                Description = "Edited Description",
                ImageUrlOne = "Edited Img1",
                ImageUrlTwo = "Edited Img2",
                GameId = 2
            };

            // Act
            await _easterEggService.EditAsync(easterEggId, editedEasterEgg);
            var updatedEasterEgg = await _repo.GetByIdAsync<EasterEgg>(easterEggId);

            // Assert
            Assert.NotNull(updatedEasterEgg);
            Assert.That(updatedEasterEgg.Name, Is.EqualTo(editedEasterEgg.Name));
            Assert.That(updatedEasterEgg.Description, Is.EqualTo(editedEasterEgg.Description));
            Assert.That(updatedEasterEgg.ImageUrlOne, Is.EqualTo(editedEasterEgg.ImageUrlOne));
            Assert.That(updatedEasterEgg.ImageUrlTwo, Is.EqualTo(editedEasterEgg.ImageUrlTwo));
            Assert.That(updatedEasterEgg.GameId, Is.EqualTo(editedEasterEgg.GameId));
        }

        [Test]
        public async Task DeleteAsync_Removes_EasterEgg()
        {
            // Arrange
            var easterEggId = 1;
            var easterEgg = new EasterEgg { Id = easterEggId, Name = "Test EasterEgg", Description = "Test Description", ImageUrlOne = "Img1", ImageUrlTwo = "Img2", GameId = 1 };
            await _repo.AddAsync(easterEgg);
            await _repo.SaveChangesAsync();

            // Act
            await _easterEggService.DeleteAsync(easterEggId);
            var deletedEasterEgg = await _repo.GetByIdAsync<EasterEgg>(easterEggId);

            // Assert
            Assert.Null(deletedEasterEgg);
        }

        [TearDown]
        public void TearDown()
        {
            DatabaseMock.Instance.Dispose();
        }
    }
}
