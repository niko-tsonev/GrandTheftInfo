using GrandTheftInfo.Core.Models.Mission;

namespace GrandTheftInfo.Core.Models.Game
{
    public class GameMissionServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public IEnumerable<MissionViewModel> Missions { get; set; } = new List<MissionViewModel>();
    }
}
