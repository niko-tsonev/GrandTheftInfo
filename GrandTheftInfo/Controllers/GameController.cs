using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Game;
using GrandTheftInfo.Models;
using static GrandTheftInfo.Core.Constants.CustomErrorConstants;
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
                return View(BadRequestCustomError, new CustomErrorViewModel()
                {
                    Message = ex.Message
                });
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var game = await _gameService.GetFormModelByIdAsync(id);

            if (game == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = GameNotFound
                });
            }

            var editModel = new GameFormModel()
            {
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
            var game = await _gameService.GetFormModelByIdAsync(id);

            if (game == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = GameNotFound
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
                return View(BadRequestCustomError, new CustomErrorViewModel()
                {
                    Message = ex.Message
                });
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var game = await _gameService.GetFormModelByIdAsync(id);

            if (game == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = GameNotFound
                });
            }

            try
            {
                await _gameService.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                return View(BadRequestCustomError, new CustomErrorViewModel()
                {
                    Message = ex.Message
                });
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
