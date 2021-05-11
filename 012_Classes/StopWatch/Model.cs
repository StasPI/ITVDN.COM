using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
   class Model
   {
      private int second;

      public string Tick()
      {
         second++;
         return second >= 60 ? (second / 60) + " мин " + second % 60 + " сек" : second.ToString();
      }

      public void Reset()
      {
         second = 0;
      }
   }
}
