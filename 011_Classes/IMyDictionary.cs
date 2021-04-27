using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Classes
{
   interface IMyDictionary<TKey, TValue>
   {
      public void Add(TKey key, TValue value);
      public Tuple<TKey, TValue> Get(int key);
      int Lenght { get; }
   }
}
