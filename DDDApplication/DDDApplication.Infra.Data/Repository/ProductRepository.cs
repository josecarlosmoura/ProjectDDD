using System.Collections.Generic;
using System.Linq;
using DDDApplication.Domain.Entites;
using DDDApplication.Domain.Interfaces.Repositories;

namespace DDDApplication.Infra.Data.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetByDescription(string description)
        {
            return context.Products.Where(p => p.Description.Equals(description));
        }
    }
}
