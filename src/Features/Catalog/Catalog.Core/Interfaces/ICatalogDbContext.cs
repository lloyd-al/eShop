using MongoDB.Driver;
using eShop.Catalog.Core.Entities;

namespace eShop.Catalog.Core.Interfaces
{
    public interface ICatalogDbContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
