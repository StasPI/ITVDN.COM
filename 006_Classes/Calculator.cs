using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Classes
{
   static class Calculator
   {
      public static void Plus(int x, int y)
      {
         Console.WriteLine( x + y );
      }

      public static void Minus(int x, int y)
      {
         Console.WriteLine(x - y);
      }

      public static void Times(int x, int y)
      {
         Console.WriteLine(x * y);
      }

      public static void Divided(int x, int y)
      {
         Console.WriteLine(x / y);
      }
   }
}
