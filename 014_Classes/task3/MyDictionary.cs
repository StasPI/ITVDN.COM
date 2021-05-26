using System;
using System.Collections;
using System.Collections.Generic;

namespace task3
{
   class MyDictionary<TKey, TValue>: IEnumerator, IEnumerable
   {
      private List<TKey> keys;
      private List<TValue> values;
      int position = -1;

      public MyDictionary()
      {
         keys = new List<TKey>();
         values = new List<TValue>();
      }

      public int Lenght
      {
         get
         {
            return keys.Count;
         }
      }

      public object Current
      {
         get { return Tuple.Create(keys[position], values[position]); }
      }

      public void Add(TKey key, TValue value)
      {
         keys.Add(key);
         values.Add(value);
      }


      public bool MoveNext()
      {
         if (position < keys.Count - 1)
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

      IEnumerator IEnumerable.GetEnumerator()
      {
         return this as IEnumerator;
      }

      //для доступа к елементу по индексу
      public object this[int index]
      {
         get 
         { 
            if(index >= 0 && index < keys.Count)
               return Tuple.Create(keys[index], values[index]);
            return "Попытка обращения за пределы массива.";
         }
      }
   }
}
