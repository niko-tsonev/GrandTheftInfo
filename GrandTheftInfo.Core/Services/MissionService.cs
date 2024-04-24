using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Mission;
using GrandTheftInfo.Infrastructure.Data.Common;
using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Core.Services
{
    public class MissionService : IMissionService
    {
        private readonly IRepository _repository;

        public MissionService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<MissionViewModel>> AllAsync()
        {
            var missions = await _repository.AllReadOnly<Mission>()
            .Select(m => new MissionViewModel()
            {
                Id = m.Id,
                Name = m.Name,
                Description = m.Description,
                PlaytroughUrl = m.PlaytroughUrl,
                GameId = m.Game.Id,
                GameName = m.Game.Name
            })
            .ToListAsync();

            return missions;
        }

        public async Task<int> AddAsync(MissionFormModel model)
        {
            var mission = new Mission()
            {
                Name = model.Name,
                Description = model.Description,
                PlaytroughUrl = model.PlaytroughUrl,
                GameId = model.GameId
            };

            await _repository.AddAsync(mission);
            await _repository.SaveChangesAsync();

            return mission.Id;
        }

        public async Task<MissionFormModel?> GetFormModelByIdAsync(int id)
        {
            var mission = await _repository.AllReadOnly<Mission>()
                .Where(m => m.Id == id)
                .Select(m => new MissionFormModel()
                {
                    Name = m.Name,
                    Description = m.Description,
                    PlaytroughUrl = m.PlaytroughUrl,
                    GameId = m.Game.Id
                })
                .FirstOrDefaultAsync();

            return mission;
        }

        public async Task EditAsync(int id, MissionFormModel model)
        {
            var mission = await _repository.GetByIdAsync<Mission>(id);

            if (mission != null)
            {
                mission.Id = model.Id;
                mission.Name = model.Name;
                mission.Description = model.Description;
                mission.PlaytroughUrl = model.PlaytroughUrl;
                mission.GameId = model.GameId;

                await _repository.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync<Mission>(id);
            await _repository.SaveChangesAsync();
        }
    }
}
