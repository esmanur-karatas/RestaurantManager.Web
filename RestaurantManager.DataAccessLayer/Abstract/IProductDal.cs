using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
    }
}
