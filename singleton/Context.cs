using System;

namespace Singleton
{
    public class Context
    {
        private static Context instance = null;

        public static Context Instance
        {
            get
            {
                if (instance == null)
                    instance = new Context();

                return instance;
            }
        }
        private Context()
        {
            Console.WriteLine("/****************************/");
            Console.WriteLine("Loading configuration files.");
            Console.WriteLine("Loading enviroment variables.");
            Console.WriteLine("Memory allocation.");
            Console.WriteLine("/****************************/");
        }
    }
}