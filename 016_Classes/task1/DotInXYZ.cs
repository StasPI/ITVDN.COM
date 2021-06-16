using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
   struct DotInXYZ
   {
      int x;
      int y;
      int z;

      public int X 
      { 
         get { return x; }
         set { x = value; }
      }
      public int Y
      {
         get { return y; }
         set { y = value; }
      }
      public int Z
      {
         get { return z; }
         set { z = value; }
      }

      public static DotInXYZ operator +(DotInXYZ A, DotInXYZ B)
      {
         return new DotInXYZ { X = A.X + B.X, Y = A.Y + B.Y, Z = A.Z + B.Z };
      }
   }
}
