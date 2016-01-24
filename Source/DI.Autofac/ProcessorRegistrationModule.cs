using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;

namespace DI
{
    public class ProcessorRegistrationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("Processor"))
                .As(t => t.GetInterfaces().FirstOrDefault(
                    i => i.Name == "I" + t.Name));
        }
    }
}
