using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac.Core.Activators.Reflection;

namespace DI
{
    public class AwesomeConstructorFinder : IConstructorFinder
    {
        ConstructorInfo[] IConstructorFinder.FindConstructors(Type targetType)
        {
            ConstructorInfo constructorToResolve = null;

            ConstructorInfo[] constructors = targetType.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                object[] attributes = constructor.GetCustomAttributes(typeof(AwesomeConstructorAttribute), false);
                if (attributes != null && attributes.Count() > 0)
                {
                    constructorToResolve = constructor;
                    break;
                }
            }

            return new ConstructorInfo[] { constructorToResolve };
        }
    }
}
