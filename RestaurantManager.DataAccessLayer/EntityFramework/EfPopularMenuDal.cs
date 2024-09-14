using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Concrete;
using RestaurantManager.DataAccessLayer.Repositories;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.DataAccessLayer.EntityFramework
{
    public class EfPopularMenuDal : GenericReposiyory<PopularMenu>, IPopularMenuDal
    {
        public EfPopularMenuDal(RestaurantManagerContext context) : base(context)
        {
        }
    }
}
