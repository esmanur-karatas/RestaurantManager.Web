
namespace RestaurantManager.DtoLayer.BookingDto
{
    public class ResultBookingDto
    {
        public int BookingId { get; set; }
        public string BookingTitle { get; set; }
        public string BookingSubtitle { get; set; }
        public string BookingName { get; set; }
        public string BookingEmail { get; set; }
        public DateTime BookingDateTime { get; set; }
        public string BookingPersonCount { get; set; }
        public string BookingSpecialRequest { get; set; }
    }
}
