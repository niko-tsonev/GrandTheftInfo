using GrandTheftInfo.Core.Models.Game;
using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.Cheat
{
    public class CheatFormModel
    {
        public int Id { get; set; }

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
        [StringLength(CheatPlatformMaxLength)]
        public string Platform { get; set; } = null!;

        public int GameId { get; set; }

        public IEnumerable<GameViewModel> Games { get; set; } = new List<GameViewModel>();
    }
}
