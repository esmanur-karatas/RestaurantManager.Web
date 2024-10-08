﻿using RestaurantManager.DataAccessLayer.Abstract;
using RestaurantManager.DataAccessLayer.Concrete;
using RestaurantManager.DataAccessLayer.Repositories;
using RestaurantManager.EntityLayer.Entities;

namespace RestaurantManager.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericReposiyory<Category>, ICategoryDal
    {
        public EfCategoryDal(RestaurantManagerContext context) : base(context)
        {
        }

        public int CategoryCount()
        {
            using var context = new RestaurantManagerContext();
            return context.Categories.Count();
        }
    }
}
