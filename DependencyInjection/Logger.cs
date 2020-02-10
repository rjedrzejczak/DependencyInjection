using System;

namespace DependencyInjection
{
    public class Logger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"'{message}'");
        }
    }
}