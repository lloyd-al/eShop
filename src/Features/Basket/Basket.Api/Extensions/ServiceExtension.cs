using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using eShop.Common.Infrastructure.Extensions;


namespace eShop.Basket.Api.Extensions
{
    public static class ServiceExtension
    {

        public static void ConfigureExtensions(this IServiceCollection services)
        {
            services.ConfigureApiVersioning();
            services.ConfigureSwagger("Basket Api");
            services.ConfigureLoggerService();
            services.ConfigureMailService();
        }

    }
}
