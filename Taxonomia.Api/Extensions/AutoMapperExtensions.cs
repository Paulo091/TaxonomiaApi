using Taxonomia.Data.Mapper;

namespace Taxonomia.Api.Extensions
{
    public static class AutoMapperExtensions
    {
        public static IServiceCollection AddListAutoMapperCustom(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<DominioProfile>();
                cfg.AddProfile<ReinoProfile>();
            });

            return services;
        }
    }
}
