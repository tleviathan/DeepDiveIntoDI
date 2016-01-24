using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.WebForms
{
    public interface ICustomerRepository
    {
        Customer GetById(int id);
        List<Customer> GetAll();
        void Update(Customer customer);
    }
}
