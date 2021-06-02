using System;

namespace task1
{
   class Program
   {
      static void Main(string[] args)
      {
         int itogo;
         string methodName;
         int a;
         int b;
         Exception methodNameEx = new Exception("Вы ввели операцию которую не поддерживает данное ПО");
         Exception abEx = new Exception("Вы ввели некорректное число");

         Calculator calc = new Calculator();
         try
         {
            Console.WriteLine("Введиде первое целое число");
            a = Int32.Parse(Console.ReadLine());
         }
         catch
         {
            throw abEx;
         }

         try
         {
            Console.WriteLine("Введиде второе целое число");
            b = Int32.Parse(Console.ReadLine());
         }
         catch
         {
            throw abEx;
         }

         try
         {
            Console.WriteLine("Введиде название одной из доступных операций: Add, Sub, Mul, Div.");
            methodName = Console.ReadLine().ToLower();
            switch (methodName)
            {
               case "add":
                  itogo = calc.Add(a, b);
                  break;
               case "sub":
                  itogo = calc.Sub(a, b);
                  break;
               case "mul":
                  itogo = calc.Mul(a, b);
                  break;
               case "div":
                  itogo = calc.Div(a, b);
                  break;
               default:
                  throw methodNameEx;
            }
            Console.WriteLine(itogo);
         }
         finally
         {
            Console.WriteLine(' ');
         }
      }
   }
}
