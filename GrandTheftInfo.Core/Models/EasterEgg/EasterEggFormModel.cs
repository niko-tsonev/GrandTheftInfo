using GrandTheftInfo.Core.Models.ServiceModel;
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

        [Required]
        [StringLength(EasterEggImageOneMaxLength)]
        [Display(Name = "First Image URL")]
        public string ImageUrlOne { get; set; } = null!;

        [StringLength(EasterEggImageTwoMaxLength)]
        [Display(Name = "Second Image URL")]
        public string? ImageUrlTwo { get; set; }

        public int GameId { get; set; }

        public IEnumerable<GameServiceModel> Games { get; set; } = new List<GameServiceModel>();
    }
}
