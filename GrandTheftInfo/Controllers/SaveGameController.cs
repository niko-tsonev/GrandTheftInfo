using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.SaveGame;
using GrandTheftInfo.Models;
using static GrandTheftInfo.Core.Constants.CustomErrorConstants;
using Microsoft.AspNetCore.Mvc;

namespace GrandTheftInfo.Controllers
{
    public class SaveGameController : BaseController
    {
        private readonly ISaveGameService _saveGameService;

        public SaveGameController(ISaveGameService saveGameService, IGameService gameService)
            :base(gameService)
        {
            _saveGameService = saveGameService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var allFiles = await _saveGameService.GetFilesAsync();
            var games = await GetAllGamesInfo();

            if (games == null || !games.Any())
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = GamesNotFound
                });
            }

            var model = allFiles.GroupBy(x => x.GameId).OrderByDescending(g => g.First().GameName);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add(int gameId)
        {
            var model = new SaveGameAddModel()
            {
                GameId = gameId,
                Games = await GetAllGamesInfo()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SaveGameAddModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Games = await GetAllGamesInfo();
                return View(model);
            }

            if (await _saveGameService.FileExistsInCloud(model.File.FileName))
            {
                ViewBag.ErrorMessage = FilePresentInCloud;
                model.Games = await GetAllGamesInfo();
                return View(model);
            }

            try
            {
                await _saveGameService.UploadFileAsync(model);
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
            var saveGame = await _saveGameService.GetModelByIdAsync(id);

            if (saveGame == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = SaveGameNotFound
                });
            }

            var viewModel = new SaveGameEditModel()
            {
                FileName = saveGame.FileName,
                Description = saveGame.Description,
                GameId = saveGame.GameId,
                Games = await GetAllGamesInfo()
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, SaveGameEditModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Games = await GetAllGamesInfo();
                return View(model);
            }

            try
            {
                await _saveGameService.EditAsync(id, model);
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
            var saveGame = await _saveGameService.GetModelByIdAsync(id);

            if (saveGame == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = SaveGameNotFound
                });
            }

            if (!await _saveGameService.FileExistsInCloud(saveGame.FileName))
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = FileNotPresentInCloud
                });
            }

            try
            {
                await _saveGameService.DeleteAsync(id);
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
