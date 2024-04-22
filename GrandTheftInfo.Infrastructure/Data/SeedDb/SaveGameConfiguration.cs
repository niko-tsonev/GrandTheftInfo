using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Infrastructure.Data.SeedDb
{
    internal class SaveGameConfiguration : IEntityTypeConfiguration<SaveGame>
    {
        public void Configure(EntityTypeBuilder<SaveGame> builder)
        {
            var data = new SeedData();

            builder.HasData(new SaveGame[]
            {
                data.SaveGameOne,
                data.SaveGameTwo,
            });
        }
    }
}
