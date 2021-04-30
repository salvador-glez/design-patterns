using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterController controller = new PrinterController();
            controller.Print(new XmlDocument());
            controller.Print(new ImgDocument());
            controller.Print(new PdfDocument());
            controller.Print(new WordDocument());
            controller.Print(new HtmlDocument());
        }
    }
}
