using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DemoApp.Application.Extensions
{
    public static class ApplicationDependecyInjectionExtensions
    {

        public static IServiceCollection AddApplicationInjections(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }

    }
}
