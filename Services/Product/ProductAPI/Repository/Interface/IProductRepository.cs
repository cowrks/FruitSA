using System;
using System.Collections.Generic;

namespace ProductAPI.Repository.Interface
{
    public interface IProductRepository
    {
        void DeleteProduct(Guid ProductId);
        Models.Product GetProductByID(Guid productId);
        List<Models.Product> GetProducts();
        void InsertProduct(Models.Product product);
        void UpdateProduct(Models.Product product);
    }
}