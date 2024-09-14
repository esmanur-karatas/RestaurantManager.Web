
using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Concrete;
using RestaurantManager.DataAccessLayer.Repositories;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericReposiyory<About>, IAboutDal
    {
        public EfAboutDal(RestaurantManagerContext context) : base(context)
        {
        }
    }
}
