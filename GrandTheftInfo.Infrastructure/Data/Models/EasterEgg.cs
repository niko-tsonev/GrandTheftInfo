using System.ComponentModel.DataAnnotations;

namespace GrandTheftInfo.Infrastructure.Data.Models
{
    public class EasterEgg
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = null!;

        [MaxLength(500)]
        public string? ImageUrlOne { get; set; }

        [MaxLength(500)]
        public string? ImageUrlTwo { get; set; }

        [Required]
        public int GameId { get; set; }

        public Game Game { get; set; } = null!;
    }
}
