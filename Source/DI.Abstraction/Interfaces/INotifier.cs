using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.Abstraction
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
