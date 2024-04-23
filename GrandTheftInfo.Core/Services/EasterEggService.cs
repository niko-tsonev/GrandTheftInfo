using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.EasterEgg;
using GrandTheftInfo.Infrastructure.Data.Common;
using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Core.Services
{
    public class EasterEggService : IEasterEggService
    {
        private readonly IRepository _repository;

        public EasterEggService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> AddAsync(EasterEggFormModel model)
        {
            var easterEgg = new EasterEgg()
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrlOne = model.ImageUrlOne,
                ImageUrlTwo = model.ImageUrlTwo,
                GameId = model.GameId,
            };

            await _repository.AddAsync(easterEgg);
            await _repository.SaveChangesAsync();

            return easterEgg.Id;
        }

        public async Task<IEnumerable<EasterEggViewModel>> AllAsync()
        {
            var easterEggs = await _repository.AllReadOnly<EasterEgg>()
                .Select(e => new EasterEggViewModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Description = e.Description,
                    ImageUrlOne = e.ImageUrlOne,
                    ImageUrlTwo = e.ImageUrlTwo,
                    GameId = e.GameId,
                    GameName = e.Game.Name
                })
                .ToListAsync();

            return easterEggs;
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync<EasterEgg>(id);
            await _repository.SaveChangesAsync();
        }

        public async Task EditAsync(int id, EasterEggFormModel model)
        {
            var easterEgg = await _repository.GetByIdAsync<EasterEgg>(id);

            if (easterEgg != null) 
            {
                easterEgg.Id = model.Id;
                easterEgg.Name = model.Name;
                easterEgg.Description = model.Description;
                easterEgg.ImageUrlOne = model.ImageUrlOne;
                easterEgg.ImageUrlTwo = model.ImageUrlTwo;
                easterEgg.GameId = model.GameId;

                await _repository.SaveChangesAsync();
            }
        }

        public async Task<EasterEggFormModel?> GetFormModelByIdAsync(int id)
        {
            var easterEgg = await _repository.AllReadOnly<EasterEgg>()
                .Where(e => e.Id == id)
                .Select(e => new EasterEggFormModel()
                {
                    Name = e.Name,
                    Description = e.Description,
                    ImageUrlOne =  e.ImageUrlOne,
                    ImageUrlTwo = e.ImageUrlTwo,
                    GameId = e.GameId,
                })
                .FirstOrDefaultAsync();

            return easterEgg;
        }
    }
}
