using System.Collections.Generic;
using DDDApplication.Application.Interface;
using DDDApplication.Domain.Entites;
using DDDApplication.Domain.Interfaces.Services;

namespace DDDApplication.Application
{
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly IProductService _productService;

        public ProductAppService(IProductService productService) : base(productService)
        {
            _productService = productService;
        }

        public IEnumerable<Product> GetByDescription(string description)
        {
            throw new System.NotImplementedException();
        }
    }
}
