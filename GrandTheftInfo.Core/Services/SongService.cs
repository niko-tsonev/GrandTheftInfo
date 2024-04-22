using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Models.Mission;
using GrandTheftInfo.Core.Models.Song;
using GrandTheftInfo.Infrastructure.Data.Common;
using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Core.Services
{
    public class SongService : ISongService
    {
        private readonly IRepository _repository;

        public SongService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> AddAsync(SongFormModel model)
        {
            var song = new Song()
            {
                Name = model.Name,
                Radio = model.Radio,
                RadioImageUrl = model.RadioImageUrl,
                VideoUrl = model.VideoUrl,
                GameId = model.GameId
            };

            await _repository.AddAsync(song);
            await _repository.SaveChangesAsync();

            return song.Id;
        }

        public async Task<IEnumerable<SongViewModel>> AllAsync()
        {
            var songs = await _repository.AllReadOnly<Song>()
                .Select(s => new SongViewModel()
                {
                    Id = s.Id,
                    Name = s.Name,
                    VideoUrl = s.VideoUrl,
                    Radio = s.Radio,
                    RadioImageUrl = s.RadioImageUrl,
                    GameId = s.GameId,
                    GameName = s.Game.Name
                })
                .ToListAsync();

            return songs;
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync<Song>(id);
            await _repository.SaveChangesAsync();
        }

        public async Task EditAsync(int id, SongFormModel model)
        {
            var song = await _repository.GetByIdAsync<Song>(id);

            if (song != null)
            {
                song.Name = model.Name;
                song.Radio = model.Radio;
                song.RadioImageUrl = model.RadioImageUrl;
                song.VideoUrl = model.VideoUrl;
                song.GameId = model.GameId;

                await _repository.SaveChangesAsync();
            }
        }

        public async Task<SongFormModel?> GetFormModelByIdAsync(int id)
        {
            var song = await _repository.AllReadOnly<Song>()
                .Where(s => s.Id == id)
                .Select(s => new SongFormModel()
                {
                    Name = s.Name,
                    Radio = s.Radio,
                    RadioImageUrl = s.RadioImageUrl,
                    VideoUrl = s.VideoUrl,
                    GameId = s.GameId,
                })
                .FirstOrDefaultAsync();

            return song;
        }

        public async Task<string> GetRadioImageByName(string radioName)
        {
            var radioImageUrl = await _repository.AllReadOnly<Song>()
                .FirstOrDefaultAsync(r => r.Radio == radioName);

            if (radioImageUrl == null)
            {
                throw new ArgumentException("Radio image not found");
            }

            return radioImageUrl.RadioImageUrl;
        }
    }
}
