using System;
using System.Collections.Generic;
using System.Linq;

namespace DI
{
    public interface ICustomerProcessor
    {
        void UpdateCustomerOrder(string customer, string product);
    }
}
