using Microsoft.EntityFrameworkCore;
using RestaurantManager.EntityLayer.Entities;


namespace RestaurantManager.DataAccessLayer.Concrete
{
    public class RestaurantManagerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-6H04SC8; initial Catalog = RestaurantManagerDb; integrated Security =true; TrustServerCertificate=True;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chefs> Chefs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<PopularMenu> PopularMenus { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testiomonial> Testiomonials { get; set; }
    }
}
