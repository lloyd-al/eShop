using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

using eShop.Catalog.Core.Entities;
using eShop.Catalog.Core.Interfaces;
using eShop.Common.Core.Interfaces;
using eShop.Common.Infrastructure.DataContexts;
using System;

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

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        //{
        //    foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        //    {
        //        switch (entry.State)
        //        {
        //            case EntityState.Added:
        //                entry.Entity.Created = DateTime.UtcNow;
        //                entry.Entity.LastModified = DateTime.UtcNow;
        //                break;
        //            case EntityState.Modified:
        //                entry.Entity.LastModified = DateTime.UtcNow;
        //                break;
        //        }
        //    }
        //    return base.SaveChangesAsync(cancellationToken);
        //}

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
            
        //    base.OnModelCreating(builder);
        //}
    }
}
