using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Song;
using GrandTheftInfo.Core.Services;
using GrandTheftInfo.Infrastructure.Data.Models;
using GrandTheftInfo.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrandTheftInfo.Controllers
{
    public class SongController : BaseController
    {
        private readonly ISongService _songService;

        public SongController(ISongService songService, IGameService gameService)
            : base(gameService)
        {
            _songService = songService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var songs = await _songService.AllAsync();
            var model = songs.GroupBy(x => x.GameId).OrderByDescending(g => g.First().GameName);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add(string radioName)
        {
            var model = new SongFormModel()
            {
                Games = await GetAllGamesInfo(),
                Radio = radioName,
                RadioImageUrl = await _songService.GetRadioImageByName(radioName)

            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SongFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _songService.AddAsync(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var song = await _songService.GetFormModelByIdAsync(id);

            if (song == null)
            {
                return View("CustomError", new CustomErrorViewModel()
                {
                    Message = "Song not found"
                });
            }

            var editModel = new SongFormModel()
            {
                Name = song.Name,
                VideoUrl = song.VideoUrl,
                Radio = song.Radio,
                RadioImageUrl = song.RadioImageUrl,
                GameId = song.GameId,
                Games = await GetAllGamesInfo()
            };

            return View(editModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, SongFormModel model)
        {
            var song = await _songService.GetFormModelByIdAsync(id);

            if (song == null)
            {
                return View("CustomError", new CustomErrorViewModel()
                {
                    Message = "Song not found"
                });
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _songService.EditAsync(id, model);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var song = await _songService.GetFormModelByIdAsync(id);

            if (song == null)
            {
                return View("CustomError", new CustomErrorViewModel()
                {
                    Message = "Song not found"
                });
            }

            await _songService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
