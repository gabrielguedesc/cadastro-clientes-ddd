using System;
using System.Collections.Generic;

namespace GG.CadastroClientesDDD.Domain.Entities
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Active { get; private set; }
        public bool Excluded { get; private set; }

        public Customer(string name, string email, string cpf, DateTime birthDate)
        {
            Name = name;
            Email = email;
            CPF = cpf;
            BirthDate = birthDate;
            Active = true;
            Excluded = false;
        }

        public Customer()
        {

        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public void SetAsExcluded()
        {
            Active = false;
            Excluded = true;
        }

        public void SetAsActive()
        {
            Active = true;
            Excluded = false;
        }
    }
}
