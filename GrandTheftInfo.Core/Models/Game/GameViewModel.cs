using GrandTheftInfo.Core.Models.Mission;
using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.Game
{
    public class GameViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public DateTime? DatePublished { get; set; }

        public int MissionCount { get; set; }
    }
}
