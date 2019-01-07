using DomainValidation.Interfaces.Specification;
using GG.CadastroClientesDDD.Domain.Entities;
using GG.CadastroClientesDDD.Domain.ValueObjects;

namespace GG.CadastroClientesDDD.Domain.Specifications.Customers
{
    class CustomerMustHaveValidatedDocument : ISpecification<Customer>
    {
        public bool IsSatisfiedBy(Customer customer)
        {
            return CPF.Validate(customer.CPF);
        }
    }
}
