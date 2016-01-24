using System;
using System.Collections.Generic;
using System.Linq;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace DI.CastleWindsor
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer container = new WindsorContainer();
            container.Register(Component.For<Commerce>()); // first class needs to be registered as well
            container.Register(Component.For<IBillingProcessor>().ImplementedBy<BillingProcessor>());
            container.Register(Component.For<ICustomer>().ImplementedBy<Customer>());
            container.Register(Component.For<INotifier>().ImplementedBy<Notifier>());
            container.Register(Component.For<ILogger>().ImplementedBy<Logger>());

            Console.WriteLine("Castle Windsor DI Container Example");
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

            Commerce commerce = container.Resolve<Commerce>();
            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }
}
