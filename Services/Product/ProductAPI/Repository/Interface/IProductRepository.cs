using Common.Models.Product;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductAPI.Repository.Interface
{
    public interface IProductRepository
    {
        void DeleteProduct(Guid ProductId);
        Product GetProductByID(Guid productId);
        Task<List<Product>> GetProducts();
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
    }
}