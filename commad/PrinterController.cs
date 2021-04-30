using System;

namespace Command
{
    public interface ICommand
    {
        public void Execute();
    }

    public class PrinterController
    {
        public void Print(ICommand doc)
        {
            doc.Execute();
        }
    }

    public class XmlDocument : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Printing XML");
        }
    }
    public class ImgDocument : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Printing Img");
        }
    }
    public class PdfDocument : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Printing PDF");
        }
    }
    public class WordDocument : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Printing Word");
        }
    }
    public class HtmlDocument : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Printing Html");
        }
    }
}