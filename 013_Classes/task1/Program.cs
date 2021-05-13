using System;
using System.Threading;

namespace task1
{
   class Program
   {
      static void Rec()
      {
         Console.WriteLine(new string(' ', 10) + $"start {Thread.CurrentThread.GetHashCode()}");
         Thread thread = new Thread(Rec);
         thread.Start();
      }



      static void Main(string[] args)
      {
         Rec();
      }
   }
}
