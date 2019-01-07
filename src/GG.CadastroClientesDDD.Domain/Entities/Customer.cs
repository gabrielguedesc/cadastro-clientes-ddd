using GG.CadastroClientesDDD.Domain.Validations.Customers;
using System;

namespace GG.CadastroClientesDDD.Domain.Entities
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDate { get; set; }
        
        public Customer(string name, string email, string cpf, DateTime birthDate)
        {
            Name = name;
            Email = email;
            CPF = cpf;
            BirthDate = birthDate;
        }

        public Customer()
        {

        }

        public override bool IsValid()
        {
            ValidationResult = new CustomerIsConsistent().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
