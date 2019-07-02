using DDDApplication.Domain.Interfaces.Services;
using DDDApplication.Domain.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDApplication.CrossCutting.InversionOfControl.Modules
{
    public class ServiceNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<ICustomerService>().To<CustomerService>();
            Bind<IProductService>().To<ProductService>();
        }
    }
}
