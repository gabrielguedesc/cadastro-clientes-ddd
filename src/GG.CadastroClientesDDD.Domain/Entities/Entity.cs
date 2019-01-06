using DomainValidation.Validation;
using System;

namespace GG.CadastroClientesDDD.Domain.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = new Guid();
            ValidationResult = new ValidationResult();
        }

        public Guid Id { get; set; }
        public ValidationResult ValidationResult { get; set; }

        public abstract bool IsValid();

        public void AddValidationError(string message)
        {
            ValidationResult.Add(new ValidationError(message));
        }
    }
}
