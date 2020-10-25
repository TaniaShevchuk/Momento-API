using App.DomainContract;
using App.DomainService;
using App.DomainService.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace App.WebApi.Mappers
{
    public static class SvcCollectionExtensions
    {
        public static IServiceCollection AddCustomMappers(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.TryAddSingleton<IAuthSvc, AuthSvc>();

            return services;
        }

        public static IServiceCollection AddCustomConfiguration(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));
            services.TryAddSingleton<IAppSettings>(sp => sp.GetRequiredService<IOptions<AppSettings>>().Value);

            return services;
        }
    }
}
