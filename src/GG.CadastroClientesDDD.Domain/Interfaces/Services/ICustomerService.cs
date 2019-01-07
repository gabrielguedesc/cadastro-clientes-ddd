using GG.CadastroClientesDDD.Domain.Entities;
using System;

namespace GG.CadastroClientesDDD.Domain.Interfaces.Services
{
    public interface ICustomerService
    {
        Customer Add(Customer customer);
        Customer GetById(Guid id);
        Customer GetByCPF(string cpf);
        Customer GetByEmail(string email);
        Customer Update(Customer customer);
        void Remove(Guid id);
    }
}
