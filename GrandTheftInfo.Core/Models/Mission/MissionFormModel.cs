using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GrandTheftInfo.Core.Models.Game;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.Mission
{
    public class MissionFormModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(MissionNameMaxLength, MinimumLength = MissionNameMinLength,
            ErrorMessage = MissionNameErrorMessage)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(MissionDescriptionMaxLength, MinimumLength = MissionDescriptionMinLength,
            ErrorMessage = MissionDescriptionErrorMessage)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(MissionPlaytroughUrlMaxLength)]
        [Display(Name = "Video Playtrough URL")]
        public string PlaytroughUrl { get; set; } = null!;

        public int GameId { get; set; }

        public IEnumerable<GameViewModel> Games { get; set; } = new List<GameViewModel>();
    }
}
