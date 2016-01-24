using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.Coupled
{
    public class Notifier
    {
        public void SendReceipt(OrderInfo orderInfo)
        {
            // send email to customer with receipt
            Console.WriteLine(string.Format("Receipt sent to customer '{0}' via email.", orderInfo.CustomerName));
        }
    }
}
