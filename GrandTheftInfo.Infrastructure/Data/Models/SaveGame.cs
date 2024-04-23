using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Infrastructure.Data.Models
{
    public class SaveGame
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(SaveGameFileNameMaxLength)]
        public string FileName { get; set; } = null!;

        [Required]
        [MaxLength(SaveGameDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(SaveGameBlobUriMaxLength)]
        public string BlobUri { get; set; } = null!;

        public int GameId { get; set; }

        public Game Game { get; set; } = null!;
    }
}
