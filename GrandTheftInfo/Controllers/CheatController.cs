using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Cheat;
using GrandTheftInfo.Models;
using static GrandTheftInfo.Core.Constants.CustomErrorConstants;
using Microsoft.AspNetCore.Mvc;

namespace GrandTheftInfo.Controllers
{
    public class CheatController : BaseController
    {
        private readonly ICheatService _cheatService;

        public CheatController(ICheatService cheatService, IGameService gameService) 
            : base(gameService)
        {
            _cheatService = cheatService;
        }

        public async Task<IActionResult> Index()
        {
            var cheats = await _cheatService.AllAsync();
            var games = await GetAllGamesInfo();

            if (games == null || !games.Any())
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = GamesNotFound
                });
            }

            var model = cheats.GroupBy(x => x.GameId).OrderByDescending(g => g.First().GameName);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add(int gameId)
        {
            var model = new CheatFormModel
            {
                GameId = gameId,
                Games = await GetAllGamesInfo()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CheatFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Games = await GetAllGamesInfo();
                return View(model);
            }

            try
            {
                await _cheatService.AddAsync(model);
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
            var cheat = await _cheatService.GetFormModelByIdAsync(id);

            if (cheat == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = CheatNotFound
                });
            }

            var editModel = new CheatFormModel()
            {
                Name = cheat.Name,
                CheatCode = cheat.CheatCode,
                Platform = cheat.Platform,
                GameId = cheat.GameId,
                Games = await GetAllGamesInfo(),
            };

            return View(editModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CheatFormModel model)
        {
            var cheat = await _cheatService.GetFormModelByIdAsync(id);

            if (cheat == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = CheatNotFound
                });
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await _cheatService.EditAsync(id, model);
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
            var cheat = await _cheatService.GetFormModelByIdAsync(id);

            if (cheat == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = CheatNotFound
                });
            }

            try
            {
                await _cheatService.DeleteAsync(id);
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
