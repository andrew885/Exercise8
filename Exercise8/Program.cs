using System;
using ClassLibrary1;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p1 = new Printer();
            p1.Print("Дратути");

            GreenPrinter gp1 = new GreenPrinter();
            gp1.Print("Дратути");

            BluePrinter bp1 = new BluePrinter();
            bp1.Print("Дратути");

            Room office = new Room(p1);
            office.MakeThisLazyPrinterWork("Дарова");
            office.BringToRoom(gp1);
            office.MakeThisLazyPrinterWork("Дарова");
            office.BringToRoom(bp1);
            office.MakeThisLazyPrinterWork("Дарова");
        }
    }
}
