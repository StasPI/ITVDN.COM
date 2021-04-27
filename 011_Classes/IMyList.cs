using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Classes
{
   interface IMyList<T>
   {
      public void Add(T param);
      public T Get(int n);
      int Count { get; }
   }
}
