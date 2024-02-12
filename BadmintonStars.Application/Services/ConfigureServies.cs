using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
