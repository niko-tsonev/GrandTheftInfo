using GrandTheftInfo.Core.Models.Game;
using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.Song
{
    public class SongFormModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(SongNameMaxLength, MinimumLength = SongNameMinLength,
            ErrorMessage = SongNameErrorMessage)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(SongVideoUrlMaxLength)]
        public string VideoUrl { get; set; } = null!;

        [Required]
        [StringLength(SongRadioMaxLength, MinimumLength = SongRadioMinLength,
            ErrorMessage = SongRadioErrorMessage)]
        public string Radio { get; set; } = null!;

        [Required]
        [StringLength(SongRadioImageUrlMaxLength)]
        public string RadioImageUrl { get; set; } = null!;

        public int GameId { get; set; }

        public IEnumerable<GameViewModel> Games { get; set; } = new List<GameViewModel>();
    }
}
