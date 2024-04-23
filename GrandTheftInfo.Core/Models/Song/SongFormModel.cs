using GrandTheftInfo.Core.Models.ServiceModel;
using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.Song
{
    public class SongFormModel
    {
        [Required]
        [StringLength(SongNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(SongVideoUrlMaxLength)]
        public string VideoUrl { get; set; } = null!;

        [Required]
        [StringLength(SongRadioMaxLength)]
        public string Radio { get; set; } = null!;

        [Required]
        [StringLength(SongRadioImageUrlMaxLength)]
        public string RadioImageUrl { get; set; } = null!;

        public int GameId { get; set; }

        public IEnumerable<GameServiceModel> Games { get; set; } = new List<GameServiceModel>();
    }
}
