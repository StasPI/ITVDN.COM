using System;
using System.Collections.Generic;

namespace task4
{
   class Program
   {
      static void Main(string[] args)
      {
         MyList<int> ml = new MyList<int>();
         ml.Add(1);
         ml.Add(2);


         int[] arr = ml.GetArray();

         foreach (int ar in arr)
         {
            Console.WriteLine(ar);
         }

         Console.WriteLine(arr[1]);
      }
   }
}
