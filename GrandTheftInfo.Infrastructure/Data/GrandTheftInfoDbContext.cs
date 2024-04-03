using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Infrastructure.Data
{
    public class GrandTheftInfoDbContext : IdentityDbContext
    {
        public GrandTheftInfoDbContext(DbContextOptions<GrandTheftInfoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
