using GrandTheftInfo.Core.Models.Game;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using static GrandTheftInfo.Infrastructure.Constants.DataConstants;

namespace GrandTheftInfo.Core.Models.SaveGame
{
    public class SaveGameAddModel
    {
        [Required]
        public IFormFile File { get; set; } = null!;

        [Required]
        [StringLength(SaveGameDescriptionMaxLength, MinimumLength = SaveGameDescriptionMinLength,
            ErrorMessage = SaveGameDescriptionErrorMessage)]
        public string Description { get; set; } = null!;

        public int GameId { get; set; }

        public IEnumerable<GameViewModel> Games { get; set; } = new List<GameViewModel>();
    }
}
