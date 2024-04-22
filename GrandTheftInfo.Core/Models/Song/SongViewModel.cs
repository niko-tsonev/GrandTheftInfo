using GrandTheftInfo.Core.Contracts.ServiceModels;

namespace GrandTheftInfo.Core.Models.Song
{
    public class SongViewModel : IGameServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string VideoUrl { get; set; } = null!;

        public string Radio { get; set; } = null!;

        public string RadioImageUrl { get; set; } = null!;

        public int GameId { get; set; }

        public string GameName { get; set; } = null!;
    }
}
