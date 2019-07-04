using DDDApplication.Domain.Entites;
using System.Collections.Generic;

namespace DDDApplication.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository : IRepositoryBase<Customer>
    {
        IEnumerable<Customer> FindCustomerByName(string fragmentOfName);
    }
}
