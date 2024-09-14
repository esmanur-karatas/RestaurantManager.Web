using RestaurantManager.BusinessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.BusinessLayer.Concrete
{
    public class PopularMenuManager : IPopularMenuService
    {
        private readonly IPopularMenuDal _popularMenuDal;

        public PopularMenuManager(IPopularMenuDal popularMenuDal)
        {
            _popularMenuDal = popularMenuDal;
        }

        public void TAdd(PopularMenu entity)
        {
            _popularMenuDal.Add(entity);
        }

        public void TDelete(PopularMenu entity)
        {
            _popularMenuDal.Delete(entity);
        }

        public PopularMenu TGetById(int id)
        {
            return _popularMenuDal.GetById(id);
        }

        public List<PopularMenu> TGetlistAll()
        {
            return _popularMenuDal.GetlistAll();
        }

        public void TUpdate(PopularMenu entity)
        {
            _popularMenuDal.Update(entity);
        }
    }
}
