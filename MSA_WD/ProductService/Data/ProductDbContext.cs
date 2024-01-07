using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> option) : base(option)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
