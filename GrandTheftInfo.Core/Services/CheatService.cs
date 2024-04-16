using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Cheat;
using GrandTheftInfo.Infrastructure.Data.Common;
using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Core.Services
{
    public class CheatService : ICheatService
    {
        private readonly IRepository _repository;

        public CheatService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> AddAsync(CheatFormModel model)
        {
            var cheat = new Cheat()
            {
                Name = model.Name,
                CheatCode = model.CheatCode,
                Platform = model.Platform,
                GameId = model.GameId
            };

            await _repository.AddAsync(cheat);
            await _repository.SaveChangesAsync();

            return cheat.Id;
        }

        public async Task<IEnumerable<CheatViewModel>> AllAsync()
        {
            var cheats = await _repository.AllReadOnly<Cheat>()
                .Select(c => new CheatViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    CheatCode = c.CheatCode,
                    Platform = c.Platform,
                    GameName = c.Game.Name,
                    GameId = c.Game.Id
                })
                .ToListAsync();

            return cheats;
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync<Cheat>(id);
            await _repository.SaveChangesAsync();
        }

        public async Task EditAsync(int id, CheatFormModel model)
        {
            var cheat = await _repository.GetByIdAsync<Cheat>(id);

            if (cheat != null)
            {
                cheat.Name = model.Name;
                cheat.CheatCode = model.CheatCode;
                cheat.Platform = model.Platform;
                cheat.GameId = model.GameId;

                await _repository.SaveChangesAsync();
            }
        }

        public async Task<CheatFormModel?> GetFormModelByIdAsync(int id)
        {
            var cheat = await _repository.AllReadOnly<Cheat>()
                .Where(c => c.Id == id)
                .Select(c => new CheatFormModel()
                {
                    Name = c.Name,
                    CheatCode = c.CheatCode,
                    Platform = c.Platform,
                    GameId = c.Game.Id
                })
                .FirstOrDefaultAsync();

            return cheat;
        }
    }
}
