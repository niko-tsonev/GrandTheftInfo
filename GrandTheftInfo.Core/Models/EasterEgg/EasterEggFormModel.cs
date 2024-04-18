using GrandTheftInfo.Core.Models.Mission;
using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.EasterEgg
{
    public class EasterEggFormModel
    {
        [Required]
        [StringLength(EasterEggNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(EasterEggDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [StringLength(EasterEggImageOneMaxLength)]
        public string? ImageUrlOne { get; set; }

        [StringLength(EasterEggImageTwoMaxLength)]
        public string? ImageUrlTwo { get; set; }

        public int GameId { get; set; }

        public IEnumerable<MissionGameServiceModel> Games { get; set; } = new List<MissionGameServiceModel>();
    }
}
