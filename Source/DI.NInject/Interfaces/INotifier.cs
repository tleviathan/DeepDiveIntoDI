using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.NInject
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
