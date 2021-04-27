using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Classes
{
   class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>
   {
      List<TKey> keys;
      List<TValue> values;

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

      public void Add(TKey key, TValue value)
      {
         keys.Add(key);
         values.Add(value);
      }

      public Tuple<TKey, TValue> Get(int index)
      {
         return Tuple.Create(keys[index], values[index]);
      }
   }
}
