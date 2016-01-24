using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.WCF
{
    public class DependencyComponent : IDependency
    {
        public void ShowToConsole()
        {
            Console.WriteLine("This text was outputed from the dependency component.");
        }
    }
}
