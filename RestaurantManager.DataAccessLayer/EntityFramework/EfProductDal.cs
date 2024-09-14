
using Microsoft.EntityFrameworkCore;
using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Concrete;
using RestaurantManager.DataAccessLayer.Repositories;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericReposiyory<Product>, IProductDal
    {
        public EfProductDal(RestaurantManagerContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new RestaurantManagerContext();
            var values = context.Product.Include(x => x.Category).ToList();
            return values;
        }
    }
}
