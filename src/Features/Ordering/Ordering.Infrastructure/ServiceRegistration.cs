using eShop.Ordering.Core.Interfaces;
using eShop.Ordering.Infrastructure.DataContexts;
using eShop.Ordering.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace eShop.Ordering.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OrderContext>(c =>
                c.UseSqlServer(configuration.GetConnectionString("OrderConnection")), ServiceLifetime.Singleton);
            // we made singleton this in order to resolve in mediatR when consuming Rabbit

            // Add Infrastructure Layer
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IOrderRepository), typeof(OrderRepository));
            services.AddTransient<IOrderRepository, OrderRepository>();
            // we made transient this in order to resolve in mediatR when consuming Rabbit
        }
    }
}
