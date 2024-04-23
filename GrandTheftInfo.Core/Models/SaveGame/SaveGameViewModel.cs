using GrandTheftInfo.Core.Contracts.ServiceModels;

namespace GrandTheftInfo.Core.Models.SaveGame
{
    public class SaveGameViewModel : IGameServiceModel
    {
        public int Id { get; set; }

        public string FileName { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string BlobUri { get; set; } = null!;

        public int GameId { get; set; }

        public string GameName { get; set; } = null!;
    }
}
