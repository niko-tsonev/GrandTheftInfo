using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GrandTheftInfo.Core.Models.ServiceModel;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.Mission
{
    public class MissionFormModel
    {
        [Required]
        [StringLength(MissionNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(MissionDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(MissionPlaytroughUrlMaxLength)]
        [Display(Name = "Video Playtrough URL")]
        public string PlaytroughUrl { get; set; } = null!;

        public int GameId { get; set; }

        public IEnumerable<GameServiceModel> Games { get; set; } = new List<GameServiceModel>();
    }
}
