using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Classes
{
   static class MyListExtension
   {
      public static T[] GetArray<T>(this MyList<T> list)
      {

         var tArray = new T[list.GetCount];
         for (int i = 0; i < tArray.Length; i++)
         {
            tArray[i] = list[i];
         }
         return tArray;

      }

   }
}
