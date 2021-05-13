using System;
using System.Threading;

namespace task2
{
   class Program
   {
      static void Starter()
      {
         Console.SetWindowSize(80, 40);
         Show sh;
         Random rnd = new Random();

         for (int i = 0; i < 79; i++)
         {
            if (rnd.Next(1, 10) == 1)
            {
               sh = new Show(i, 39);
               new Thread(sh.Move).Start();
            }
         }

         Console.ReadKey();

      }

      static void Main(string[] args)
      {
         for (int i = 0; i < 5; i++)
         {
            new Thread(Starter).Start();
            Thread.Sleep(10000);
         }
      }
   }
}
