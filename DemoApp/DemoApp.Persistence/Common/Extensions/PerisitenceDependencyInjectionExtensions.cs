using Microsoft.Extensions.DependencyInjection;

namespace DemoApp.Persistence.Common.Extensions
{
    public static class PerisitenceDependencyInjectionExtensions
    {
        public static IServiceCollection AddPersistenceInjections(this IServiceCollection services)
        {

            return services;
        }
    }
}
