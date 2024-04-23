using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.Game
{
    public class GameFormModel
    {
        [Required]
        [StringLength(GameNameMaxLength, MinimumLength = GameNameMinLength,
            ErrorMessage = GameNameErrorMessage)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(GameDescriptionMaxLength, MinimumLength = GameDescriptionMinLength,
            ErrorMessage = GameDescriptionErrorMessage)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(GameImageUrlMaxLength)]
        [Display(Name = "Image URL Address")]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = GameYearPublishedError)]
        [Display(Name = "Year Published")]
        public DateTime? YearPublished { get; set; }

        [Required]
        public int MissionCount { get; set; }
    }
}
