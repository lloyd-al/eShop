
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;

using eShop.Catalog.Core.Interfaces;
using eShop.Catalog.Core.Entities;

namespace eShop.Catalog.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogDbContext _context;

        public ProductRepository(ICatalogDbContext catalogContext)
        {
            _context = catalogContext ?? throw new ArgumentNullException(nameof(catalogContext));
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context
                            .Products
                            .Find(p => true)
                            .ToListAsync();
        }

        public async Task<Product> GetProduct(string id)
        {
            return await _context
                            .Products
                            .Find(p => p.Id == id)
                            .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByName(string productName)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.ElemMatch(p => p.ProductName, productName);

            return await _context
                          .Products
                          .Find(filter)
                          .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.ProductCategory, categoryName);

            return await _context
                          .Products
                          .Find(filter)
                          .ToListAsync();
        }

        public async Task Create(Product product)
        {
            await _context.Products.InsertOneAsync(product);

        }

        public async Task<bool> Update(Product product)
        {
            var updateResult = await _context
                                        .Products
                                        .ReplaceOneAsync(filter: g => g.Id == product.Id, replacement: product);

            return updateResult.IsAcknowledged
                    && updateResult.ModifiedCount > 0;
        }

        public async Task<bool> Delete(string id)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(m => m.Id, id);
            DeleteResult deleteResult = await _context
                                                .Products
                                                .DeleteOneAsync(filter);

            return deleteResult.IsAcknowledged
                && deleteResult.DeletedCount > 0;
        }
    }
}
