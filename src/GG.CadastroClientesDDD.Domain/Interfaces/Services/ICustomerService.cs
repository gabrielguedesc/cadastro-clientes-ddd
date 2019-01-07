using GG.CadastroClientesDDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace GG.CadastroClientesDDD.Domain.Interfaces.Services
{
    public interface ICustomerService
    {
        Customer Add(Customer customer);
        Customer GetById(Guid id);
        Customer GetByCPF(string cpf);
        Customer GetByEmail(string email);
        IEnumerable<Customer> GetAllCustomersActive();
        Customer Update(Customer customer);
        void Remove(Guid id);
    }
}
