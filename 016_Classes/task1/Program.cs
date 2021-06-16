using System;

namespace task1
{
   class Program
   {
      static void Main(string[] args)
      {
         DotInXYZ a = new DotInXYZ();
         DotInXYZ b = new DotInXYZ();

         a.X = 1;
         a.Y = 2;
         a.Z = 3;

         b.X = 3;
         b.Y = 2;
         b.Z = 1;

         DotInXYZ c = a + b;
         Console.WriteLine($"X: {c.X}, Y: {c.Y}, Z: {c.Z}");
      }
   }
}
