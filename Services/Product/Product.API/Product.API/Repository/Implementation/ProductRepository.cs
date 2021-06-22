using Microsoft.EntityFrameworkCore;
using Product.API.DBContexts;
using Product.API.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Product.API.Repository.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;

        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Models.Product GetProductByID(Guid productId)
        {
            return _dbContext.Products.Find(productId);
        }

        public List<Models.Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void InsertProduct(Models.Product product)
        {
            _dbContext.Add(product);
            Save();
        }

        public void UpdateProduct(Models.Product product)
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
