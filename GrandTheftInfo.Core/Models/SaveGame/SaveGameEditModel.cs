using GrandTheftInfo.Core.Models.ServiceModel;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace GrandTheftInfo.Core.Models.SaveGame
{
    public class SaveGameEditModel
    {
        public string? FileName { get; set; }

        public string Description { get; set; } = null!;

        public DateTime UploadDate { get; set; }

        public int GameId { get; set; }

        public IEnumerable<GameServiceModel> Games { get; set; } = new List<GameServiceModel>();
    }
}
