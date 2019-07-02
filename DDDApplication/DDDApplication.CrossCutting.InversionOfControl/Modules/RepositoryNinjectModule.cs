using DDDApplication.Domain.Interfaces.Repositories;
using DDDApplication.Infra.Data.Repository;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDApplication.CrossCutting.InversionOfControl.Modules
{
    public class RepositoryNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<ICustomerRepository>().To<CustomerRepository>();
            Bind<IProductRepository>().To<ProductRepository>();
        }
    }
}
