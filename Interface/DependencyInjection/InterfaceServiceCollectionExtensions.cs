using Interface.Menu;
using Microsoft.Extensions.DependencyInjection;

namespace Interface.DependencyInjection
{
    public static class InterfaceServiceCollectionExtensions
    {
        public static IServiceCollection AddInterfaceServices(this IServiceCollection services)
        {
            services.AddSingleton<GerenciadorMenu>();
            return services;
        }
    }
}