using GG.CadastroClientesDDD.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace GG.CadastroClientesDDD.Infra.Data.EntityConfig
{
    public class CustomerConfig : EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            HasKey(c => c.Id);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength()
                 .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_CPF") { IsUnique = true }));

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.BirthDate)
                .IsRequired();

            Ignore(c => c.ValidationResult);

            ToTable("Customers");
        }
    }
}
