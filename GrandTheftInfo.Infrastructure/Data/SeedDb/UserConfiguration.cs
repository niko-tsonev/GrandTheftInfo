using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GrandTheftInfo.Infrastructure.Data.SeedDb
{
    internal class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var data = new SeedData();

            builder.HasData(new ApplicationUser[] { data.GuestUser, data.AdminUser });
        }
    }
}
