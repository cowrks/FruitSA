using Common.Models.Product;
using Microsoft.EntityFrameworkCore;
using System;

namespace ProductAPI.DBContexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = Guid.NewGuid(),
                    Name = "Grapes",
                    CategoryCode = "Grapes",
                    IsActive = true
                },
                new Category
                {
                    CategoryId = Guid.NewGuid(),
                    Name = "Apples",
                    CategoryCode = "Apples",
                    IsActive = true
                },
                new Category
                {
                    CategoryId = Guid.NewGuid(),
                    Name = "Pears",
                    CategoryCode = "Pears",
                    IsActive = true
                }
            );
        }
    }
}
