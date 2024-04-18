using GrandTheftInfo.Core.Contracts.ServiceModels;

namespace GrandTheftInfo.Core.Models.EasterEgg
{
    public class EasterEggViewModel : IGameServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? ImageUrlOne { get; set; }

        public string? ImageUrlTwo { get; set; }

        public int GameId { get; set; }

        public string GameName { get; set; } = null!;
    }
}
