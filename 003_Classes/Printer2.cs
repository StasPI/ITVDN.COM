using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Classes
{
   class Printer2 : Printer
   {
      public void Print(string value)
      {
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine(value);
      }
   }
}
