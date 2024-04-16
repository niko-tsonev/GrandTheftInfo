using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Cheat;
using GrandTheftInfo.Core.Services;
using GrandTheftInfo.Infrastructure.Data.Models;
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

            return View(cheats);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new CheatFormModel();
            model.Games = await GetAllGamesInfo();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CheatFormModel model)
        {
            if (!ModelState.IsValid)
            {
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
                return this.View(model);
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
            var mission = await _cheatService.GetFormModelByIdAsync(id);

            if (mission == null)
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
