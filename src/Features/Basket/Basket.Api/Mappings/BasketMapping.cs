using AutoMapper;
using eShop.Basket.Core.Entities;
using eShop.Common.EventBusRabbitMQ.Events;

namespace eShop.Basket.Api.Mappings
{
    public class BasketMapping : Profile
    {
        public BasketMapping()
        {
            CreateMap<BasketCheckout, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
