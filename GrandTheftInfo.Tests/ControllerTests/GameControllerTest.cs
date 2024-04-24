using GrandTheftInfo.Controllers;
using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Game;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace GrandTheftInfo.Tests.Controllers
{
    [TestFixture]
    public class GameControllerTests
    {
        private GameController _controller;
        private Mock<IGameService> _mockGameService;
        private GameFormModel model = new GameFormModel();

        [SetUp]
        public void Setup()
        {
            _mockGameService = new Mock<IGameService>();
            _controller = new GameController(_mockGameService.Object);
        }

        #region Index

        [Test]
        public async Task Index_ReturnsViewWithGames()
        {
            // Arrange
            var games = new List<GameViewModel>(); // Initialize with some dummy data
            _mockGameService.Setup(x => x.AllAsync()).ReturnsAsync(games);

            // Act
            var result = await _controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(games, result.Model);
        }

        #endregion

        #region Add

        #region AddGet

        [Test]
        public void Add_Get_ReturnsView()
        {
            // Act
            var result = _controller.Add() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        #endregion

        #region AddPost

        [Test]
        public async Task Add_Post_WithValidModel_ReturnsRedirectToIndex()
        {
            // Arrange
            var model = new GameFormModel
            {
                Name = "TestName",
                Description = "TestDescription",
                ImageUrl = "TestUrl",
                DatePublished = DateTime.Now
            }; // Create an expected model with some values
            _mockGameService.Setup(x => x.AddAsync(model)).ReturnsAsync(1);

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
            int id = 1; 
            var model = new GameFormModel
            {
                Name = "TestName",
                Description = "TestDescription",
                ImageUrl = "TestUrl",
                DatePublished = DateTime.Now
            }; 
            _mockGameService.Setup(x => x.GetFormModelByIdAsync(id)).ReturnsAsync(model);
            _controller.ModelState.AddModelError("Name", "Name is required");

            // Act
            var result = await _controller.Add(model) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Model, Is.EqualTo(model));
        }

        [Test]
        public async Task Add_Post_WithInvalidModel_ReturnsViewWithBadRequest()
        {
            // Arrange
            var model = new GameFormModel
            {
                Name = "TestName",
                Description = "TestDescription",
                ImageUrl = "TestUrl",
                DatePublished = DateTime.Now
            };
            _mockGameService.Setup(x => x.AddAsync(model)).Throws(new Exception());

            // Act
            var result = await _controller.Add(model) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("500CustomError", result.ViewName);
        }

        #endregion

        #endregion

        #region Edit

        #region EditGet

        [Test]
        public async Task Edit_Get_WithValidId_ReturnsViewWithEditModel()
        {
            // Arrange
            int id = 1; // Provide a valid ID
            var expectedModel = new GameFormModel
            {
                Name = "TestName",
                Description = "TestDescription",
                ImageUrl = "TestUrl",
                DatePublished = DateTime.Now
            }; // Create an expected model with some values
            _mockGameService.Setup(x => x.GetFormModelByIdAsync(id)).ReturnsAsync(expectedModel);

            // Act
            var result = await _controller.Edit(id) as ViewResult;
            var actualModel = result.Model as GameFormModel;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(actualModel.Name, Is.EqualTo(expectedModel.Name));
            Assert.That(actualModel.Description, Is.EqualTo(expectedModel.Description));
            Assert.That(actualModel.ImageUrl, Is.EqualTo(expectedModel.ImageUrl));
            Assert.That(actualModel.DatePublished, Is.EqualTo(expectedModel.DatePublished));
        }

        [Test]
        public async Task Edit_Get_WithInvalidId_ReturnsViewWithNotFound()
        {
            // Arrange
            int id = -1; // Provide an invalid ID

            // Act
            var result = await _controller.Edit(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("404CustomError", result.ViewName);
        }

        #endregion

        #region EditPost

        [Test]
        public async Task Edit_Post_WithValidModel_ReturnsRedirectToIndex()
        {
            // Arrange
            int id = 1; // Provide a valid ID
            var model = new GameFormModel
            {
                Name = "TestName",
                Description = "TestDescription",
                ImageUrl = "TestUrl",
                DatePublished = DateTime.Now
            }; // Create an expected model with some values
            _mockGameService.Setup(x => x.GetFormModelByIdAsync(id)).ReturnsAsync(model);

            _mockGameService.Setup(x => x.EditAsync(id, model)).Returns(Task.CompletedTask);

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
            var model = new GameFormModel
            {
                Name = "TestName",
                Description = "TestDescription",
                ImageUrl = "TestUrl",
                DatePublished = DateTime.Now
            };

            // Act
            var result = await _controller.Edit(id, model) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("404CustomError", result.ViewName);
        }

        [Test]
        public async Task Edit_Post_WithInvalidModel_ReturnsView()
        {
            // Arrange
            int id = 1; // Provide a valid ID
            var model = new GameFormModel
            {
                Name = "TestName",
                Description = "TestDescription",
                ImageUrl = "TestUrl",
                DatePublished = DateTime.Now
            }; // Create an expected model with some values
            _mockGameService.Setup(x => x.GetFormModelByIdAsync(id)).ReturnsAsync(model);
            _controller.ModelState.AddModelError("Name", "Name is required");

            // Act
            var result = await _controller.Add(model) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Model, Is.EqualTo(model));
        }

        [Test]
        public async Task Edit_Post_WithInvalidModel_ReturnsViewWitBadRequest()
        {
            // Arrange
            int id = 1; // Provide a valid ID
            var model = new GameFormModel
            {
                Name = "TestName",
                Description = "TestDescription",
                ImageUrl = "TestUrl",
                DatePublished = DateTime.Now
            };
            _mockGameService.Setup(x => x.GetFormModelByIdAsync(id)).ReturnsAsync(model);
            _mockGameService.Setup(x => x.EditAsync(id, model)).Throws(new Exception());

            // Act
            var result = await _controller.Edit(id, model) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.ViewName, Is.EqualTo("500CustomError"));
        }

        #endregion

        #endregion

        #region Delete

        [Test]
        public async Task Delete_Post_WithValidId_ReturnsRedirectToIndex()
        {
            // Arrange
            int id = 1;
            var model = new GameFormModel
            {
                Name = "TestName",
                Description = "TestDescription",
                ImageUrl = "TestUrl",
                DatePublished = DateTime.Now
            }; 
            _mockGameService.Setup(x => x.GetFormModelByIdAsync(id)).ReturnsAsync(model);

            _mockGameService.Setup(x => x.DeleteAsync(id)).Returns(Task.CompletedTask);

            // Act
            var result = await _controller.Delete(id) as RedirectToActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ActionName);
        }

        [Test]
        public async Task Delete_Post_WithInalidId_ReturnsViewWithNotFound()
        {
            // Arrange
            int id = 1;

            // Act
            var result = await _controller.Delete(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("404CustomError", result.ViewName);
        }

        [Test]
        public async Task Delete_Post_WithInalidId_ReturnsBadRequest()
        {
            // Arrange
            int id = 1;
            var model = new GameFormModel
            {
                Name = "TestName",
                Description = "TestDescription",
                ImageUrl = "TestUrl",
                DatePublished = DateTime.Now
            };
            _mockGameService.Setup(x => x.GetFormModelByIdAsync(id)).ReturnsAsync(model);
            _mockGameService.Setup(x => x.DeleteAsync(id)).Throws(new Exception());

            // Act
            var result = await _controller.Delete(id) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("500CustomError", result.ViewName);
        }

        #endregion
    }
}
