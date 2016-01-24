using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.WPF
{
    public interface ICustomerRepository
    {
        Customer GetById(int id);
        List<Customer> GetAll();
        void Update(Customer customer);
    }
}
