using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Concrete;
using RestaurantManager.DataAccessLayer.Repositories;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericReposiyory<Booking>, IBookingDal
    {
        public EfBookingDal(RestaurantManagerContext context) : base(context)
        {
        }
    }
}
