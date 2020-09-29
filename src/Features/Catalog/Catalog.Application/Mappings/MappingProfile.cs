using AutoMapper;
using eShop.Catalog.Application.DTOs;
using eShop.Catalog.Core.Entities;

namespace eShop.Catalog.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<Product, ProductDto>();
        }
    }
}
