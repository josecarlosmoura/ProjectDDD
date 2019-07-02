using CommonServiceLocator.NinjectAdapter.Unofficial;
using DDDApplication.CrossCutting.InversionOfControl.Modules;
using Microsoft.Practices.ServiceLocation;
using Ninject;

namespace DDDApplication.CrossCutting.InversionOfControl
{
    public class IoC
    {
        public IKernel Kernel { get; private set; }

        public IoC()
        {
            Kernel = GetNinjectModules();
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(Kernel));
        }

        /// <summary>
        /// Load your modules and return services here!
        /// </summary>
        /// <param></param>
        private IKernel GetNinjectModules()
        {
            return new StandardKernel(
                new ServiceNinjectModule(),
                new RepositoryNinjectModule(),
                new ApplicationNinjectModule());
        }
    }
}
