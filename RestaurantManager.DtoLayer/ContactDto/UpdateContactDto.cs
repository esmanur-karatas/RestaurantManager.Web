﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DtoLayer.ContactDto
{
    public class UpdateContactDto
    {
        public int ContactId { get; set; }
        public string ContactPhone { get; set; }
        public string ContactLocation { get; set; }
        public string ContactEmail { get; set; }
    }
}
