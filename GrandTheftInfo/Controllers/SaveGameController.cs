using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.SaveGame;
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
            var model = allFiles.GroupBy(x => x.GameId).OrderByDescending(g => g.First().GameName);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new SaveGameAddModel()
            {
                Games = await GetAllGamesInfo()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SaveGameAddModel model)
        {
            if (model.File == null || model.File.Length == 0)
            {
                ModelState.AddModelError("FilePath", "Please select a file.");
                return View();
            }

            await _saveGameService.UploadFileAsync(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var saveGame = await _saveGameService.GetModelByIdAsync(id);

            if (saveGame == null)
            {
                return NotFound();
            }

            var viewModel = new SaveGameEditModel()
            {
                FileName = saveGame.FileName,
                Description = saveGame.Description,
                UploadDate = saveGame.UploadDate,
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
                return View("Add", model);
            }

            try
            {
                await _saveGameService.EditAsync(id, model);
            }
            catch (ArgumentException)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var saveGame = await _saveGameService.SaveGameExists(id);

            if (!saveGame)
            {
                return NotFound();
            }

            await _saveGameService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
