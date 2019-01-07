using GG.CadastroClientesDDD.Domain.Interfaces.Repository;
using GG.CadastroClientesDDD.Infra.Data.Repository;
using SimpleInjector;

namespace GG.CadastroClientesDDD.Infra.CrossCutting.IoC
{
    public class SimpleInjectorBootstraper
    {
        public static void Register(Container container)
        {
            //Data
            container.Register<ICustomerRepository, CustomerRepository>(Lifestyle.Scoped);
        }
    }
}
