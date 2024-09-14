using AutoMapper;
using RestaurantManager.DtoLayer.TestiomonialDto;
using RestaurantManager.EntityLayer.Entities;

namespace Web.Api.Mapping
{
    public class TestiomonialMapping : Profile
    {
        public TestiomonialMapping()
        {
            CreateMap<Testiomonial, ResultTestiomonialDto>().ReverseMap();
            CreateMap<Testiomonial, CreateTestiomonialDto>().ReverseMap();
            CreateMap<Testiomonial, GetTestiomonialDto>().ReverseMap();
            CreateMap<Testiomonial, UpdateTestiomonialDto>().ReverseMap();
        }
    }
}
