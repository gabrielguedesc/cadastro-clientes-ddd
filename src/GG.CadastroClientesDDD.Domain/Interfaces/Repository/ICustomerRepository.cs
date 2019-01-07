using GG.CadastroClientesDDD.Domain.Entities;

namespace GG.CadastroClientesDDD.Domain.Interfaces.Repository
{
    public interface ICustomerRepository : IRepositoryRead<Customer>, IRepositoryWrite<Customer>
    {
        Customer GetByCPF(string cpf);
        Customer GetByEmail(string email);
    }
}
