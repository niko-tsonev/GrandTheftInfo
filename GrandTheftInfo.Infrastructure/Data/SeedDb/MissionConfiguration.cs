using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GrandTheftInfo.Infrastructure.Data.SeedDb
{
    internal class MissionConfiguration : IEntityTypeConfiguration<Mission>
    {
        public void Configure(EntityTypeBuilder<Mission> builder)
        {
            var data = new SeedData();

            builder.HasData(new Mission[]
            {
                data.MissionOne,
                data.MissionTwo,
                data.MissionThree,
                data.MissionFour,
                data.MissionFive,
                data.MissionSix,
                data.MissionSeven,
                data.MissionEight,
            });
        }
    }
}
