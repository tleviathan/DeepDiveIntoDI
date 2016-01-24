using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace DI.Unity
{
    public class UnityBillingProcessorFactory : IBillingProcessorFactory
    {
        IBillingProcessor IBillingProcessorFactory.GetBillingProcessor()
        {
            return Program.Container.Resolve<IBillingProcessor>();
        }
    }
}
