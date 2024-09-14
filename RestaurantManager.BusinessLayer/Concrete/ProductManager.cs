using RestaurantManager.BusinessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
    public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Product entity)
        {
            _productDal.Add(entity);
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> TGetlistAll()
        {
            return _productDal.GetlistAll();
        }

        public List<Product> TGetProductsWithCategories()
        {
           return _productDal.GetProductsWithCategories();
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
