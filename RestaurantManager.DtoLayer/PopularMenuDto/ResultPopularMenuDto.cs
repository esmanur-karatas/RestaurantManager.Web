using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DtoLayer.PopularMenuDto
{
    public class ResultPopularMenuDto
    {
        public int PopularMenuId { get; set; }
        public string BreakfastName { get; set; }
        public string BreakfestDescription { get; set; }
        public int BreakfastPrice { get; set; }
        public int BreakfastImageUrl { get; set; }

        public string LaunchName { get; set; }
        public string LaunchDescription { get; set; }
        public int LaunchPrice { get; set; }
        public int LaunchImageUrl { get; set; }

        public string DinnerName { get; set; }
        public string DinnerDescription { get; set; }
        public int DinnerPrice { get; set; }
        public int DinnerImageUrl { get; set; }
    }
}
