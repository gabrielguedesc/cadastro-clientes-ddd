using DomainValidation.Interfaces.Specification;
using GG.CadastroClientesDDD.Domain.Entities;
using System;

namespace GG.CadastroClientesDDD.Domain.Specifications.Customers
{
    class CustomerMustBeOfLegalAge : ISpecification<Customer>
    {
        public bool IsSatisfiedBy(Customer customer)
        {
            return DateTime.Now.Year - customer.BirthDate.Year >= 18;
        }
    }
}
