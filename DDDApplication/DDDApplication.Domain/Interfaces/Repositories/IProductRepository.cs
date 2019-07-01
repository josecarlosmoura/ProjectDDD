using DDDApplication.Domain.Entites;
using System.Collections.Generic;

namespace DDDApplication.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> GetByDescription(string description);
    }
}
