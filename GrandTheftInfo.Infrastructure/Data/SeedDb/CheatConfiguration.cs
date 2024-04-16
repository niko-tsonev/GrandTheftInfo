using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Infrastructure.Data.SeedDb
{
    internal class CheatConfiguration : IEntityTypeConfiguration<Cheat>
    {
        public void Configure(EntityTypeBuilder<Cheat> builder)
        {
            var data = new SeedData();

            builder.HasData(new Cheat[] 
            { 
                data.CheatOne,
                data.CheatTwo,
                data.CheatThree,
                data.CheatFour,
                data.CheatFive,
                data.CheatSix,
                data.CheatSeven,
                data.CheatEight,
                data.CheatNine,
                data.CheatTen
            });
        }
    }
}
