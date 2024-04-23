using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Cheat;
using GrandTheftInfo.Models;
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
            var model = cheats.GroupBy(x => x.GameId).OrderByDescending(g => g.First().GameName);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new CheatFormModel
            {
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
                return View("CustomError", new CustomErrorViewModel()
                {
                    Message = ex.Message,
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
                return View("CustomError", new CustomErrorViewModel()
                {
                    Message = "Cheat not found"
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
                return View("CustomError", new CustomErrorViewModel()
                {
                    Message = "Cheat not found"
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
            var cheat = await _cheatService.GetFormModelByIdAsync(id);

            if (cheat == null)
            {
                return View("CustomError", new CustomErrorViewModel()
                {
                    Message = "Mission not found"
                });
            }

            try
            {
                await _cheatService.DeleteAsync(id);
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
