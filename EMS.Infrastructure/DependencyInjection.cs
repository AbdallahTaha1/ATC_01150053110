using EMS.Domain.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace EMS.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;

        }

    }
}
