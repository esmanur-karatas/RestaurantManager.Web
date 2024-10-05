using RestaurantManager.EntityLayer.Entities;


namespace RestaurantManager.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        public int CategoryCount();
    }
}
