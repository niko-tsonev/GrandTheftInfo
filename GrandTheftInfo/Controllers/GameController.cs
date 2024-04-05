using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Game;
using GrandTheftInfo.Core.Services;
using GrandTheftInfo.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrandTheftInfo.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var games = await _gameService.AllAsync();

            return View(games);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(GameFormModel model)
        {
            if (!ModelState.IsValid) 
            {
                return View(model);
            }

            try
            {
               await _gameService.AddAsync(model);
            }
            catch (Exception ex)
            {
                return View("CustomError", new CustomErrorViewModel() 
                {
                    Message = ex.Message 
                });
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var game = await _gameService.GetByIdAsync(id);

            if (game == null)
            {
                return View("CustomError", new CustomErrorViewModel()
                {
                    Message = "Game not found"
                });
            }

            var editModel = new GameFormModel()
            {
                Id = game.Id,
                Name = game.Name,
                Description = game.Description,
                ImageUrl = game.ImageUrl,
                YearPublished = game.YearPublished,
                MissionCount = game.MissionCount
            };

            return View(editModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, GameFormModel model)
        {
            var game = await _gameService.GetByIdAsync(id);

            if (game == null)
            {
                return View("CustomError", new CustomErrorViewModel()
                {
                    Message = "Game not found"
                });
            }

            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                await _gameService.EditAsync(id, model);
            }
            catch (Exception ex)
            {
                return View("CustomError", new CustomErrorViewModel()
                {
                    Message = ex.Message
                });
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var game = await _gameService.GetByIdAsync(id);

            if (game == null)
            {
                return View("CustomError", new CustomErrorViewModel()
                {
                    Message = "Game not found"
                });
            }

            try
            {
                await _gameService.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                return View("CustomError", new CustomErrorViewModel()
                {
                    Message = ex.Message
                });
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
