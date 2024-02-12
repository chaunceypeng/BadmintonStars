using BadmintonStars.Domain.Repositories;
using BadmintonStars.Infrastructure.Data;
using BadmintonStars.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BadmintonStars.Infrastructure.Services
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString") ??
                    throw new InvalidOperationException("Connection String not found.")
                )
            );

            services.AddTransient<IPlayerRepository, PlayerRepository>();
            return services;
        }
    }
}
