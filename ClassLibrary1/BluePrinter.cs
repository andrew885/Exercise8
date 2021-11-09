using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BluePrinter:Printer
    {
        public override void Print(string prt)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(prt);
            Console.ResetColor();
        }
    }
}
