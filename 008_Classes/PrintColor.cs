using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Classes
{
   public static class PrintColor
   {

      public static void Print(string stroka, int color)
      {
         switch (color)
         {
            case (int)ColorEnum.Green:
               Console.ForegroundColor = ConsoleColor.Green;
               break;
            case (int)ColorEnum.Red:
               Console.ForegroundColor = ConsoleColor.Red;
               break;
            case (int)ColorEnum.Black:
               Console.ForegroundColor = ConsoleColor.Black;
               break;
            default:
               Console.ForegroundColor = ConsoleColor.White;
               break;
         }
         Console.WriteLine(stroka);
         Console.ResetColor();
      }
   }
}
