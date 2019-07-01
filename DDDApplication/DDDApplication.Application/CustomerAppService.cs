using System.Collections.Generic;
using DDDApplication.Application.Interface;
using DDDApplication.Domain.Entites;
using DDDApplication.Domain.Interfaces.Services;

namespace DDDApplication.Application
{
    public class CustomerAppService : AppServiceBase<Customer>, ICustomerAppService
    {
        private readonly ICustomerService _customerService;

        public CustomerAppService(ICustomerService customerService) : base(customerService)
        {
            _customerService = customerService;
        }

        public IEnumerable<Customer> GetSpacialCustomer()
        {
            return _customerService.GetSpacialCustomer(_customerService.GetAll());
            throw new System.NotImplementedException();
        }
    }
}
