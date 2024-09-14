using RestaurantManager.BusinessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.BusinessLayer.Concrete
{
    public class ChefsManager : IChefsService
    {
        private readonly IChefsDal _chefsDal;

        public ChefsManager(IChefsDal chefsDal)
        {
            _chefsDal = chefsDal;
        }

        public void TAdd(Chefs entity)
        {
            _chefsDal.Add(entity);
        }

        public void TDelete(Chefs entity)
        {
            _chefsDal.Delete(entity);
        }

        public Chefs TGetById(int id)
        {
            return _chefsDal.GetById(id);
        }

        public List<Chefs> TGetlistAll()
        {
            return _chefsDal.GetlistAll();
        }

        public void TUpdate(Chefs entity)
        {
            _chefsDal.Update(entity);
        }
    }
}
