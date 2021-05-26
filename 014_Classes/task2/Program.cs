using System;

namespace task2
{
   class Program
   {
      static void Main(string[] args)
      {
         MyList<int> ml = new MyList<int>();
         ml.Add(1);
         ml.Add(2);

         foreach(int m in ml)
         {
            Console.WriteLine(m);
         }
         foreach (int m in ml)
         {
            Console.WriteLine(m);
         }
         Console.WriteLine(ml[1]);
      }
   }
}
