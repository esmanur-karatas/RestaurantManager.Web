using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DtoLayer.FeatureDto
{
    public class CreateFeatureDto
    {
        public string FeatureTitle { get; set; }
        public string FeatureDescription { get; set; }
        public string FeatureImageUrl { get; set; }
    }
}
