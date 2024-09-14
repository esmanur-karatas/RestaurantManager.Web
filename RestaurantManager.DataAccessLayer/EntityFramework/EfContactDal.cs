
using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Concrete;
using RestaurantManager.DataAccessLayer.Repositories;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericReposiyory<Contact>, IContactDal
    {
        public EfContactDal(RestaurantManagerContext context) : base(context)
        {
        }
    }
}
