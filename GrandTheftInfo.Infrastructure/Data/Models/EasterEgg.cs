using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Infrastructure.Data.Models
{
    public class EasterEgg
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(EasterEggNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(EasterEggDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [MaxLength(EasterEggImageOneMaxLength)]
        public string ImageUrlOne { get; set; } = null!;

        [MaxLength(EasterEggImageTwoMaxLength)]
        public string? ImageUrlTwo { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; } = null!;
    }
}
