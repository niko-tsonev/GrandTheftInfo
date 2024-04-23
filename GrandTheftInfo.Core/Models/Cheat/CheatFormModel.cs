using GrandTheftInfo.Core.Models.ServiceModel;
using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.Cheat
{
    public class CheatFormModel
    {
        [Required]
        [StringLength(CheatNameMaxLength, MinimumLength = CheatNameMinLength,
            ErrorMessage = CheatNameErrorMessage)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(CheatCodeMaxLength, MinimumLength = CheatCodeMinLength,
            ErrorMessage = CheatCodeErrorMessage)]
        [Display(Name = "Cheat Code")]
        public string CheatCode { get; set; } = null!;

        [Required]
        [StringLength(CheatPlatformMaxLength, MinimumLength = CheatPlatformMinLength,
            ErrorMessage = CheatPlatformErrorMessage)]
        public string Platform { get; set; } = null!;

        public int GameId { get; set; }

        public IEnumerable<GameServiceModel> Games { get; set; } = new List<GameServiceModel>();
    }
}
