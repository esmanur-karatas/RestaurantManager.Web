﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DtoLayer.SocialMediaDto
{
    public class UpdateSocialMediaDto
    {
        public int SocialMediaId { get; set; }
        public string SocialMediaTitle { get; set; }
        public string SocialMediaUrl { get; set; }
        public string SocialMediaIcon { get; set; }
    }
}
