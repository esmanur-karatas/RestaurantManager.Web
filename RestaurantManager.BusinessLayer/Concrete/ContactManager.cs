using RestaurantManager.BusinessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {

        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void TDelete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public Contact TGetById(int id)
        {
           return _contactDal.GetById(id);
        }

        public List<Contact> TGetlistAll()
        {
            return _contactDal.GetlistAll();
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
       
