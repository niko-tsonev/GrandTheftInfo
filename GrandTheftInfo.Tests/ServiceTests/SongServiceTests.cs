using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Song;
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
    public class SongServiceTests
    {
        private ISongService _songService;
        private IRepository _repo;

        [SetUp]
        public void Setup()
        {
            _repo = new Repository(DatabaseMock.Instance);
            _songService = new SongService(_repo);

            DatabaseMock.Instance.Database.EnsureDeleted();
            DatabaseMock.Instance.Database.EnsureCreated();
        }

        [Test]
        public async Task AllAsync_Returns_All_Songs()
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

            var songs = new List<Song>
            {
                new Song { Id = 1, Name = "Song 1", Radio = "Radio 1", RadioImageUrl = "RadioImageUrl 1", VideoUrl = "VideoUrl 1", GameId = 1, Game = game },
                new Song { Id = 2, Name = "Song 2", Radio = "Radio 2", RadioImageUrl = "RadioImageUrl 2", VideoUrl = "VideoUrl 2", GameId = 2, Game = game }
            };

            foreach (var song in songs)
            {
                await _repo.AddAsync(song);
            }
            await _repo.SaveChangesAsync();

            // Act
            var result = await _songService.AllAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(songs.Count));

            foreach (var expectedSong in songs)
            {
                var actualSong = result.FirstOrDefault(s => s.Id == expectedSong.Id);
                Assert.NotNull(actualSong);
                Assert.That(actualSong.Name, Is.EqualTo(expectedSong.Name));
                Assert.That(actualSong.Radio, Is.EqualTo(expectedSong.Radio));
                Assert.That(actualSong.RadioImageUrl, Is.EqualTo(expectedSong.RadioImageUrl));
                Assert.That(actualSong.VideoUrl, Is.EqualTo(expectedSong.VideoUrl));
                Assert.That(actualSong.GameId, Is.EqualTo(expectedSong.GameId));
            }
        }

        [Test]
        public async Task AddAsync_Adds_New_Song()
        {
            // Arrange
            var newSong = new SongFormModel
            {
                Name = "New Song",
                Radio = "New Radio",
                RadioImageUrl = "New RadioImageUrl",
                VideoUrl = "New VideoUrl",
                GameId = 1
            };

            // Act
            var songId = await _songService.AddAsync(newSong);
            var addedSong = await _repo.GetByIdAsync<Song>(songId);

            // Assert
            Assert.NotNull(addedSong);
            Assert.That(addedSong.Name, Is.EqualTo(newSong.Name));
            Assert.That(addedSong.Radio, Is.EqualTo(newSong.Radio));
            Assert.That(addedSong.RadioImageUrl, Is.EqualTo(newSong.RadioImageUrl));
            Assert.That(addedSong.VideoUrl, Is.EqualTo(newSong.VideoUrl));
            Assert.That(addedSong.GameId, Is.EqualTo(newSong.GameId));
        }

        [Test]
        public async Task GetFormModelByIdAsync_Returns_Correct_Song_Form_Model()
        {
            // Arrange
            var songId = 1;
            var song = new Song { Id = songId, Name = "Test Song", Radio = "Test Radio", RadioImageUrl = "Test RadioImageUrl", VideoUrl = "Test VideoUrl", GameId = 1 };
            await _repo.AddAsync(song);
            await _repo.SaveChangesAsync();

            // Act
            var result = await _songService.GetFormModelByIdAsync(songId);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Name, Is.EqualTo(song.Name));
            Assert.That(result.Radio, Is.EqualTo(song.Radio));
            Assert.That(result.RadioImageUrl, Is.EqualTo(song.RadioImageUrl));
            Assert.That(result.VideoUrl, Is.EqualTo(song.VideoUrl));
            Assert.That(result.GameId, Is.EqualTo(song.GameId));
        }

        [Test]
        public async Task EditAsync_Updates_Existing_Song()
        {
            // Arrange
            var songId = 1;
            var song = new Song { Id = songId, Name = "Test Song", Radio = "Test Radio", RadioImageUrl = "Test RadioImageUrl", VideoUrl = "Test VideoUrl", GameId = 1 };
            await _repo.AddAsync(song);
            await _repo.SaveChangesAsync();

            var editedSong = new SongFormModel
            {
                Id = songId,
                Name = "Edited Song",
                Radio = "Edited Radio",
                RadioImageUrl = "Edited RadioImageUrl",
                VideoUrl = "Edited VideoUrl",
                GameId = 2
            };

            // Act
            await _songService.EditAsync(songId, editedSong);
            var updatedSong = await _repo.GetByIdAsync<Song>(songId);

            // Assert
            Assert.NotNull(updatedSong);
            Assert.That(updatedSong.Name, Is.EqualTo(editedSong.Name));
            Assert.That(updatedSong.Radio, Is.EqualTo(editedSong.Radio));
            Assert.That(updatedSong.RadioImageUrl, Is.EqualTo(editedSong.RadioImageUrl));
            Assert.That(updatedSong.VideoUrl, Is.EqualTo(editedSong.VideoUrl));
            Assert.That(updatedSong.GameId, Is.EqualTo(editedSong.GameId));
        }

        [Test]
        public async Task DeleteAsync_Removes_Song()
        {
            // Arrange
            var songId = 1;
            var song = new Song { Id = songId, Name = "Test Song", Radio = "Test Radio", RadioImageUrl = "Test RadioImageUrl", VideoUrl = "Test VideoUrl", GameId = 1 };
            await _repo.AddAsync(song);
            await _repo.SaveChangesAsync();

            // Act
            await _songService.DeleteAsync(songId);
            var deletedSong = await _repo.GetByIdAsync<Song>(songId);

            // Assert
            Assert.Null(deletedSong);
        }

        [TearDown]
        public void TearDown()
        {
            DatabaseMock.Instance.Dispose();
        }
    }
}
