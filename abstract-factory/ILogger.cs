using System;
using System.IO;

namespace AbstractFactory
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
            
        }

        public void Log(string message) 
        {
            Console.WriteLine($"{message} - ConsoleLogger");
        }
    }

    public class CloudLogger : ILogger
    {
        public CloudLogger()
        {
            
        }

        public void Log(string message) 
        {
            Console.WriteLine($"{message} - CloudLogger");
        }
    }
}
