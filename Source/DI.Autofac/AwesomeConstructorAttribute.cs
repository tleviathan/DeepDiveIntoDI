using System;
using System.Collections.Generic;
using System.Linq;

namespace DI
{
    [AttributeUsage(AttributeTargets.Constructor)]
    public class AwesomeConstructorAttribute : Attribute
    {
    }
}
