﻿namespace Web.UI.Dtos.ContactDtos
{
    public class UpdateContactDto
    {
        public int ContactId { get; set; }
        public string ContactPhone { get; set; }
        public string ContactLocation { get; set; }
        public string ContactEmail { get; set; }
    }
}
