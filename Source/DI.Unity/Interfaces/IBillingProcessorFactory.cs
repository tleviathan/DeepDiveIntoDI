using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.Unity
{
    public interface IBillingProcessorFactory
    {
        IBillingProcessor GetBillingProcessor();
    }
}
