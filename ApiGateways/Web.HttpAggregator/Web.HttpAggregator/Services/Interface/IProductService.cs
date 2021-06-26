using Common.Models.Product;
using System.Collections.Generic;

namespace Web.HttpAggregator.Services.Interface
{
    public interface IProductService
    {
        public List<Product> GetProducts();
    }
}