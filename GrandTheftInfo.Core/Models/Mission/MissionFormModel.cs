using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.Mission
{
    public class MissionFormModel
    {
        [Required]
        [StringLength(MissionNameMaxLength, MinimumLength = MissionNameMinLength,
            ErrorMessage = MissionNameErrorMessage)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(MissionDescriptionMaxLength, MinimumLength = MissionDescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(MissionPlaytroughUrlMaxLength)]
        public string PlaytroughUrl { get; set; } = null!;

        [Required]
        public int GameId { get; set; }

        public IEnumerable<MissionGameServiceModel> Games { get; set; } = new List<MissionGameServiceModel>();
    }
}
