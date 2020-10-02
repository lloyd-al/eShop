using StackExchange.Redis;

namespace eShop.Basket.Core.Interfaces
{
    public interface IBasketContext
    {
        IDatabase Redis { get; }
    }
}
