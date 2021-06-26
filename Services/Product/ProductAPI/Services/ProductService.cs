using Grpc.Core;
using GrpcProduct;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using ProductAPI.Repository.Interface;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services
{
    public class ProductService : Product.ProductBase
    {
        private readonly IProductRepository _repository;
        private readonly ILogger<ProductService> _logger;
        public ProductService(IProductRepository repository, ILogger<ProductService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [AllowAnonymous]
        public override async Task<ProductResponse> GetProducts(ProductRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Begin grpc call from method {Method}", context.Method);

            var data = await _repository.GetProducts();

            if (data != null)
            {
                //context.Status = new Status(StatusCode.OK, $"Basket with id {request.Id} do exist");

                //return MapToCustomerBasketResponse(data);
            }
            else
            {
                //context.Status = new Status(StatusCode.NotFound, $"Basket with id {request.Id} do not exist");
            }

            return new ProductResponse();
        }
    }
}
