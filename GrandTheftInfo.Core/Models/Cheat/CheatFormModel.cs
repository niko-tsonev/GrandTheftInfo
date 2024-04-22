using GrandTheftInfo.Core.Models.ServiceModel;
using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.Cheat
{
    public class CheatFormModel
    {
        [Required]
        [StringLength(CheatNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(CheatCodeMaxLength)]
        public string CheatCode { get; set; } = null!;

        [Required]
        [StringLength(CheatPlatformMaxLength)]
        public string Platform { get; set; } = null!;

        public int GameId { get; set; }

        public IEnumerable<GameServiceModel> Games { get; set; } = new List<GameServiceModel>();
    }
}
