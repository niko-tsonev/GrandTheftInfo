using GrandTheftInfo.Controllers;
using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Game;
using GrandTheftInfo.Core.Models.Song;
using GrandTheftInfo.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrandTheftInfo.Tests.Controllers
{
    [TestFixture]
    public class SongControllerTests
    {
        private SongController _controller;
        private Mock<ISongService> _mockSongService;
        private Mock<IGameService> _mockGameService;

        [SetUp]
        public void Setup()
        {
            _mockSongService = new Mock<ISongService>();
            _mockGameService = new Mock<IGameService>();
            _controller = new SongController(_mockSongService.Object, _mockGameService.Object);
        }

        #region Index

        [Test]
        public async Task Index_ReturnsViewWithSongs()
        {
            // Arrange
            var games = new List<GameViewModel>
            {
                new GameViewModel { Id = 1, Name = "Game 1"},
                new GameViewModel { Id = 2, Name = "Game 2"}
            };
            var songs = new List<SongViewModel>();
            _mockGameService.Setup(x => x.AllAsync()).ReturnsAsync(games);
            _mockSongService.Setup(x => x.AllAsync()).ReturnsAsync(songs);

            // Act
            var result = await _controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<IEnumerable<IGrouping<int, SongViewModel>>>(result.Model);
        }

        [Test]
        public async Task Index_ReturnsViewWithNotFoundCustomError_WhenNoGamesExist()
        {
            // Arrange
            _mockGameService.Setup(x => x.AllAsync()).ReturnsAsync(new List<GameViewModel>());

            // Act
            var result = await _controller.Index() as ViewResult;
            var model = result.Model as CustomErrorViewModel;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("404CustomError", result.ViewName);
            Assert.IsNotNull(model);
            Assert.AreEqual("Games not found!", model.Message);
        }

        #endregion

        #region Add

        [Test]
        public async Task AddSongWithRadio_Get_ReturnsViewWithModel()
        {
            // Arrange
            int gameId = 1;
            var games = new List<GameViewModel>
            {
                new GameViewModel { Id = 1, Name = "Game 1"},
                new GameViewModel { Id = 2, Name = "Game 2"}
            };
            _mockGameService.Setup(x => x.AllAsync()).ReturnsAsync(games);

            // Act
            var result = await _controller.AddSongWithRadio(gameId) as ViewResult;
            var model = result.Model as SongFormModel;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(model);
            Assert.That(model.GameId, Is.EqualTo(gameId));
            Assert.That(model.Games.Count(), Is.EqualTo(games.Count()));
        }

        [Test]
        public async Task Add_Get_ReturnsViewWithModel()
        {
            // Arrange
            var radioName = "RadioName";
            _mockSongService.Setup(x => x.GetRadioImageByName(radioName)).ReturnsAsync("RadioImageUrl");
            _mockGameService.Setup(x => x.AllAsync()).ReturnsAsync(new List<GameViewModel>());

            // Act
            var result = await _controller.Add(radioName) as ViewResult;
            var model = result.Model as SongFormModel;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(model);
            Assert.AreEqual(radioName, model.Radio);
        }

        [Test]
        public async Task Add_Post_WithValidModel_ReturnsRedirectToIndex()
        {
            // Arrange
            var model = new SongFormModel
            {
                Name = "TestName",
                VideoUrl = "TestVideoUrl",
                Radio = "TestRadio",
                GameId = 1
            };
            _mockSongService.Setup(x => x.AddAsync(model)).ReturnsAsync(1);

            // Act
            var result = await _controller.Add(model) as RedirectToActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.ActionName, Is.EqualTo("Index"));
        }

        [Test]
        public async Task Add_Post_WithInvalidModel_ReturnsView()
        {
            // Arrange
            var model = new SongFormModel();
            _controller.ModelState.AddModelError("Name", "Name is required");

            // Act
            var result = await _controller.Add(model) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Model, Is.EqualTo(model));
        }

        [Test]
        public async Task Add_Post_ThrowsException_ReturnsBadRequestView()
        {
            // Arrange
            var model = new SongFormModel();
            _mockSongService.Setup(x => x.AddAsync(model)).Throws(new Exception());

            // Act
            var result = await _controller.Add(model) as ViewResult;
            var errorModel = result.Model as CustomErrorViewModel;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.ViewName, Is.EqualTo("500CustomError"));
            Assert.IsNotNull(errorModel);
        }

        #endregion

        #region Edit

        [Test]
        public async Task Edit_Get_WithValidId_ReturnsViewWithModel()
        {
            // Arrange
            int id = 1;
            var song = new SongFormModel
            {
                Name = "TestName",
                VideoUrl = "TestVideoUrl",
                Radio = "TestRadio",
                GameId = 1
            };
            _mockSongService.Setup(x => x.GetFormModelByIdAsync(id)).ReturnsAsync(song);

            // Act
            var result = await _controller.Edit(id) as ViewResult;
            var model = result.Model as SongFormModel;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(model);
            Assert.That(model.Name, Is.EqualTo(song.Name));
            Assert.That(model.VideoUrl, Is.EqualTo(song.VideoUrl));
            Assert.That(model.Radio, Is.EqualTo(song.Radio));
            Assert.That(model.GameId, Is.EqualTo(song.GameId));
        }

        [Test]
        public async Task Edit_Get_WithInvalidId_ReturnsViewWithNotFoundCustomError()
        {
            // Arrange
            int id = -1;

            // Act
            var result = await _controller.Edit(id) as ViewResult;
            var errorModel = result.Model as CustomErrorViewModel;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("404CustomError", result.ViewName);
            Assert.IsNotNull(errorModel);
            Assert.AreEqual("Song not found!", errorModel.Message);
        }

        [Test]
        public async Task Edit_Post_WithValidModel_ReturnsRedirectToIndex()
        {
            // Arrange
            int id = 1;
            var model = new SongFormModel
            {
                Name = "TestName",
                VideoUrl = "TestVideoUrl",
                Radio = "TestRadio",
                GameId = 1
            };
            _mockSongService.Setup(x => x.GetFormModelByIdAsync(id)).ReturnsAsync(model);

            _mockSongService.Setup(x => x.EditAsync(id, model)).Returns(Task.CompletedTask);

            // Act
            var result = await _controller.Edit(id, model) as RedirectToActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.ActionName, Is.EqualTo("Index"));
        }

        [Test]
        public async Task Edit_Post_WithInvalidModel_ReturnsViewWithNotFound()
        {
            // Arrange
            int id = 1;
            var model = new SongFormModel
            {
                Name = "TestName",
                VideoUrl = "TestVideoUrl",
                Radio = "TestRadio",
                GameId = 1
            };

            // Act
            var result = await _controller.Edit(id, model) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.ViewName, Is.EqualTo("404CustomError"));
        }

        [Test]
        public async Task Edit_Post_ThrowsException_ReturnsBadRequestView()
        {
            // Arrange
            int id = 1; // Provide a valid ID
            var model = new SongFormModel();
            _mockSongService.Setup(x => x.GetFormModelByIdAsync(id)).ReturnsAsync(model);
            _mockSongService.Setup(x => x.EditAsync(id, model)).Throws(new Exception());

            // Act
            var result = await _controller.Edit(id, model) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.ViewName, Is.EqualTo("500CustomError"));
        }

        #endregion

        #region Delete

        [Test]
        public async Task Delete_Post_WithValidId_ReturnsRedirectToIndex()
        {
            // Arrange
            int id = 1;
            var model = new SongFormModel
            {
                Name = "TestName",
                VideoUrl = "TestVideoUrl",
                Radio = "TestRadio",
                GameId = 1
            };
            _mockSongService.Setup(x => x.GetFormModelByIdAsync(id)).ReturnsAsync(model);

            _mockSongService.Setup(x => x.DeleteAsync(id)).Returns(Task.CompletedTask);

            // Act
            var result = await _controller.Delete(id) as RedirectToActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ActionName);
        }

        [Test]
        public async Task Delete_Post_WithInvalidId_ReturnsViewWithNotFound()
        {
            // Arrange
            int id = 1;

            // Act
            var result = await _controller.Delete(id) as ViewResult;
            var errorModel = result.Model as CustomErrorViewModel;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.ViewName, Is.EqualTo("404CustomError"));
            Assert.IsNotNull(errorModel);
            Assert.That(errorModel.Message, Is.EqualTo("Song not found!"));
        }

        [Test]
        public async Task Delete_Post_ThrowsException_ReturnsBadRequestView()
        {
            // Arrange
            int id = 1;
            var model = new SongFormModel
            {
                Name = "TestName",
                VideoUrl = "TestVideoUrl",
                Radio = "TestRadio",
                GameId = 1
            };
            _mockSongService.Setup(x => x.GetFormModelByIdAsync(id)).ReturnsAsync(model);
            _mockSongService.Setup(x => x.DeleteAsync(id)).Throws(new Exception());

            // Act
            var result = await _controller.Delete(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("500CustomError", result.ViewName);
        }

        #endregion
    }
}
