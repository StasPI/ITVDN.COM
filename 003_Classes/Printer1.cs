using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Classes
{
   class Printer1 : Printer
   {
      public void Print(string value)
      {
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine(value);
      }
   }
}
