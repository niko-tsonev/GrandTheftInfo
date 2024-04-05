using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Game;
using GrandTheftInfo.Infrastructure.Data;
using GrandTheftInfo.Infrastructure.Data.Common;
using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;

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
                    YearPublished = g.YearPublished,
                    MissionCount = g.MissionCount,
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
                YearPublished = model.YearPublished,
                MissionCount = model.MissionCount
            };

            await _repository.AddAsync(game);
            await _repository.SaveChangesAsync();

            return game.Id;
        }

        public async Task<GameViewModel?> GetByIdAsync(int id)
        {
            var game = await _repository.AllReadOnly<Game>()
                .Where(g => g.Id == id)
                .Select(g => new GameViewModel()
                {
                    Id = g.Id,
                    Name = g.Name,
                    Description = g.Description,
                    ImageUrl = g.ImageUrl,
                    YearPublished = g.YearPublished,
                    MissionCount = g.MissionCount
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
                game.YearPublished = model.YearPublished;
                game.MissionCount = model.MissionCount;

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
