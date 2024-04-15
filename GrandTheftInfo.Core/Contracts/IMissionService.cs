using GrandTheftInfo.Core.Models.Mission;

namespace GrandTheftInfo.Core.Contracts
{
    public interface IMissionService
    {
        public Task<IEnumerable<MissionViewModel>> AllAsync();

        public Task<int> AddAsync(MissionFormModel model);

        public Task<MissionFormModel?> GetFormModelByIdAsync(int id);

        public Task EditAsync(int id, MissionFormModel model);

        public Task DeleteAsync(int id);
    }
}
