using DDDApplication.Domain.Entites;
using System.Collections.Generic;

namespace DDDApplication.Application.Interface
{
    public interface IProductAppService : IAppServiceBase<Product>
    {
        IEnumerable<Product> GetByDescription(string description);
    }
}
