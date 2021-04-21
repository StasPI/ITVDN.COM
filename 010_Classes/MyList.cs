using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Classes
{
   class MyList<T>:IMyList<T>
   {
      private T[] array;
      public int GetCount
      { 
         get 
         {
            return array.Length;
         } 
      }

      public MyList()
      {
         array = new T[0];
      }

      public void Add(T param)
      {
         T[] tArray = new T[array.Length + 1];
         for (int i=0; i < array.Length; i++)
         {
            tArray[i] = array[i];
         }
         tArray[tArray.Length - 1] = param;
         array = tArray;
      }

      public T GetT(int n)
      {
         return array[n];
      }

      public T this[int index]
      {
         get { return array[index]; }
      }
   }
}
