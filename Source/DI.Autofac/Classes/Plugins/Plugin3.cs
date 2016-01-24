using System;
using System.Collections.Generic;
using System.Linq;

namespace DI
{
    public class Plugin3 : IPostOrderPlugin
    {
        void IPostOrderPlugin.DoSomething()
        {
            Console.WriteLine("Plug-in #3 executed.");
        }
    }
}
