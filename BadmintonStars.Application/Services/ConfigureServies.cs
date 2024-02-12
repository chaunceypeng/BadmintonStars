using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BadmintonStars.Application.Services
{
    public static class ConfigureServies
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) 
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(configuratoin => 
                configuratoin.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())
            );

            return services;
        }

    }
}
