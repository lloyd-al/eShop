
using System;
using eShop.Common.Core.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace eShop.Common.Infrastructure.DataContexts
{
    public abstract class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
