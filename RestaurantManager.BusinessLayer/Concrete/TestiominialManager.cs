using RestaurantManager.BusinessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.BusinessLayer.Concrete
{
    public class TestiominialManager : ITestiomonialService
    {
        private readonly ITestiomonialDal _testiomonialDal;

        public TestiominialManager(ITestiomonialDal testiomonialDal)
        {
            _testiomonialDal = testiomonialDal;
        }

        public void TAdd(Testiomonial entity)
        {
            _testiomonialDal.Add(entity);
        }

        public void TDelete(Testiomonial entity)
        {
            _testiomonialDal.Delete(entity);
        }

        public Testiomonial TGetById(int id)
        {
            return _testiomonialDal.GetById(id);
        }

        public List<Testiomonial> TGetlistAll()
        {
            return _testiomonialDal.GetlistAll();
        }

        public void TUpdate(Testiomonial entity)
        {
            _testiomonialDal.Update(entity);
        }
    }
}
