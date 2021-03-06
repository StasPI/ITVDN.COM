using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
   class MyList<T> : IEnumerable<T>
   {
      int position = -1;
      private T[] array;

      public MyList()
      {
         array = new T[0];
      }

      public int Count
      {
         get { return array.Length; }
      }

      public object Current
      {
         get { return array[position]; }
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

      //следующий элемент
      //public bool MoveNext()
      //{
      //   if (position < array.Length - 1)
      //   {
      //      position++;
      //      return true;
      //   }
      //   else
      //   {
      //      Reset();
      //      return false;
      //   }
      //}

      public void Reset()
      {
         position = -1;
      }

      public IEnumerator<T> GetEnumerator()
      {
         while (true)
         {
            if (position < array.Length - 1)
            {
               position++;
               yield return array[position];
            }
            else
            {
               Reset();
               yield break;
            }
         }
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return GetEnumerator();
      }
   }
}
