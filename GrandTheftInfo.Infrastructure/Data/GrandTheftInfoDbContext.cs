﻿using GrandTheftInfo.Infrastructure.Data.Models;
using GrandTheftInfo.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Infrastructure.Data
{
    public class GrandTheftInfoDbContext : IdentityDbContext
    {
        public static bool IsUnitTest { get; set; }

        public GrandTheftInfoDbContext(DbContextOptions<GrandTheftInfoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<Mission> Missions { get; set; } = null!;
        public DbSet<Cheat> Cheats { get; set; } = null!;
        public DbSet<EasterEgg> EasterEggs { get; set; } = null!;
        public DbSet<SaveGame> SaveGames { get; set; } = null!;
        public DbSet<Song> Songs { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new GameConfiguration());
            builder.ApplyConfiguration(new MissionConfiguration());
            builder.ApplyConfiguration(new CheatConfiguration());
            builder.ApplyConfiguration(new EasterEggConfiguration());
            builder.ApplyConfiguration(new SaveGameConfiguration());
            builder.ApplyConfiguration(new SongConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
