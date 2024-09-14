using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
    }
}
