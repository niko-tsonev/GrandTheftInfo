using System.ComponentModel.DataAnnotations;

namespace GrandTheftInfo.Infrastructure.Data.Models
{
    public class SaveGame
    {
        public int Id { get; set; }

        public string FileName { get; set; } = null!;

        public string Description { get; set; } = null!;

        public DateTime UploadDate { get; set; }

        public string BlobUri { get; set; } = null!;

        public int GameId { get; set; }

        public Game Game { get; set; } = null!;
    }
}
