using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Infrastructure.Data.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(SongNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(SongVideoUrlMaxLength)]
        public string VideoUrl { get; set; } = null!;

        [Required]
        [MaxLength(SongRadioMaxLength)]
        public string Radio { get; set; } = null!;

        [Required]
        [MaxLength(SongRadioImageUrlMaxLength)]
        public string RadioImageUrl { get; set; } = null!;

        public int GameId { get; set; }

        public Game Game { get; set; } = null!;
    }
}
