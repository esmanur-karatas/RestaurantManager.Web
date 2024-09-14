using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManager.BusinessLayer.Abstract;
using RestaurantManager.DtoLayer.ChefsDto;
using RestaurantManager.DtoLayer.ContactDto;
using RestaurantManager.EntityLayer.Entities;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetlistAll());
            return Ok(value);
        }


        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                ContactPhone = createContactDto.ContactPhone,
                ContactLocation = createContactDto.ContactLocation,
                ContactEmail = createContactDto.ContactEmail,
                
            });
            return Ok("İletişim Bilgisi Başarılı Bir Şekilde Eklendi. ");
        }

		[HttpDelete("{id}")]
		public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return Ok("İletişim Bilgisi Başarılı Bir Şekilde Silindi!");
        }

		[HttpGet("{id}")]
		public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
                ContactId = updateContactDto.ContactId,
                ContactPhone = updateContactDto.ContactPhone,
                ContactLocation = updateContactDto.ContactLocation,
                ContactEmail = updateContactDto.ContactEmail,
            });
            return Ok("İletişim Bilgisi Başarılı Bir Şekilde Güncellendi!");
        }
    }
}
