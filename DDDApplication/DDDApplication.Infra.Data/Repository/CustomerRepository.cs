using System.Collections.Generic;
using System.Linq;
using DDDApplication.Domain.Entites;
using DDDApplication.Domain.Interfaces.Repositories;

namespace DDDApplication.Infra.Data.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public IEnumerable<Customer> FindCustomerByName(string fragmentOfName)
        {
            return context.Customers.Where(c => c.Name.Contains(fragmentOfName) || c.LastName.Contains(fragmentOfName));
        }
    }
}
