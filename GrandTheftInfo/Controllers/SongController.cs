using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Song;
using GrandTheftInfo.Models;
using static GrandTheftInfo.Core.Constants.CustomErrorConstants;
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
            var games = await GetAllGamesInfo();

            if (games == null || !games.Any())
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = GamesNotFound
                });
            }

            var model = songs.GroupBy(x => x.GameId).OrderByDescending(g => g.First().GameName);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddSongWithRadio(int gameId)
        {
            var model = new SongFormModel()
            {
                GameId = gameId,
                Games = await GetAllGamesInfo(),
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add(string radioName)
        {
            var model = new SongFormModel()
            {
                Radio = radioName,
                RadioImageUrl = await _songService.GetRadioImageByName(radioName),
                Games = await GetAllGamesInfo(),
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

            try
            {
                await _songService.AddAsync(model);
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
            var song = await _songService.GetFormModelByIdAsync(id);

            if (song == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = SongNotFound
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
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = SongNotFound
                });
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await _songService.EditAsync(id, model);
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
            var song = await _songService.GetFormModelByIdAsync(id);

            if (song == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = SongNotFound
                });
            }

            try
            {
                await _songService.DeleteAsync(id);
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
