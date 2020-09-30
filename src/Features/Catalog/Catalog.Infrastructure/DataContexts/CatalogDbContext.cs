using MongoDB.Driver;
using eShop.Catalog.Core.Entities;
using eShop.Catalog.Core.Interfaces;

namespace eShop.Catalog.Infrastructure.DataContexts
{
    public class CatalogDbContext : ICatalogDbContext
    {
        public CatalogDbContext(ICatalogDatabaseSetting settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            Products = database.GetCollection<Product>(settings.CollectionName);
            CatalogDbContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; }
    }
}
