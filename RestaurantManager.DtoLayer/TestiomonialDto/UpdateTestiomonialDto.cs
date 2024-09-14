using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.DtoLayer.TestiomonialDto
{
    public class UpdateTestiomonialDto
    {
        public int TestiomonialId { get; set; }
        public string TestiomonialName { get; set; }
        public string TestiomonialDescription { get; set; }
        public string TestiomonialImageUrl { get; set; }
    }
}
