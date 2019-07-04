using DDDApplication.Domain.Entites;
using System.Collections.Generic;

namespace DDDApplication.Application.Interface
{
    public interface ICustomerAppService : IAppServiceBase<Customer>
    {
        IEnumerable<Customer> GetSpacialCustomer();

        IEnumerable<Customer> FindCustomersByName(string framentName);
    }
}
