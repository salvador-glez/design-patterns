﻿using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {            
            ILogger logger = null;
            IGui ui = null;

            // if (args[0] == "desktop")
            // {
            //      logger = new ConsoleLogger();
            //      ui = new DesktopGui();
            //      //..
            //      //..
            //      //..
            // }
            // else if (args[0] == "android")
            // {
            //     logger = new CloudLogger();
            //     ui = new AndroidGui();
            //     //..
            //     //..
            //     //..                
            // }

            var factory = EnviromentFactory.GetFactory(args[0]);
            Process(factory.GetLogger(), factory.GetGui());
        }

        public static void Process(ILogger logger, IGui ui)
        {
            logger.Log("Client message.");
            ui.Show();
        }
    }
}
