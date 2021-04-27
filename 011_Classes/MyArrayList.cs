using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Classes
{
   class MyArrayList
   {
      object[] array;

      public MyArrayList()
      {
         array = new object[0];
      }

      public void Add(object obj)
      {
         Object[] tArray = new Object[array.Length + 1];
         for (int i = 0; i < array.Length; i++)
         {
            tArray[i] = array[i];
         }
         tArray[tArray.Length - 1] = obj;
         array = tArray;
      }

      public Object this[int index]
      {
         get { return array[index]; }
      }

      public int Length
      {
         get
         {
            return array.Length;
         }
      }
   }
}
