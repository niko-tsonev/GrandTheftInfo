using GrandTheftInfo.Core.Models.Game;

namespace GrandTheftInfo.Core.Contracts
{
    public interface IGameService
    {
        public Task<IEnumerable<GameViewModel>> AllAsync();

        public Task<int> AddAsync(GameFormModel model);

        public Task<GameViewModel?> GetByIdAsync(int id);

        public Task EditAsync(int id, GameFormModel model);

        public Task DeleteAsync(int id);
    }
}
