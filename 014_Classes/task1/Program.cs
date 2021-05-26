using System;
using System.Collections;
using System.Collections.Generic;

namespace task1
{
   class Program
   {
      static IEnumerable GetСollection(int[] arr)
      {
         foreach(int ar in arr)
         {
            if (ar % 2 == 0)
            {
               yield return ar;
            }
         }
      }

      static void Main(string[] args)
      {
         int[] mas = {1,2,3,4,5,6,7,8};
         IEnumerable col = GetСollection(mas);
         foreach (var c in col)
         {
            Console.WriteLine(c);
         }
      }
   }
}
