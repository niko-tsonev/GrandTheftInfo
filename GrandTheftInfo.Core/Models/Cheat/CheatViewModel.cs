using GrandTheftInfo.Core.Contracts.ServiceModels;

namespace GrandTheftInfo.Core.Models.Cheat
{
    public class CheatViewModel : IGameServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string CheatCode { get; set; } = null!;

        public string Platform { get; set; } = null!;

        public int GameId { get; set; }

        public string GameName { get; set; } = null!;
    }
}
