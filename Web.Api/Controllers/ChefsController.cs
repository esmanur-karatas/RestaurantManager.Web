using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManager.BusinessLayer.Abstract;
using RestaurantManager.DtoLayer.CategoryDto;
using RestaurantManager.DtoLayer.ChefsDto;
using RestaurantManager.EntityLayer.Entities;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefsController : ControllerBase
    {
        private readonly IChefsService _chefsService;
        private readonly IMapper _mapper;

        public ChefsController(IChefsService chefsService, IMapper mapper)
        {
            _chefsService = chefsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ChefsList()
        {
            var value = _mapper.Map<List<ResultChefsDto>>(_chefsService.TGetlistAll());
            return Ok(value);
        }


        [HttpPost]
        public IActionResult CreateChefs(CreateChefsDto createChefsDto)
        {
            _chefsService.TAdd(new Chefs()
            {
                ChefsTitle = createChefsDto.ChefsTitle,
                ChefsSubtitle = createChefsDto.ChefsSubtitle,
                ChefsName = createChefsDto.ChefsName,
                ChefsDescription = createChefsDto.ChefsDescription,
                ChefsImageUrl = createChefsDto.ChefsImageUrl,
            });
            return Ok("Chefs Bilgisi Başarılı Bir Şekilde Eklendi. ");
        }

		[HttpDelete("{id}")]
		public IActionResult DeleteChefs(int id)
        {
            var value = _chefsService.TGetById(id);
            _chefsService.TDelete(value);
            return Ok("Chef Bilgisi Başarılı Bir Şekilde Silindi!");
        }

		[HttpGet("{id}")]
		public IActionResult GetChefs(int id)
        {
            var value = _chefsService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateChefs(UpdateChefsDto updateChefsDto)
        {
            _chefsService.TUpdate(new Chefs()
            {
                ChefsId = updateChefsDto.ChefsId,
                ChefsTitle = updateChefsDto.ChefsTitle,
                ChefsSubtitle = updateChefsDto.ChefsSubtitle,
                ChefsName = updateChefsDto.ChefsName,
                ChefsDescription = updateChefsDto.ChefsDescription,
                ChefsImageUrl = updateChefsDto.ChefsImageUrl,
            });
            return Ok("Chefs Bilgisi Başarılı Bir Şekilde Güncellendi!");
        }
    }
}
