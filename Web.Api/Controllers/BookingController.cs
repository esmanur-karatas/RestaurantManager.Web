using Microsoft.AspNetCore.Mvc;
using RestaurantManager.BusinessLayer.Abstract;
using RestaurantManager.DtoLayer.BookingDto;
using RestaurantManager.EntityLayer.Entities;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetlistAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                BookingTitle = createBookingDto.BookingTitle,
                BookingSubtitle = createBookingDto.BookingSubtitle,
                BookingName = createBookingDto.BookingName,
                BookingEmail = createBookingDto.BookingEmail,
                BookingDateTime = createBookingDto.BookingDateTime,
                BookingPersonCount = createBookingDto.BookingPersonCount,
                BookingSpecialRequest = createBookingDto.BookingSpecialRequest,
                
            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon Başarılı Bir Şekilde Eklendi!");
        }

        [HttpDelete ("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Başarılı Bir Şekilde Silindi! ");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                BookingId = updateBookingDto.BookingId,
                BookingTitle = updateBookingDto.BookingTitle,
                BookingSubtitle = updateBookingDto.BookingSubtitle,
                BookingName = updateBookingDto.BookingName,
                BookingEmail = updateBookingDto.BookingEmail,
                BookingDateTime = updateBookingDto.BookingDateTime,
                BookingPersonCount = updateBookingDto.BookingPersonCount,
                BookingSpecialRequest = updateBookingDto.BookingSpecialRequest,

            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon Başarılı Bir Şekilde Güncellendi!");
        }

		[HttpGet("{id}")]
		public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }
    }
}
