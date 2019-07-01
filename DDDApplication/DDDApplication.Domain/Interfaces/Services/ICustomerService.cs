using DDDApplication.Domain.Entites;
using System.Collections.Generic;

namespace DDDApplication.Domain.Interfaces.Services
{
    public interface ICustomerService : IServiceBase<Customer>
    {
        IEnumerable<Customer> GetSpacialCustomer(IEnumerable<Customer> customers);
    }
}