using AutoMapper;
using RestaurantManager.DtoLayer.PopularMenuDto;
using RestaurantManager.EntityLayer.Entities;

namespace Web.Api.Mapping
{
    public class PopularMenuMapping : Profile
    {
        public PopularMenuMapping()
        {
            CreateMap<PopularMenu, ResultPopularMenuDto>().ReverseMap();
            CreateMap<PopularMenu, CreatePopularMenuDto>().ReverseMap();
            CreateMap<PopularMenu, GetPopularMenuDto>().ReverseMap();
            CreateMap<PopularMenu, UpdatePopularMenuDto>().ReverseMap();
        }
    }
}
