using AutoMapper;
using RestaurantManager.DtoLayer.ChefsDto;
using RestaurantManager.EntityLayer.Entities;

namespace Web.Api.Mapping
{
    public class ChefsMapping : Profile
    {
        public ChefsMapping()
        {
            CreateMap<Chefs, ResultChefsDto>().ReverseMap();
            CreateMap<Chefs, CreateChefsDto>().ReverseMap();
            CreateMap<Chefs, GetChefsDto>().ReverseMap();
            CreateMap<Chefs, UpdateChefsDto>().ReverseMap();
        }
    }
}
