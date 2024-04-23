using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Infrastructure.Data.Models
{
    public class Cheat
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CheatNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(CheatCodeMaxLength)]
        public string CheatCode { get; set; } = null!;

        [Required]
        [MaxLength(CheatPlatformMaxLength)]
        public string Platform { get; set; } = null!;

        public int GameId { get; set; }

        public Game Game { get; set; } = null!;
    }
}
