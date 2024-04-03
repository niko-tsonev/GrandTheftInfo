using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GrandTheftInfo.Infrastructure.Data.SeedDb
{
    internal class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            var data = new SeedData();

            builder.HasData(new Game[] { data.GameOne, data.GameTwo });
        }
    }
}
