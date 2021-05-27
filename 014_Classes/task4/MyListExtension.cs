using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
   public static class MyListExtension
   {
      public static T[] GetArray<T>(this IEnumerable<T> list)
      {
         T[] array = new T[list.Count()];
         int i = 0;
         foreach (var value in list)
         {
            array[i] = value;
            i++;
         }
         return array;
      }
   }
}
