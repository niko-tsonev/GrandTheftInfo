using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.EasterEgg;
using GrandTheftInfo.Models;
using static GrandTheftInfo.Core.Constants.CustomErrorConstants;
using Microsoft.AspNetCore.Mvc;

namespace GrandTheftInfo.Controllers
{
    public class EasterEggController : BaseController
    {
        private readonly IEasterEggService _easterEggService;

        public EasterEggController(IEasterEggService easterEggService, IGameService gameService)
            : base(gameService)
        {
            _easterEggService = easterEggService;
        }

        public async Task<IActionResult> Index()
        {
            var easterEggs = await _easterEggService.AllAsync();

            if (easterEggs == null || !easterEggs.Any())
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = EasterEggsNotFound
                });
            }

            var model = easterEggs.GroupBy(x => x.GameId).OrderByDescending(g => g.First().GameName);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new EasterEggFormModel()
            {
                Games = await GetAllGamesInfo()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EasterEggFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Games = await GetAllGamesInfo();
                return View(model);
            }

            try
            {
                await _easterEggService.AddAsync(model);
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
            var easterEgg = await _easterEggService.GetFormModelByIdAsync(id);

            if (easterEgg == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = EasterEggNotFound
                });
            }

            var editModel = new EasterEggFormModel()
            {
                Name = easterEgg.Name,
                Description = easterEgg.Description,
                ImageUrlOne = easterEgg.ImageUrlOne,
                ImageUrlTwo = easterEgg.ImageUrlTwo,
                GameId = easterEgg.GameId,
                Games = await GetAllGamesInfo()
            };

            return View(editModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EasterEggFormModel model)
        {
            var easterEgg = await _easterEggService.GetFormModelByIdAsync(id);

            if (easterEgg == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = EasterEggNotFound
                });
            }

            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                await _easterEggService.EditAsync(id, model);
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
            var easterEgg = await _easterEggService.GetFormModelByIdAsync(id);

            if (easterEgg == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = EasterEggNotFound
                });
            }

            try
            {
                await _easterEggService.DeleteAsync(id);
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
