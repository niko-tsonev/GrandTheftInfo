using GrandTheftInfo.Core.Models.EasterEgg;

namespace GrandTheftInfo.Core.Contracts
{
    public interface IEasterEggService
    {
        public Task<IEnumerable<EasterEggViewModel>> AllAsync();

        public Task<int> AddAsync(EasterEggFormModel model);

        public Task<EasterEggFormModel?> GetFormModelByIdAsync(int id);

        public Task EditAsync(int id, EasterEggFormModel model);

        public Task DeleteAsync(int id);
    }
}
