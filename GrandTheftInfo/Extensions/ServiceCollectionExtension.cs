using GrandTheftInfo.Core.Contracts;
using GrandTheftInfo.Core.Services;
using GrandTheftInfo.Infrastructure.Data;
using GrandTheftInfo.Infrastructure.Data.Common;
using GrandTheftInfo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GrandTheftInfo.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IMissionService, MissionService>();
            services.AddScoped<ICheatService, CheatService>();
            services.AddScoped<IEasterEggService, EasterEggService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("GrandTheftInfoDb");
            services.AddDbContext<GrandTheftInfoDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<GrandTheftInfoDbContext>();

            return services;
        }
    }
}
