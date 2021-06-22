using System;
using System.Collections.Generic;

namespace Product.API.Repository.Interface
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