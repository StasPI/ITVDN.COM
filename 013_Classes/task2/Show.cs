using System;
using System.Threading;

namespace task2
{
   class Show
   {
      static readonly object locker = new object();
      const string Symbol = "qwertyuiopasdfghjklzxcvbnm1234567890";
      static Random rnd = new Random();
      int cursorPosition;
      int consoleHeight;

      public Show(int cursorPosition, int consoleHeight)
      {
         this.cursorPosition = cursorPosition;
         this.consoleHeight = consoleHeight - 1;
      }

      public char SymbolChain()
      {
         return Symbol[rnd.Next(0, Symbol.Length - 1)];
      }

      public void Move()
      {
         int longChain = rnd.Next(4, 7);
         int countStep = 0;

         while(true)
         {
            countStep += 1;
            if (countStep > consoleHeight - longChain)
            {
               longChain -= 1;
            }

            if (longChain == 0)
            {
               Console.SetCursorPosition(cursorPosition, consoleHeight - 1);
               Console.WriteLine(' ');
               Console.SetCursorPosition(cursorPosition, consoleHeight);
               Console.WriteLine(' ');
               longChain = rnd.Next(4, 7);
               countStep = 0;
            }

            Thread.Sleep(rnd.Next(10, 1000));
            lock (locker)
            {
               for (int i = 0; i < longChain; i++)
               {
                  Console.SetCursorPosition(cursorPosition, countStep);
                  Console.WriteLine(' ');
                  Console.SetCursorPosition(cursorPosition, countStep + i);
                  switch (i)
                  {
                     case 1:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(SymbolChain());
                        break;
                     case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(SymbolChain());
                        break;
                     default:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(SymbolChain());
                        break;
                  }
               }
            }
         }
      }
   }
}
