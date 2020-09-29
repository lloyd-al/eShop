
using System;
using System.Collections.Generic;
using System.Text;

using eShop.Catalog.Core.Interfaces;
using eShop.Catalog.Infrastructure.DataContexts;
using eShop.Catalog.Infrastructure.Repositories;

namespace eShop.Catalog.Infrastructure.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly CatalogDbContext _context;

        public IProductRepository Products { get; private set; }

        public RepositoryManager(CatalogDbContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
