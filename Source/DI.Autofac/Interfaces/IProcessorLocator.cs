using System;
using System.Collections.Generic;
using System.Linq;

namespace DI
{
    public interface IProcessorLocator
    {
        T GetProcessor<T>();
    }
}