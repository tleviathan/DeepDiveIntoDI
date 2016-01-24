using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.PoorMansContainer
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
