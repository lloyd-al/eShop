using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Catalog.Core.Entities;

namespace eShop.Catalog.Core.Interfaces
{
    public interface IRepositoryManager
    {
        IProductRepository Products { get; }
        int Save();
    }
}
