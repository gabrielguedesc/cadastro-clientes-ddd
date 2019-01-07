using GG.CadastroClientesDDD.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace GG.CadastroClientesDDD.Application.Interfaces
{
    public interface ICustomerAppService
    {
        CustomerViewModel Add(CustomerViewModel customer);
        CustomerViewModel GetById(Guid id);
        IEnumerable<CustomerViewModel> GetAllCustomersActive();
        CustomerViewModel Update(CustomerViewModel customer);
        void Remove(Guid id);
    }
}
