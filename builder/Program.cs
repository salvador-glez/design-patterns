﻿using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // ConsoleLogger consoleLogger = new ConsoleLogger(Console.Out);
            // consoleLogger.SetFormat("%DATE%  %PID% %MESSAGE%");
            // consoleLogger.SetColor("#000000");

            // DataBaseLogger dbLogger = new DataBaseLogger("password=****;uid=123;hostname=localhost");
            // dbLogger.SetLogTable("LOG");
            // dbLogger.SetMaxAge(60);


            var consoleBuilder = new ConsoleLoggerBuilder();
            var dbBuilder = new DataBaseLoggerBuilder();

            Director director = new Director();
            director.Builder = consoleBuilder;
            director.BuildLogger();

            var consoleLogger = consoleBuilder.GetLogger();
            director.Builder = dbBuilder;
            director.BuildLogger();

            var dbLogger = dbBuilder.GetLogger();



            //FileLogger fileLogger
            //...

            //EmailLogger emailLogger
            //...

            //WindowsEventLogger windowsEventLogger
            //...

            //ServiceRestLogger serviceRestLogger
            //...

            Process(dbLogger);
            Process(consoleLogger);
        }

        public static void Process(ILogger logger)
        {
            logger.Log("Client message.");
        }
    }
}
