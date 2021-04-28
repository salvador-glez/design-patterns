using System;

namespace Command
{
    public class PrinterController
    {
        public void PrintXML(Document doc)
        {
            Console.WriteLine("Printing XML");
        }

        public void PrintImg(Document doc)
        {
            Console.WriteLine("Printing Img");
        }

        public void PrintPDF(Document doc)
        {
            Console.WriteLine("Printing PDF");
        }

        public void PrintWord(Document doc)
        {
            Console.WriteLine("Printing Word");
        }

        public void PrintHtml(Document doc)
        {
            Console.WriteLine("Printing Html");
        }
    }

    public class Document
    {

    }
}