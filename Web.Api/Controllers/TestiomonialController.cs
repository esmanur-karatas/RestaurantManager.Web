using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManager.BusinessLayer.Abstract;
using RestaurantManager.DtoLayer.SocialMediaDto;
using RestaurantManager.DtoLayer.TestiomonialDto;
using RestaurantManager.EntityLayer.Entities;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestiomonialController : ControllerBase
    {
        private readonly ITestiomonialService _testiomonialService;
        private readonly IMapper _mapper;

        public TestiomonialController(ITestiomonialService testiomonialService, IMapper mapper)
        {
            _testiomonialService = testiomonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestiomonialList()
        {
            var value = _mapper.Map<List<ResultTestiomonialDto>>(_testiomonialService.TGetlistAll());
            return Ok(value);
        }


        [HttpPost]
        public IActionResult CreateTestiomonial(CreateTestiomonialDto createTestiomonialDto)
        {
            _testiomonialService.TAdd(new Testiomonial()
            {
                TestiomonialName = createTestiomonialDto.TestiomonialName,
                TestiomonialDescription = createTestiomonialDto.TestiomonialDescription,
                TestiomonialImageUrl = createTestiomonialDto.TestiomonialImageUrl
            });
            return Ok("Yorumlar Başarılı Bir Şekilde Eklendi. ");
        }

		[HttpDelete("{id}")]
		public IActionResult DeleteTestiomonial(int id)
        {
            var value = _testiomonialService.TGetById(id);
            _testiomonialService.TDelete(value);
            return Ok("Yorumlar Başarılı Bir Şekilde Silindi!");
        }

		[HttpGet("{id}")]
		public IActionResult GetTestiomonial(int id)
        {
            var value = _testiomonialService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateTestiomonial(UpdateTestiomonialDto updateTestiomonialDto)
        {
            _testiomonialService.TUpdate(new Testiomonial()
            {
               TestiomonialId = updateTestiomonialDto.TestiomonialId,
               TestiomonialName = updateTestiomonialDto.TestiomonialName,
               TestiomonialDescription = updateTestiomonialDto.TestiomonialDescription,
               TestiomonialImageUrl = updateTestiomonialDto.TestiomonialImageUrl
            });
            return Ok("Yorumlar Başarılı Bir Şekilde Güncellendi!");
        }
    }
}
