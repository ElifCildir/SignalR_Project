using AutoMapper;
using DtoLayer.ProductDto;
using EntityLayer.Entities;

namespace API.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<Procduct, ResultProductDto>().ReverseMap();
            CreateMap<Procduct, CreateProductDto>().ReverseMap();
            CreateMap<Procduct, UpdateProductDto>().ReverseMap();
            CreateMap<Procduct, GetProductDto>().ReverseMap();
            CreateMap<Procduct, ResultProductWithCategory>().ReverseMap();
           
        }
    }
}
