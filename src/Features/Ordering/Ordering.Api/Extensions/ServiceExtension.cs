using Microsoft.Extensions.DependencyInjection;
using eShop.Common.Infrastructure.Extensions;


namespace eShop.Ordering.Api.Extensions
{
    public static class ServiceExtension
    {
        public static object Configuration { get; private set; }

        public static void ConfigureExtensions(this IServiceCollection services)
        {
            services.ConfigureApiVersioning();
            services.ConfigureSwagger("Ordering Api");
            services.ConfigureLoggerService();
            services.ConfigureMailService();
        }
    }
}
