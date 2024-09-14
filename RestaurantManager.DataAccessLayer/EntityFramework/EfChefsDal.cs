using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Concrete;
using RestaurantManager.DataAccessLayer.Repositories;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.DataAccessLayer.EntityFramework
{
    public class EfChefsDal : GenericReposiyory<Chefs>, IChefsDal
    {
        public EfChefsDal(RestaurantManagerContext context) : base(context)
        {
        }
    }
}
