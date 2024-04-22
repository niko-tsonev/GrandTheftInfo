namespace GrandTheftInfo.Infrastructure.Data.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string VideoUrl { get; set; } = null!;

        public string Radio { get; set; } = null!;

        public string RadioImageUrl { get; set; } = null!;

        public int GameId { get; set; }

        public Game Game { get; set; } = null!;
    }
}
