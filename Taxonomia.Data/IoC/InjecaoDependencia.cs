using Microsoft.Extensions.DependencyInjection;
using Taxonomia.Data.DbContexts.SqlContext;
using Taxonomia.Data.Repositorios.DominioRepository;
using Taxonomia.Domain.DominioEntity.Interfaces;
using Taxonomia.Domain.DominioEntity.Services;

namespace Taxonomia.Data.IoC
{
    public static class InjecaoDependeciaConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<SqlContext>();
            services.AddScoped<IDominioRepository, DominioRepository>();
            services.AddScoped<IDominioService, DominioService>();

            return services;
        }
    }
}
