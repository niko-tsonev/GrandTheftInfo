namespace GrandTheftInfo.Core.Models.Mission
{
    public class MissionViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string PlaytroughUrl { get; set; } = null!;

        public int GameId { get; set; }

        public string GameName { get; set; } = null!;
    }
}
