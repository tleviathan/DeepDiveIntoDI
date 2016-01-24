using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.CastleWindsor
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
