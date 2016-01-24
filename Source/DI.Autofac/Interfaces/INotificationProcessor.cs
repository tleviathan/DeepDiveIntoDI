using System;
using System.Collections.Generic;
using System.Linq;

namespace DI
{
    public interface INotificationProcessor
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
