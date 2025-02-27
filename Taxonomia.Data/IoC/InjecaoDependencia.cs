using Microsoft.Extensions.DependencyInjection;
using Taxonomia.Data.DbContexts.SqlContext;
using Taxonomia.Data.Repositorios.DominioRepository;
using Taxonomia.Data.Repositorios.ReinoRepository;
using Taxonomia.Domain.DominioEntity.Handlers;
using Taxonomia.Domain.DominioEntity.Interfaces;
using Taxonomia.Domain.DominioEntity.Services;
using Taxonomia.Domain.ReinoEntity.Interfaces;
using Taxonomia.Domain.ReinoEntity.Services;

namespace Taxonomia.Data.IoC
{
    public static class InjecaoDependeciaConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<SqlContext>();
            services.AddScoped<IDominioRepository, DominioRepository>();
            services.AddScoped<IDominioService, DominioService>();
            services.AddScoped<IDominioHandler, DominioHandler>();

            services.AddScoped<IReinoRepository, ReinoRepository>();
            services.AddScoped<IReinoService, ReinoService>();

            return services;
        }
    }
}
