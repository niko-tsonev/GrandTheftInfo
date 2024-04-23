using Azure.Storage.Blobs;
using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Cheat;
using GrandTheftInfo.Core.Models.SaveGame;
using GrandTheftInfo.Infrastructure.Data.Common;
using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Core.Services
{
    public class SaveGameService : ISaveGameService
    {
        private readonly IRepository _repository;
        private readonly BlobServiceClient _blobServiceClient;
        private BlobContainerClient _client;

        public SaveGameService(IRepository repository, BlobServiceClient blobServiceClient)
        {
            _repository = repository;
            _blobServiceClient = blobServiceClient;
            _client = _blobServiceClient.GetBlobContainerClient("blobgrandtheftinfo");
        }

        public async Task<List<SaveGameViewModel>> GetFilesAsync()
        {
            var allFiles = await _repository.AllReadOnly<SaveGame>()
                .Select(s => new SaveGameViewModel()
                {
                    Id = s.Id,
                    FileName = s.FileName,
                    Description = s.Description,
                    BlobUri = s.BlobUri,
                    GameId = s.Game.Id,
                    GameName = s.Game.Name
                })
                .ToListAsync();

            return allFiles;
        }

        public async Task<int> UploadFileAsync(SaveGameAddModel model)
        {
            var fileName = Path.GetFileName(model.File.FileName);
            var blobClient = _client.GetBlobClient(fileName);

            using (var stream = model.File.OpenReadStream())
            {
                await blobClient.UploadAsync(stream, true);
            }

            var uploadedFile = new SaveGame()
            {
                FileName = fileName,
                Description = model.Description,
                BlobUri = blobClient.Uri.AbsoluteUri,
                GameId = model.GameId
            };

            await _repository.AddAsync(uploadedFile);
            await _repository.SaveChangesAsync();

            return uploadedFile.Id;
        }

        public async Task<SaveGameViewModel?> GetModelByIdAsync(int id)
        {
            var saveGame = await _repository.AllReadOnly<SaveGame>()
                .Where(s => s.Id == id)
                .Select(s => new SaveGameViewModel()
                {
                    FileName = s.FileName,
                    Description = s.Description,
                })
                .FirstOrDefaultAsync();

            return saveGame;
        }

        public async Task<bool> SaveGameExists(int id)
        {
            var saveGame = await _repository.GetByIdAsync<SaveGame>(id);

            return saveGame != null;
        }

        public async Task EditAsync(int id, SaveGameEditModel model)
        {
            var saveGame = await _repository.GetByIdAsync<SaveGame>(id);

            if (saveGame != null)
            {
                saveGame.Id = model.Id;
                saveGame.Description = model.Description;
                saveGame.GameId = model.GameId;

                await _repository.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var saveGame = await _repository.GetByIdAsync<SaveGame>(id);

            if (saveGame != null)
            {
                await _client.DeleteBlobAsync(saveGame.FileName);
                await _repository.DeleteAsync<SaveGame>(id);

                await _repository.SaveChangesAsync();
            }
        }
    }
}
