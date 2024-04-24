using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Mission;
using GrandTheftInfo.Core.Services;
using GrandTheftInfo.Infrastructure.Data;
using GrandTheftInfo.Infrastructure.Data.Common;
using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Tests.ServiceTests
{
    public class MissionServiceTest
    {
        private IMissionService _missionService;
        private IRepository _repo;

        [SetUp]
        public void Setup()
        {
            GrandTheftInfoDbContext.IsUnitTest = true;

            _repo = new Repository(DatabaseMock.Instance);
            _missionService = new MissionService(_repo);

            DatabaseMock.Instance.Database.EnsureDeleted();
            DatabaseMock.Instance.Database.EnsureCreated();
        }

        [Test]
        public async Task AllAsync_Returns_All_Missions()
        {
            var game = new Game()
            {
                Id = 1,
                Name = "Game",
                Description = "Desc",
                DatePublished = DateTime.Now,
                ImageUrl = "ImgUrl"
            };

            // Arrange
            var missions = new List<Mission>
            {
                new Mission { Id = 1, Name = "Mission 1", Description = "Description 1", PlaytroughUrl = "Url 1", GameId = 1, Game = game },
                new Mission { Id = 2, Name = "Mission 2", Description = "Description 2", PlaytroughUrl = "Url 2", GameId = 2, Game = game  }
            };

            foreach (var mission in missions)
            {
                await _repo.AddAsync(mission);
            }
            await _repo.SaveChangesAsync();

            // Act
            var result = await _missionService.AllAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(missions.Count));

            foreach (var expectedMission in missions)
            {
                var actualMission = result.FirstOrDefault(m => m.Id == expectedMission.Id);
                Assert.NotNull(actualMission);
                Assert.That(actualMission.Name, Is.EqualTo(expectedMission.Name));
                Assert.That(actualMission.Description, Is.EqualTo(expectedMission.Description));
                Assert.That(actualMission.PlaytroughUrl, Is.EqualTo(expectedMission.PlaytroughUrl));
                Assert.That(actualMission.GameId, Is.EqualTo(expectedMission.GameId));
            }
        }

        [Test]
        public async Task AddAsync_Adds_New_Mission()
        {
            // Arrange
            var newMission = new MissionFormModel
            {
                Name = "New Mission",
                Description = "New Description",
                PlaytroughUrl = "New URL",
                GameId = 1
            };

            // Act
            var missionId = await _missionService.AddAsync(newMission);
            var addedMission = await _repo.GetByIdAsync<Mission>(missionId);

            // Assert
            Assert.NotNull(addedMission);
            Assert.AreEqual(newMission.Name, addedMission.Name);
            Assert.AreEqual(newMission.Description, addedMission.Description);
            Assert.AreEqual(newMission.PlaytroughUrl, addedMission.PlaytroughUrl);
            Assert.AreEqual(newMission.GameId, addedMission.GameId);
        }

        [Test]
        public async Task GetFormModelByIdAsync_Returns_Correct_Mission_Form_Model()
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

            var missionId = 1;
            var mission = new Mission { Id = missionId, Name = "Test Mission", Description = "Test Description", PlaytroughUrl = "Test URL", GameId = 1, Game = game };
            await _repo.AddAsync(mission);
            await _repo.SaveChangesAsync();

            // Act
            var result = await _missionService.GetFormModelByIdAsync(missionId);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(mission.Name, result.Name);
            Assert.AreEqual(mission.Description, result.Description);
            Assert.AreEqual(mission.PlaytroughUrl, result.PlaytroughUrl);
            Assert.AreEqual(mission.GameId, result.GameId);
        }

        [Test]
        public async Task EditAsync_Updates_Existing_Mission()
        {
            // Arrange
            var missionId = 1;
            var mission = new Mission { Id = missionId, Name = "Test Mission", Description = "Test Description", PlaytroughUrl = "Test URL", GameId = 1 };
            await _repo.AddAsync(mission);
            await _repo.SaveChangesAsync();

            var editedMission = new MissionFormModel
            {
                Id = missionId,
                Name = "Edited Mission",
                Description = "Edited Description",
                PlaytroughUrl = "Edited URL",
                GameId = 2
            };

            // Act
            await _missionService.EditAsync(missionId, editedMission);
            var updatedMission = await _repo.GetByIdAsync<Mission>(missionId);

            // Assert
            Assert.NotNull(updatedMission);
            Assert.AreEqual(editedMission.Name, updatedMission.Name);
            Assert.AreEqual(editedMission.Description, updatedMission.Description);
            Assert.AreEqual(editedMission.PlaytroughUrl, updatedMission.PlaytroughUrl);
            Assert.AreEqual(editedMission.GameId, updatedMission.GameId);
        }

        [Test]
        public async Task DeleteAsync_Removes_Mission()
        {
            // Arrange
            var missionId = 1;
            var mission = new Mission { Id = missionId, Name = "Test Mission", Description = "Test Description", PlaytroughUrl = "Test URL", GameId = 1 };
            await _repo.AddAsync(mission);
            await _repo.SaveChangesAsync();

            // Act
            await _missionService.DeleteAsync(missionId);
            var deletedMission = await _repo.GetByIdAsync<Mission>(missionId);

            // Assert
            Assert.Null(deletedMission);
        }

        [TearDown]
        public void TearDown()
        {
            DatabaseMock.Instance.Dispose();
        }
    }
}
