using AutoMapper;
using eShop.Ordering.Application.Commands;
using eShop.Ordering.Application.Responses;
using eShop.Ordering.Core.Entities;

namespace eShop.Ordering.Application.Mapper
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, OrderResponse>().ReverseMap();
        }
    }
}
