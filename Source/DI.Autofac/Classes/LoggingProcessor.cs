using System;
using System.Collections.Generic;
using System.Linq;

namespace DI
{
    public class LoggingProcessor : ILoggingProcessor
    {
        void ILoggingProcessor.Log(string message)
        {
            // log message to log file
            Console.WriteLine(string.Format("Log entry @ {0}: {1}", DateTime.Now, message));
            Console.WriteLine();
        }
    }
}