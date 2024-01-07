using Microsoft.EntityFrameworkCore;
using ProductAPI.Entities;

namespace ProductAPI.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> option) : base(option)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category>Categories { get; set; }
     }
}
