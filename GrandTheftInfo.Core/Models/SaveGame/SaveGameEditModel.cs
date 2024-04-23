using GrandTheftInfo.Core.Models.ServiceModel;
using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.SaveGame
{
    public class SaveGameEditModel
    {
        public string? FileName { get; set; }

        [Required]
        [StringLength(SaveGameDescriptionMaxLength, MinimumLength = SaveGameDescriptionMinLength,
            ErrorMessage = SaveGameDescriptionErrorMessage)]
        public string Description { get; set; } = null!;

        public DateTime UploadDate { get; set; }

        public int GameId { get; set; }

        public IEnumerable<GameServiceModel> Games { get; set; } = new List<GameServiceModel>();
    }
}
