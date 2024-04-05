using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.Game
{
    public class GameViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(GameNameMaxLength, MinimumLength = GameNameMinLength,
            ErrorMessage = GameNameErrorMessage)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(GameDescriptionMaxLength, MinimumLength = GameDescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(GameImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public DateTime YearPublished { get; set; }

        [Required]
        public int MissionCount { get; set; }
    }
}
