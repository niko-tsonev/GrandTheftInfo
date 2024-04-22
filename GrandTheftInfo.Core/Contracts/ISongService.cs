using GrandTheftInfo.Core.Models.Song;

namespace GrandTheftInfo.Core.Contracts
{
    public interface ISongService
    {
        public Task<IEnumerable<SongViewModel>> AllAsync();

        public Task<int> AddAsync(SongFormModel model);

        public Task<SongFormModel?> GetFormModelByIdAsync(int id);

        public Task EditAsync(int id, SongFormModel model);

        public Task DeleteAsync(int id);

        public Task<string> GetRadioImageByName(string name);
    }
}
