using DomainValidation.Interfaces.Specification;
using GG.CadastroClientesDDD.Domain.ValueObjects;

namespace GG.CadastroClientesDDD.Domain.Specifications.Generic
{
    class CPFMustBeValid : ISpecification<string>
    {
        public bool IsSatisfiedBy(string cpf)
        {
            return CPF.Validate(cpf);
        }
    }
}
