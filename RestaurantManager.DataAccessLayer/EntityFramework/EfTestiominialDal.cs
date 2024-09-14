
using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Concrete;
using RestaurantManager.DataAccessLayer.Repositories;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.DataAccessLayer.EntityFramework
{
    public class EfTestiominialDal : GenericReposiyory<Testiomonial>, ITestiomonialDal
    {
        public EfTestiominialDal(RestaurantManagerContext context) : base(context)
        {
        }
    }
}
