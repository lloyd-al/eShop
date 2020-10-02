using System.Threading.Tasks;
using eShop.Basket.Core.Entities;

namespace eShop.Basket.Core.Interfaces
{
    public interface IBasketRepository
    {
        Task<BasketCart> GetBasket(string userName);
        Task<BasketCart> UpdateBasket(BasketCart basket);
        Task<bool> DeleteBasket(string userName);
    }
}
