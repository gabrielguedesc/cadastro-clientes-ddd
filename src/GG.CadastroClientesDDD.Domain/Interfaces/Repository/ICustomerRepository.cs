using GG.CadastroClientesDDD.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace GG.CadastroClientesDDD.Domain.Interfaces.Repository
{
    public interface ICustomerRepository : IRepositoryRead<Customer>, IRepositoryWrite<Customer>
    {
        Customer GetByCPF(string cpf);
        Customer GetByEmail(string email);
        IEnumerable<Customer> GetAllCustomersActive();
    }
}
