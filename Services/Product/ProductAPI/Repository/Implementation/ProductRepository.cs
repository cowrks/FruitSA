using Common.Models.Product;
using Microsoft.EntityFrameworkCore;
using ProductAPI.DBContexts;
using ProductAPI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Repository.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;

        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product GetProductByID(Guid productId)
        {
            return _dbContext.Products.Find(productId);
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }

        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            Save();
        }

        public void DeleteProduct(Guid ProductId)
        {
            throw new NotImplementedException();
        }

        private void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
