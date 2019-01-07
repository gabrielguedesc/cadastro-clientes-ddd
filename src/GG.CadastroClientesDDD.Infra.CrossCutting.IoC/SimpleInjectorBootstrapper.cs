using GG.CadastroClientesDDD.Application.Interfaces;
using GG.CadastroClientesDDD.Application.Services;
using GG.CadastroClientesDDD.Domain.Interfaces.Repository;
using GG.CadastroClientesDDD.Domain.Interfaces.Services;
using GG.CadastroClientesDDD.Domain.Services;
using GG.CadastroClientesDDD.Infra.Data.Repository;
using SimpleInjector;

namespace GG.CadastroClientesDDD.Infra.CrossCutting.IoC
{
    public class SimpleInjectorBootstrapper
    {
        public static void Register(Container container)
        {
            //Application
            container.Register<ICustomerAppService, CustomerAppService>(Lifestyle.Scoped);
            
            //Data
            container.Register<ICustomerRepository, CustomerRepository>(Lifestyle.Scoped);

            //Domain
            container.Register<ICustomerService, CustomerService>(Lifestyle.Scoped);
        }
    }
}
