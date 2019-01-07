using GG.CadastroClientesDDD.Domain.Entities;
using GG.CadastroClientesDDD.Domain.Interfaces.Repository;
using GG.CadastroClientesDDD.Domain.Interfaces.Services;
using GG.CadastroClientesDDD.Domain.Validations.Customers;
using System;
using System.Collections.Generic;

namespace GG.CadastroClientesDDD.Domain.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer Add(Customer customer)
        {
            if (!customer.IsValid())
            {
                return customer;
            }

            customer.ValidationResult = new CustomerIsValidForRegistration().Validate(customer);
            if (!customer.ValidationResult.IsValid)
            {
                return customer;
            }

            return _customerRepository.Add(customer);
        }

        public IEnumerable<Customer> GetAllCustomersActive()
        {
            return _customerRepository.GetAllCustomersActive();
        }

        public Customer GetByCPF(string cpf)
        {
            return _customerRepository.GetByCPF(cpf);
        }

        public Customer GetByEmail(string email)
        {
            return _customerRepository.GetByEmail(email);
        }

        public Customer GetById(Guid id)
        {
            return _customerRepository.GetById(id);
        }

        public void Remove(Guid id)
        {
            _customerRepository.Remove(id);
        }

        public Customer Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }
    }
}
