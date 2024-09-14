using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Concrete;
using RestaurantManager.DataAccessLayer.Repositories;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.DataAccessLayer.EntityFramework
{
    public class EfSocialMediaDal : GenericReposiyory<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(RestaurantManagerContext context) : base(context)
        {
        }
    }
}
