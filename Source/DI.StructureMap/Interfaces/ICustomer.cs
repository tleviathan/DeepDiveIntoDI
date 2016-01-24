using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.StructureMap
{
    public interface ICustomer
    {
        void UpdateCustomerOrder(string customer, string product);
    }
}
