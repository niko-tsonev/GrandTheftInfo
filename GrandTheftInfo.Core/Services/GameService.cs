using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Game;
using GrandTheftInfo.Infrastructure.Data.Common;
using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Core.Services
{
    public class GameService : IGameService
    {
        private readonly IRepository _repository;

        public GameService(IRepository repository)
        {
            this._repository = repository;
        }

        public async Task<IEnumerable<GameViewModel>> AllAsync() 
        {
            var games = await _repository.AllReadOnly<Game>()
                .Select(g => new GameViewModel()
                {
                    Id = g.Id,
                    Name = g.Name,
                    Description = g.Description,
                    ImageUrl = g.ImageUrl,
                    DatePublished = g.DatePublished
                })
                .ToListAsync();

            return games;
        }

        public async Task<int> AddAsync(GameFormModel model)
        {
            var game = new Game()
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                DatePublished = model.DatePublished
            };

            await _repository.AddAsync(game);
            await _repository.SaveChangesAsync();

            return game.Id;
        }

        public async Task<GameFormModel?> GetFormModelByIdAsync(int id)
        {
            var game = await _repository.AllReadOnly<Game>()
                .Where (g => g.Id == id)
                .Select(g => new GameFormModel()
                {
                    Name = g.Name,
                    Description = g.Description,
                    ImageUrl = g.ImageUrl,
                    DatePublished = g.DatePublished
                })
                .FirstOrDefaultAsync();

            return game;
        }

        public async Task EditAsync(int id, GameFormModel model)
        {
            var game = await _repository.GetByIdAsync<Game>(id);

            if (game != null)
            {
                game.Name = model.Name;
                game.Description = model.Description;
                game.ImageUrl = model.ImageUrl;
                game.DatePublished = model.DatePublished;

                await _repository.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync<Game>(id);
            await _repository.SaveChangesAsync();
        }
    }
}
