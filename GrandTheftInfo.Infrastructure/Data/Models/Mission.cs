using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Infrastructure.Data.Models
{
    public class Mission
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MissionNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(MissionDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(MissionPlaytroughUrlMaxLength)]
        public string PlaytroughUrl { get; set; } = null!;

        [Required]
        public int GameId { get; set; }
    }
}
