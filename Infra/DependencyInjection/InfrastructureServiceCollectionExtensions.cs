using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.DependencyInjection
{
    public static class InfrastructureServiceCollectionExtensions
    {
        public static IServiceCollection AdicionarContext(this IServiceCollection services)
        {
            var conexaoSqlite = $"Data Source={ObterCaminhoBancoDados()}";
                
            services.AddDbContext<Context>(options => options.UseSqlite(conexaoSqlite));
            services.AddScoped(typeof(DAL<>));

            return services;
        }

        private static string ObterCaminhoBancoDados()
        {
            var appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var BancoDadosDir = Path.Combine(appDataDir, "Eleanor");

            if (!Directory.Exists(BancoDadosDir))
            {
                Directory.CreateDirectory(BancoDadosDir);
            }

            return Path.Combine(BancoDadosDir, "eleanor.db");
        }
    }
}