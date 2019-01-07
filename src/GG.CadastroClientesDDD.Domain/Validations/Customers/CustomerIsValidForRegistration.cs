using DomainValidation.Validation;
using GG.CadastroClientesDDD.Domain.Entities;
using GG.CadastroClientesDDD.Domain.Specifications.Customers;

namespace GG.CadastroClientesDDD.Domain.Validations.Customers
{
    class CustomerIsConsistent : Validator<Customer>
    {
        public CustomerIsConsistent()
        {
            var customerMustBeOfLegalAge = new CustomerMustBeOfLegalAge();
            var customerMustHaveValidatedDocument = new CustomerMustHaveValidatedDocument();

            base.Add("customerMustBeOfLegalAge", new Rule<Customer>(customerMustBeOfLegalAge, "O cliente deve ser maior de idade."));
            base.Add("customerMustHaveValidatedDocument", new Rule<Customer>(customerMustHaveValidatedDocument, "O cliente deve ter um documento válido."));
        }
    }
}
