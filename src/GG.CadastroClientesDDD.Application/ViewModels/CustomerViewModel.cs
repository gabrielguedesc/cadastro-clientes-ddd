using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GG.CadastroClientesDDD.Application.ViewModels
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {
            Id = Guid.NewGuid();
            ValidationResult = new DomainValidation.Validation.ValidationResult();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        [DisplayName("Nome do cliente")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O e-mail do cliente é obrigatório.")]
        [DisplayName("E-mail do cliente")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O CPF do cliente é obrigatório.")]
        [DisplayName("CPF do cliente")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "A data de nascimento do cliente é obrigatória.")]
        [Display(Name = "Data de nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime BirthDate { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        public DomainValidation.Validation.ValidationResult ValidationResult { get; set; }
    }
}
