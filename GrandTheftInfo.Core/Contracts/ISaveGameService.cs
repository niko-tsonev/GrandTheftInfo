using GrandTheftInfo.Core.Models.Cheat;
using GrandTheftInfo.Core.Models.SaveGame;
using Microsoft.AspNetCore.Http;

namespace GrandTheftInfo.Core.Contracts
{
    public interface ISaveGameService
    {
        public Task<List<SaveGameViewModel>> GetFilesAsync();

        public Task<int> UploadFileAsync(SaveGameAddModel model);

        public Task<SaveGameViewModel?> GetModelByIdAsync(int id);

        public Task<bool> SaveGameExists(int id);

        public Task EditAsync(int id, SaveGameEditModel model);

        public Task DeleteAsync(int id);
    }
}
