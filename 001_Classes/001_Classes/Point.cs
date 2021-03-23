using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Classes
{
   class Point
   {
      public int X { get; }
      public int Y { get; }
      public string name { get; }

      public Point(string name, int x, int y)
      {
         this.name = name;
         X = x;
         Y = y;
      }
   }
}
