using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class GreenPrinter:Printer
    {
        public override void Print(string prt)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(prt);
            Console.ResetColor();
        }
    }
}
