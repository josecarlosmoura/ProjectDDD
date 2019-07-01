using DDDApplication.Domain.Entites;
using System.Collections.Generic;

namespace DDDApplication.Domain.Interfaces.Services
{
    public interface IProductService : IServiceBase<Product>
    {
        IEnumerable<Product> GetByDescription(string description);
    }
}
