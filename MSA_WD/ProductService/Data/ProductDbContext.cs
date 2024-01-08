﻿using Microsoft.EntityFrameworkCore;
using ProductAPI.Entities;

namespace ProductAPI.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> option) : base(option)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Title = "Electronics",
                    Description = "It includes all electronic equipments TV, Freeze, Washing Machines etc."
                });

            modelBuilder.Entity<Product>().HasData(new Product
                {
                    Id = 1,
                    Name = "MI LED",
                    ImageUrl = "https://m.media-amazon.com/images/I/713A5VksK6L._SX679_.jpg",
                    Price = 13000,
                    Description = "MI 80 Cm (32 Inches) A Series Hd Ready Smart Google LED Tv L32M8-5Ain (Black)",
                    CategoryId = 1
                });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Samtonic LED",
                ImageUrl = "https://m.media-amazon.com/images/I/411dUvxz1+L._SX679_.jpg",
                Price = 10000,
                Description = "Samtonic 80 cm (32 Inches) Full HD Smart Android LED TV | Powerful Audio Box Speakers | HDMI & USB Ports | Voice Remote (Black, 2023 Model)",
                CategoryId = 1
            });
        }
    }
}
