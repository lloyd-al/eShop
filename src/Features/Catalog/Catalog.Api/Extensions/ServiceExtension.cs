using eShop.Common.Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;



namespace eShop.Catalog.Api.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureExtensions(this IServiceCollection services)
        {
            services.ConfigureApiVersioning();
            services.ConfigureSwagger("Catalog Api");
            services.ConfigureLoggerService();
            services.ConfigureMailService();
        }

    }
}
