using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Infrastructure.Data.SeedDb
{
    internal class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            var data = new SeedData();

            builder.HasData(new Song[]
            {
                data.SongOne,
                data.SongTwo,
                data.SongThree,
                data.SongFour,
                data.SongFive,
                data.SongSix,
            });
        }
    }
}
