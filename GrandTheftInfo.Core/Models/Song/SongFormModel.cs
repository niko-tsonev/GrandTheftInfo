using GrandTheftInfo.Core.Models.ServiceModel;

namespace GrandTheftInfo.Core.Models.Song
{
    public class SongFormModel
    {
        public string Name { get; set; } = null!;

        public string VideoUrl { get; set; } = null!;

        public string Radio { get; set; } = null!;

        public string RadioImageUrl { get; set; } = null!;

        public int GameId { get; set; }

        public IEnumerable<GameServiceModel> Games { get; set; } = new List<GameServiceModel>();
    }
}
