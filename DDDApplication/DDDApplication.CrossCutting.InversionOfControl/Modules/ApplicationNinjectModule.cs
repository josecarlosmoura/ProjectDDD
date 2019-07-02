using DDDApplication.Application;
using DDDApplication.Application.Interface;
using Ninject.Modules;

namespace DDDApplication.CrossCutting.InversionOfControl.Modules
{
    public class ApplicationNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<ICustomerAppService>().To<CustomerAppService>();
            Bind<IProductAppService>().To<ProductAppService>();
        }
    }
}
