using GG.CadastroClientesDDD.Domain.Entities;
using GG.CadastroClientesDDD.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;

namespace GG.CadastroClientesDDD.Infra.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public Customer GetByCPF(string cpf)
        {
            return Find(c => c.CPF == cpf).FirstOrDefault();
        }

        public Customer GetByEmail(string email)
        {
            return Find(c => c.Email == email).FirstOrDefault();
        }
    }
}
