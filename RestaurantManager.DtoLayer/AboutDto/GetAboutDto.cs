using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DtoLayer.AboutDto
{
    public class GetAboutDto
    {
        public int AboutId { get; set; }
        public string AboutTitle { get; set; }
        public string AboutSubtitle { get; set; }
        public string AboutDescription { get; set; }
        public int AboutNumberOne { get; set; }
        public int AboutNumberTwo { get; set; }
        public string AboutNumberOneTitle { get; set; }
        public string AboutNumberTwoTitle { get; set; }
        public string AboutDescriptionOneTitle { get; set; }
        public string AboutDescriptionTwoTitle { get; set; }
        public string AboutImageUrlOne { get; set; }
        public string AboutImageUrlTwo { get; set; }
        public string AboutImageUrlThree { get; set; }
        public string AboutImageUrlFour { get; set; }
    }
}
