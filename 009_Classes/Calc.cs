using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Classes
{
   class Calc
   {
      public void Start()
      {
         Console.WriteLine("Введите первое число");
         int x = Int32.Parse(Console.ReadLine());
         Console.WriteLine("Введите второе число");
         int y = Int32.Parse(Console.ReadLine());
         Console.WriteLine("Введите одну из доступных операций +, -, *, /");
         string oper = Console.ReadLine();

         switch (oper)
         {
            case "+":
               {

                  break;
               }
            case "-":
               {

                  break;
               }
            case "*":
               {

                  break;
               }
            case "/":
               {

                  break;
               }
            default:
               {
                  Console.WriteLine("Вы ввели недопустимое значение.");
                  break;
               }
         }
      }
   }
}
