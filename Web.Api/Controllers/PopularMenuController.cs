using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManager.BusinessLayer.Abstract;
using RestaurantManager.DtoLayer.ChefsDto;
using RestaurantManager.DtoLayer.PopularMenuDto;
using RestaurantManager.EntityLayer.Entities;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularMenuController : ControllerBase
    {

        private readonly IPopularMenuService _popularMenuService;
        private readonly IMapper _mapper;

        public PopularMenuController(IPopularMenuService popularMenuService, IMapper mapper)
        {
            _popularMenuService = popularMenuService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult PopularMenuList()
        {
            var value = _mapper.Map<List<ResultPopularMenuDto>>(_popularMenuService.TGetlistAll());
            return Ok(value);
        }


        [HttpPost]
        public IActionResult CreatePopularMenu(CreatePopularMenuDto createPopularMenuDto)
        {
            _popularMenuService.TAdd(new PopularMenu()
            {
               BreakfastName = createPopularMenuDto.BreakfastName,
               BreakfestDescription = createPopularMenuDto.BreakfestDescription,
               BreakfastPrice = createPopularMenuDto.BreakfastPrice,
               BreakfastImageUrl = createPopularMenuDto.BreakfastImageUrl,
               LaunchName = createPopularMenuDto.LaunchName,
               LaunchDescription = createPopularMenuDto.LaunchDescription,
               LaunchPrice = createPopularMenuDto.LaunchPrice,
               LaunchImageUrl = createPopularMenuDto.LaunchImageUrl,
               DinnerName = createPopularMenuDto.DinnerName,
               DinnerDescription = createPopularMenuDto.DinnerDescription,
               DinnerPrice = createPopularMenuDto.DinnerPrice,
               DinnerImageUrl = createPopularMenuDto.DinnerImageUrl
            });
            return Ok("Popüler Menü Bilgisi Başarılı Bir Şekilde Eklendi. ");
        }

		[HttpDelete("{id}")]
		public IActionResult DeletePopularMenu(int id)
        {
            var value = _popularMenuService.TGetById(id);
            _popularMenuService.TDelete(value);
            return Ok("Chef Bilgisi Başarılı Bir Şekilde Silindi!");
        }

		[HttpGet("{id}")]
		public IActionResult GetPopularMenu(int id)
        {
            var value = _popularMenuService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdatePopularMenu(UpdatePopularMenuDto updatePopularMenuDto)
        {
            _popularMenuService.TUpdate(new PopularMenu()
            {
               PopularMenuId = updatePopularMenuDto.PopularMenuId,
                BreakfastName = updatePopularMenuDto.BreakfastName,
                BreakfestDescription = updatePopularMenuDto.BreakfestDescription,
                BreakfastPrice = updatePopularMenuDto.BreakfastPrice,
                BreakfastImageUrl = updatePopularMenuDto.BreakfastImageUrl,
                LaunchName = updatePopularMenuDto.LaunchName,
                LaunchDescription = updatePopularMenuDto.LaunchDescription,
                LaunchPrice = updatePopularMenuDto.LaunchPrice,
                LaunchImageUrl = updatePopularMenuDto.LaunchImageUrl,
                DinnerName = updatePopularMenuDto.DinnerName,
                DinnerDescription = updatePopularMenuDto.DinnerDescription,
                DinnerPrice = updatePopularMenuDto.DinnerPrice,
                DinnerImageUrl = updatePopularMenuDto.DinnerImageUrl
            });
            return Ok("Popüler Menü Bilgisi Başarılı Bir Şekilde Güncellendi!");
        }
    }
}
