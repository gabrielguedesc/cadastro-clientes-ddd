using AutoMapper;
using GG.CadastroClientesDDD.Application.Interfaces;
using GG.CadastroClientesDDD.Application.ViewModels;
using GG.CadastroClientesDDD.Domain.Entities;
using GG.CadastroClientesDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace GG.CadastroClientesDDD.Application.Services
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerService _customerService;

        public CustomerAppService(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public CustomerViewModel Add(CustomerViewModel customerViewModel)
        {
            _customerService.Add(Mapper.Map<Customer>(customerViewModel));

            return customerViewModel;
        }

        public IEnumerable<CustomerViewModel> GetAllCustomersActive()
        {
            return Mapper.Map<IEnumerable<CustomerViewModel>>(_customerService.GetAllCustomersActive());
        }

        public CustomerViewModel GetById(Guid id)
        {
            return Mapper.Map<CustomerViewModel>(_customerService.GetById(id));
        }

        public void Remove(Guid id)
        {
            _customerService.Remove(id);
        }

        public CustomerViewModel Update(CustomerViewModel customerViewModel)
        {
            var customer = Mapper.Map<Customer>(customerViewModel);
            return Mapper.Map<CustomerViewModel>(_customerService.Update(customer));
        }
    }
}
