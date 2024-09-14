using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantManager.BusinessLayer.Abstract;
using RestaurantManager.DtoLayer.AboutDto;
using RestaurantManager.EntityLayer.Entities;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
		private readonly IAboutService _aboutService;
		private readonly IMapper _mapper;

		public AboutController(IAboutService aboutService, IMapper mapper)
		{
			_aboutService = aboutService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult AboutList()
		{
			var value = _mapper.Map<List<ResultAboutDto>>(_aboutService.TGetlistAll());
			return Ok(value);
		}


		[HttpPost]
		public IActionResult CreateAbout(CreateAboutDto createAboutDto)
		{
			_aboutService.TAdd(new About()
			{
				AboutTitle = createAboutDto.AboutTitle,
				AboutSubtitle = createAboutDto.AboutSubtitle,
				AboutDescription = createAboutDto.AboutDescription,
				AboutNumberOne = createAboutDto.AboutNumberOne,
				AboutNumberTwo = createAboutDto.AboutNumberTwo,
				AboutNumberOneTitle = createAboutDto.AboutNumberOneTitle,
				AboutNumberTwoTitle = createAboutDto.AboutNumberTwoTitle,
				AboutDescriptionOneTitle = createAboutDto.AboutDescriptionOneTitle,
				AboutDescriptionTwoTitle = createAboutDto.AboutDescriptionTwoTitle,
				AboutImageUrlOne = createAboutDto.AboutImageUrlOne,
				AboutImageUrlTwo = createAboutDto.AboutImageUrlTwo,
				AboutImageUrlThree = createAboutDto.AboutImageUrlThree,
				AboutImageUrlFour = createAboutDto.AboutImageUrlFour,
			});
			return Ok("Hakkımızda Bilgisi Başarılı Bir Şekilde Eklendi. ");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteAbout(int id)
		{
			var value = _aboutService.TGetById(id);
			_aboutService.TDelete(value);
			return Ok("Hakkımızda Bilgisi Başarılı Bir Şekilde Silindi!");
		}

		[HttpGet("{id}")]
		public IActionResult GetAbout(int id)
		{
			var value = _aboutService.TGetById(id);
			return Ok(value);
		}

		[HttpPut]
		public IActionResult UpdateCategory(updateAboutDto updateAboutDto)
		{
			_aboutService.TUpdate(new About()
			{
				AboutId = updateAboutDto.AboutId,
				AboutTitle = updateAboutDto.AboutTitle,
				AboutSubtitle = updateAboutDto.AboutSubtitle,
				AboutDescription = updateAboutDto.AboutDescription,
				AboutNumberOne = updateAboutDto.AboutNumberOne,
				AboutNumberTwo = updateAboutDto.AboutNumberTwo,
				AboutNumberOneTitle = updateAboutDto.AboutNumberOneTitle,
				AboutNumberTwoTitle = updateAboutDto.AboutNumberTwoTitle,
				AboutDescriptionOneTitle = updateAboutDto.AboutDescriptionOneTitle,
				AboutDescriptionTwoTitle = updateAboutDto.AboutDescriptionTwoTitle,
				AboutImageUrlOne = updateAboutDto.AboutImageUrlOne,
				AboutImageUrlTwo = updateAboutDto.AboutImageUrlTwo,
				AboutImageUrlThree = updateAboutDto.AboutImageUrlThree,
				AboutImageUrlFour = updateAboutDto.AboutImageUrlFour,
			});
			return Ok("Hakkımda Bilgisi Başarılı Bir Şekilde Güncellendi!");
		}
	}
}

