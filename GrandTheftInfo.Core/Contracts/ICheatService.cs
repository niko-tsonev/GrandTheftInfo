using GrandTheftInfo.Core.Models.Cheat;
using GrandTheftInfo.Core.Models.Mission;

namespace GrandTheftInfo.Core.Contracts
{
    public interface ICheatService
    {
        public Task<IEnumerable<CheatViewModel>> AllAsync();

        public Task<int> AddAsync(CheatFormModel model);

        public Task<CheatFormModel?> GetFormModelByIdAsync(int id);

        public Task EditAsync(int id, CheatFormModel model);

        public Task DeleteAsync(int id);
    }
}
