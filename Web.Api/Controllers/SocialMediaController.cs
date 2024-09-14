using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManager.BusinessLayer.Abstract;
using RestaurantManager.DtoLayer.PopularMenuDto;
using RestaurantManager.DtoLayer.SocialMediaDto;
using RestaurantManager.EntityLayer.Entities;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetlistAll());
            return Ok(value);
        }


        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
             SocialMediaTitle = createSocialMediaDto.SocialMediaTitle,
             SocialMediaUrl = createSocialMediaDto.SocialMediaUrl,
             SocialMediaIcon = createSocialMediaDto.SocialMediaIcon,
            });
            return Ok("Sosyal Medya Bilgisi Başarılı Bir Şekilde Eklendi. ");
        }

		[HttpDelete("{id}")]
		public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetById(id);
            _socialMediaService.TDelete(value);
            return Ok("Sosyal Medya Bilgisi Başarılı Bir Şekilde Silindi!");
        }

		[HttpGet("{id}")]
		public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
                SocialMediaId = updateSocialMediaDto.SocialMediaId,
                SocialMediaTitle = updateSocialMediaDto.SocialMediaTitle,
                SocialMediaUrl= updateSocialMediaDto.SocialMediaUrl,
                SocialMediaIcon= updateSocialMediaDto.SocialMediaIcon,
            });
            return Ok("Sosyal Medya Bilgisi Başarılı Bir Şekilde Güncellendi!");
        }
    }
}
