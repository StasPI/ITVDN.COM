using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Classes
{
   interface IMyList<T>
   {
      public void Add(T param);
      public T GetT(int n);
      int GetCount { get; }
   }
}
