using System;
using System.Collections.Generic;
using System.Linq;
using Ninject;

namespace DI.NInject
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel container = new StandardKernel();
            container.Bind<IBillingProcessor>().To<BillingProcessor>();
            container.Bind<ICustomer>().To<Customer>();
            container.Bind<INotifier>().To<Notifier>();
            container.Bind<ILogger>().To<Logger>();

            Console.WriteLine("NInject DI Container Example");
            Console.WriteLine();

            OrderInfo orderInfo = new OrderInfo()
            {
                CustomerName = "Miguel Castro",
                Email = "miguel@dotnetdude.com",
                Product = "Laptop",
                Price = 1200,
                CreditCard = "1234567890"
            };

            Console.WriteLine("Production:");
            Console.WriteLine();

            Commerce commerce = container.Get<Commerce>();
            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }
}
