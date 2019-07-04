using System.Collections.Generic;
using System.Linq;
using DDDApplication.Domain.Entites;
using DDDApplication.Domain.Interfaces.Repositories;
using DDDApplication.Domain.Interfaces.Services;

namespace DDDApplication.Domain.Services
{
    public class CustomerService : ServiceBase<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository) :base (customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetSpacialCustomer(IEnumerable<Customer> customers)
        {
            return customers.Where(c => c.SpacialCustomer(c));
        }

        public IEnumerable<Customer> FindCustomersByName(string fragmentOfName)
        {
            return _customerRepository.FindCustomerByName(fragmentOfName);
        }
    }
}
