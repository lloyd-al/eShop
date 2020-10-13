using Microsoft.EntityFrameworkCore;
using eShop.Ordering.Core.Entities;


namespace eShop.Ordering.Infrastructure.DataContexts
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}
