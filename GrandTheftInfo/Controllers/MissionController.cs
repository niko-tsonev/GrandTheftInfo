using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Mission;
using GrandTheftInfo.Models;
using static GrandTheftInfo.Core.Constants.CustomErrorConstants;
using Microsoft.AspNetCore.Mvc;

namespace GrandTheftInfo.Controllers
{
    public class MissionController : BaseController
    {
        private readonly IMissionService _missionService;
        private readonly IGameService _gameService;

        public MissionController(IMissionService missionService, IGameService gameService)
            : base(gameService)
        {
            _missionService = missionService;
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var missions = await _missionService.AllAsync();

            if (missions == null || !missions.Any())
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = MissionsNotFound
                });
            }

            var model = missions.GroupBy(x => x.GameId).OrderByDescending(g => g.First().GameName);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new MissionFormModel
            {
                Games = await GetAllGamesInfo()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(MissionFormModel model)
        {
            if (!ModelState.IsValid) 
            {
                model.Games = await GetAllGamesInfo();
                return View(model);
            }

            try
            {
                await _missionService.AddAsync(model);
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
            var mission = await _missionService.GetFormModelByIdAsync(id);

            if (mission == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = MissionNotFound
                });
            }

            var editModel = new MissionFormModel()
            {
                Name = mission.Name,
                Description = mission.Description,
                PlaytroughUrl = mission.PlaytroughUrl,
                GameId = mission.GameId,
                Games = await GetAllGamesInfo(),
            };

            return View(editModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, MissionFormModel model)
        {
            var mission = await _missionService.GetFormModelByIdAsync(id);

            if (mission == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = MissionNotFound
                });
            }

            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                await _missionService.EditAsync(id, model);
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
            var mission = await _missionService.GetFormModelByIdAsync(id);

            if (mission == null)
            {
                return View(NotFoundCustomError, new CustomErrorViewModel()
                {
                    Message = MissionNotFound
                });
            }

            try
            {
                await _missionService.DeleteAsync(id);
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
