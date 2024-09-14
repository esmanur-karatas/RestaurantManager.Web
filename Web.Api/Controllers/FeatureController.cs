using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManager.BusinessLayer.Abstract;
using RestaurantManager.DtoLayer.ChefsDto;
using RestaurantManager.DtoLayer.FeatureDto;
using RestaurantManager.EntityLayer.Entities;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {

        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {
            var value = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetlistAll());
            return Ok(value);
        }


        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            _featureService.TAdd(new Feature()
            {
                FeatureTitle = createFeatureDto.FeatureTitle,
                FeatureDescription = createFeatureDto.FeatureDescription,
                FeatureImageUrl = createFeatureDto.FeatureImageUrl,
            });
            return Ok("Feature Bilgisi Başarılı Bir Şekilde Eklendi. ");
        }

		[HttpDelete("{id}")]
		public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetById(id);
            _featureService.TDelete(value);
            return Ok("Feature Bilgisi Başarılı Bir Şekilde Silindi!");
        }

		[HttpGet("{id}")]
		public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            _featureService.TUpdate(new Feature()
            {
                FeatureId = updateFeatureDto.FeatureId,
                FeatureTitle = updateFeatureDto.FeatureTitle,
                FeatureDescription = updateFeatureDto.FeatureDescription,
                FeatureImageUrl = updateFeatureDto.FeatureImageUrl,
            });
            return Ok("Feature Bilgisi Başarılı Bir Şekilde Güncellendi!");
        }
    }
}
