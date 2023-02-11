using Genex.Shared;
using Microsoft.EntityFrameworkCore;

namespace Genex.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options) { }
        
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //category seeding
            modelBuilder.Entity<Category>().HasData(
              new Category { Id = 1, Name = "MotorBike", Url = "Motorbike", Icon = "aperture" },
              new Category { Id = 2, Name = "Cars", Url = "Car", Icon = "camera-slr" },
              new Category { Id = 3, Name = "Mobile Phones", Url = "MobilePhone", Icon = "calculator" }
                );


            modelBuilder.Entity<Product>().HasData
                (
                new Product 
                { Id = 1,
                CategoryId= 1,
                Title="Galaxy Motor",
                Description = "Product Descripton",
                Image = "https://bd.gaadicdn.com/processedimages/joye-bike/thunderbolt/640X309/thunderbolt6315ccda73896.jpg?tr=w-360",
                Price = 280000,

                },

                new Product
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Galaxy Car",
                    Description = "Product Descripton",
                    Image = "https://img.freepik.com/free-vector/modern-blue-urban-adventure-suv-vehicle-illustration_1344-205.jpg?w=2000",
                    Price = 280000,

                },

                 new Product
                 {
                     Id = 3,
                     CategoryId = 3,
                     Title = "Galaxy Phone",
                     Description = "Product Descripton",
                     Image = "https://m.media-amazon.com/images/I/61l9ppRIiqL._SX466_.jpg",
                     Price = 280000,

                 }
                );
        }



    }
}
