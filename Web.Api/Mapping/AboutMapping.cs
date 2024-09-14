using AutoMapper;
using RestaurantManager.DtoLayer.AboutDto;
using RestaurantManager.EntityLayer.Entities;

namespace Web.Api.Mapping
{
    public class AboutMapping  : Profile
    {
        public AboutMapping() { 
        CreateMap<About, ResultAboutDto>().ReverseMap();
        CreateMap<About, CreateAboutDto>().ReverseMap();
        CreateMap<About, GetAboutDto>().ReverseMap();
        CreateMap<About, updateAboutDto>().ReverseMap();
        }
    }
}
