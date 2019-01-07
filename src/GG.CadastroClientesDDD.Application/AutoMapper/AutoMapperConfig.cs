using AutoMapper;
using GG.CadastroClientesDDD.Application.ViewModels;
using GG.CadastroClientesDDD.Domain.Entities;

namespace GG.CadastroClientesDDD.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(i =>
            {
                i.CreateMap<CustomerViewModel, Customer>();
            });
        }
    }
}
