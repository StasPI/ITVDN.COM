using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Classes
{
   interface IMyDictionary<TKey, TValue>
   {
      public void Add(int num, TKey key, TValue value);
      public Tuple<TKey, TValue> GetT(int key);
      int GetCount { get; }
   }
}
