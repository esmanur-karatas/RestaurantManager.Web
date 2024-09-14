using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DtoLayer.BookingDto
{
    public class UpdateBookingDto
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
