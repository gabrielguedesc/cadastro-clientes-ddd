using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GG.CadastroClientesDDD.Application.ViewModels
{
    public class CustomerViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        [DisplayName("Nome do cliente")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O e-mail do cliente é obrigatório.")]
        [DisplayName("Nome do cliente")]
        public string Email { get; set; }


        [Required(ErrorMessage = "O CPF do cliente é obrigatório.")]
        [DisplayName("CPF do cliente")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "A data de nascimento do cliente é obrigatória.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido.")]
        [Display(Name = "Data de nascimento do cliente")]
        public DateTime BirthDate { get; set; }

        [ScaffoldColumn(false)]
        public bool Active { get; private set; }
    }
}
