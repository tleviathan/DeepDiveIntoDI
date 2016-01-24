using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.StructureMap
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
