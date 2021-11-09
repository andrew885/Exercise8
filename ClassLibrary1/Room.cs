using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Room
    {
        public Room(Printer printer)
        {
            p1 = printer;
        }

        Printer p1 = new Printer();
        public void MakeThisLazyPrinterWork(string value)
        {
            p1.Print(value);
        }

        public void BringToRoom(Printer secondPrinter)
        {
            p1 = secondPrinter;
        }
    }
}
