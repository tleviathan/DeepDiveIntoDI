using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.WCF
{
    public class SampleService : ISampleService
    {
        public SampleService(IDependency dependency)
        {
            _Dependency = dependency;
        }

        IDependency _Dependency;

        public void PerformOperation()
        {
            _Dependency.ShowToConsole();
        }
    }
}
