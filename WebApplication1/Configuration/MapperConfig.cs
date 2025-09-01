using AutoMapper;
using WebApplication1.DTO;
using WebApplication1.Model;

namespace WebApplication1.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();   
        }
    }
}
