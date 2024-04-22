using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.ServiceModel;
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

        protected async Task<IEnumerable<GameServiceModel>> GetAllGamesInfo()
        {
            var games = await _gameService.AllAsync();

            return games.Select(m => new GameServiceModel()
            {
                Id = m.Id,
                Name = m.Name
            });
        }
    }
}
