using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Concrete;
using RestaurantManager.DataAccessLayer.Repositories;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericReposiyory<Feature>, IFeatureDal
    {
        public EfFeatureDal(RestaurantManagerContext context) : base(context)
        {
        }
    }
}
