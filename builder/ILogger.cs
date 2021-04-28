using System;
using System.IO;

namespace Builder
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger(TextWriter console)
        {
            
        }

        public void Log(string message) 
        {
            Console.WriteLine($"{message} - ConsoleLogger");
        }

        public void SetFormat(string format) {}
        public void SetColor(string code) {}
    }

    public class DataBaseLogger : ILogger
    {
        public DataBaseLogger(string connectionString)
        {
            
        }

        public void Log(string message) 
        {
            Console.WriteLine($"{message} - ConsoleDataBaseLogger");
        }

        public void SetLogTable(string tableName) {}
        public void SetMaxAge(int days) {}
    }
}
