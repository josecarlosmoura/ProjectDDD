using DDDApplication.Domain.Entites;
using DDDApplication.Domain.Interfaces.Repositories;

namespace DDDApplication.Infra.Data.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
    }
}
