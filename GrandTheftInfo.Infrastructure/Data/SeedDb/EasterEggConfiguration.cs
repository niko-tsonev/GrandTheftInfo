using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Infrastructure.Data.SeedDb
{
    internal class EasterEggConfiguration : IEntityTypeConfiguration<EasterEgg>
    {
        public void Configure(EntityTypeBuilder<EasterEgg> builder)
        {
            var data = new SeedData();

            builder.HasData(new EasterEgg[]
            {
                data.EasterEggOne,
                data.EasterEggTwo,
                data.EasterEggThree,
                data.EasterEggFour
            });
        }
    }
}
