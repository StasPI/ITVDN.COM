using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Classes
{
   class Figure
   {
      Point[] points;
      private int perimeter;
      public string name;

      public Figure(Point zero, Point one, Point two)
      {
         points = new Point[3];
         points[0] = zero;
         points[1] = one;
         points[2] = two;
         name = "треугольник";
      }
      public Figure(Point zero, Point one, Point two, Point three)
      {
         points = new Point[4];
         points[0] = zero;
         points[1] = one;
         points[2] = two;
         points[3] = three;
         name = "четырехугольник";
      }
      public Figure(Point zero, Point one, Point two, Point three, Point four)
      {
         points = new Point[5];
         points[0] = zero;
         points[1] = one;
         points[2] = two;
         points[3] = three;
         points[4] = four;
         name = "пятиугольник";
      }

      double LengthSide(Point A, Point B)
      {
         return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
      }

      public void PerimeterCalculator()
      {
         double sum = 0;

         for (int i = 0; i < points.Length - 1; i++)
         {
            sum += LengthSide(points[i], points[i + 1]);
         }

         sum += LengthSide(points[points.Length - 1], points[0]);
         Console.Write(sum);
      }
   }
}
