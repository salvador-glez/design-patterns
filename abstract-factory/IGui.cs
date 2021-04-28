using System;
using System.IO;

namespace AbstractFactory
{
    public interface IGui
    {
        void Show();
    }

    public class AndroidGui : IGui 
    {
        public void Show() 
        {
            Console.WriteLine($"showing android ui ");
        }
    }

    public class IosGui : IGui
    {
        public void Show() 
        {
            Console.WriteLine($"showing IOS ui");
        }
    }

    public class DesktopGui : IGui
    {
        public void Show() 
        {
            Console.WriteLine($"showing desktop ui");
        }
    }
}