using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace DI.WCF
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        void PerformOperation();
    }
}
