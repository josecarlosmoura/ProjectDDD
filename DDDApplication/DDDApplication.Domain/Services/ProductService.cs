using System.Collections.Generic;
using DDDApplication.Domain.Entites;
using DDDApplication.Domain.Interfaces.Repositories;
using DDDApplication.Domain.Interfaces.Services;

namespace DDDApplication.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetByDescription(string description)
        {
            return _productRepository.GetByDescription(description);
        }
    }
}
