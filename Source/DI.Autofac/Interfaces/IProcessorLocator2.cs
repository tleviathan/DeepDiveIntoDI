using System;
using System.Collections.Generic;
using System.Linq;

namespace DI
{
    public interface IProcessorLocator2
    {
        void CreateScope();
        T GetProcessor<T>();
        void ReleaseScope();
    }
}
