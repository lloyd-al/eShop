using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using eShop.Catalog.Core.Interfaces;
using eShop.Catalog.Infrastructure.DataContexts;
using eShop.Catalog.Infrastructure.Repositories;
using eShop.Catalog.Infrastructure.Settings;

namespace eShop.Catalog.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<CatalogDatabaseSetting>(x => configuration.GetSection(nameof(CatalogDatabaseSetting)).Bind(x));

            services.AddSingleton<ICatalogDatabaseSetting>(sp => sp.GetRequiredService<IOptions<CatalogDatabaseSetting>>().Value);

            services.AddTransient<ICatalogDbContext, CatalogDbContext>();
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
