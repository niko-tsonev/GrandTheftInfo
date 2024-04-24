using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Game;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GrandTheftInfo.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        private readonly IGameService _gameService;

        public BaseController(IGameService gameService)
        {
            _gameService = gameService;
        }

        protected async Task<IEnumerable<GameViewModel>> GetAllGamesInfo()
        {
            var games = await _gameService.AllAsync();

            return games.Select(m => new GameViewModel()
            {
                Id = m.Id,
                Name = m.Name
            });
        }
    }
}
