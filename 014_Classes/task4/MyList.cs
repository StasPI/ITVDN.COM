using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
   class MyList<T> : IEnumerator, IEnumerable
   {
      int position = -1;
      private T[] array;
      public int Count
      {
         get
         {
            return array.Length;
         }
      }

      public object Current
      {
         get { return array[position]; }
      }

      public MyList()
      {
         array = new T[0];
      }

      public void Add(T param)
      {
         T[] tArray = new T[array.Length + 1];
         for (int i = 0; i < array.Length; i++)
         {
            tArray[i] = array[i];
         }
         tArray[tArray.Length - 1] = param;
         array = tArray;
      }

      public T Get(int n)
      {
         return array[n];
      }

      //для доступа к елементу по индексу
      public T this[int index]
      {
         get { return array[index]; }
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return this as IEnumerator;
      }

      //следующий элемент
      public bool MoveNext()
      {
         if (position < array.Length - 1)
         {
            position++;
            return true;
         }
         else
         {
            Reset();
            return false;
         }
      }

      public void Reset()
      {
         position = -1;
      }
   }
}
