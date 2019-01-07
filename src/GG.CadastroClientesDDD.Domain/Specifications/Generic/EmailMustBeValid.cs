using DomainValidation.Interfaces.Specification;
using GG.CadastroClientesDDD.Domain.ValueObjects;

namespace GG.CadastroClientesDDD.Domain.Specifications.Generic
{
    class EmailMustBeValid : ISpecification<string>
    {
        public bool IsSatisfiedBy(string email)
        {
            return Email.Validate(email);
        }
    }
}
