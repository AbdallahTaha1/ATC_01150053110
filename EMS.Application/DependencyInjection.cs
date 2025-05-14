using EMS.Application.Services;
using EMS.Domain.Abstractions.IServices;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace EMS.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IEventService, EventService>();
            services.AddTransient<IBookingService, BookingService>();
            services.AddTransient<IUserService, UserService>();
            //Configuration Of Mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));


            return services;

        }

    }
}
