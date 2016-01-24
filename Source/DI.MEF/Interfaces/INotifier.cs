using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.MEF
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
