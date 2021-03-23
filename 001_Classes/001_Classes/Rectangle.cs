using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Classes
{
   class Rectangle
   {
      private double side1;
      private double side2;

      public Rectangle(double side1, double side2)
      {
         this.side1 = side1;
         this.side2 = side2;
      }

      public double AreaCalculator()
      {
            return side1 * side2;
      }

      public double PerimeterCalculator()
      {
         return (side1 + side2) * 2;
      }

      public double Perimeter
      {
         get
         {
            return this.PerimeterCalculator();
         }
      }

      public double Area
      {
         get
         {
            return this.AreaCalculator();
         }
      }
   }
}