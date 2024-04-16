using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Mission;
using Microsoft.AspNetCore.Mvc;

namespace GrandTheftInfo.Controllers
{
    public class BaseController : Controller
    {
        private readonly IGameService _gameService;

        public BaseController(IGameService gameService)
        {
            _gameService = gameService;
        }

        protected async Task<IEnumerable<MissionGameServiceModel>> GetAllGamesInfo()
        {
            var games = await _gameService.AllAsync();

            return games.Select(m => new MissionGameServiceModel()
            {
                Id = m.Id,
                Name = m.Name
            });
        }
    }
}
