using System;

namespace DependencyInversionPrinciple
{
    public class ConsoleLogger : ILogger
    {
        public void Error(Log log)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(log.Body);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}