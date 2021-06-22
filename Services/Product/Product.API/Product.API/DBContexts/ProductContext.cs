using Microsoft.EntityFrameworkCore;
using Product.API.Models;
using System;

namespace Product.API.DBContexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Category> Categories { get; set; }

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
