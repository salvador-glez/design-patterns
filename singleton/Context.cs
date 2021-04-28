using System;

namespace Singleton
{
    public class Context
    {
        public Context()
        {
            Console.WriteLine("/****************************/");
            Console.WriteLine("Loading configuration files.");
            Console.WriteLine("Loading enviroment variables.");
            Console.WriteLine("Memory allocation.");
            Console.WriteLine("/****************************/");
        }
    }
}