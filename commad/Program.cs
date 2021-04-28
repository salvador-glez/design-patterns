using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterController controller = new PrinterController();
            controller.PrintXML(new Document());
            controller.PrintImg(new Document());
            controller.PrintPDF(new Document());
            controller.PrintWord(new Document());
            controller.PrintHtml(new Document());
        }
    }
}
