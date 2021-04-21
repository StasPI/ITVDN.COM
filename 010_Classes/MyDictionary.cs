using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Classes
{
   class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>
   {
      readonly TKey[] keys;
      readonly TValue[] values;
      readonly int count;

      public MyDictionary(int count)
      {
         keys = new TKey[count];
         values = new TValue[count];
         this.count = count;
      }

      public int GetCount
      {
         get
         {
            return count;
         }
      }

      public void Add(int num, TKey key, TValue value)
      {
         keys[num] = key;
         values[num] = value;
      }

      public Tuple<TKey, TValue> GetT(int index)
      {
         return Tuple.Create(keys[index], values[index]);
      }
   }
}
