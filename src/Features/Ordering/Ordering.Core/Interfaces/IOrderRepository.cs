using System.Collections.Generic;
using System.Threading.Tasks;
using eShop.Ordering.Core.Entities;


namespace eShop.Ordering.Core.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
