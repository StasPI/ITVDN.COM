using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
   class MyDate
   {
      private int day;
      private int month;
      private int year;

      public int Day 
      {
         get { return day; }
         set 
         {
            if ((1 <= value) & (value <= 31))
               day = value;
            else
               throw new Exception("Введеное число не корректно, день не может быть меньше 1 и больше 31");
         }
      }

      public int Month
      {
         get { return month; }
         set
         {
            if ((1 <= value) & (value <= 12))
               month = value;
            else
               throw new Exception("Введеное число не корректно, месяц не может быть меньше 1 и больше 12");
         }
      }

      public int Year
      {
         get { return year; }
         set
         {
            if (1 <= value)
               year = value;
            else
               throw new Exception("Введеное число не корректно, год не может быть меньше или равен 0");
         }
      }

      public MyDate(int day, int month, int year)
      {
         Day = day;
         Month = month;
         Year = year;
      }

      public static MyDate operator -(MyDate A, MyDate B)
      {
         int d;
         int m;
         int y;
         d = A.Day - B.Day;
         m = A.Month - B.Month;
         y = A.Year - B.Year;

         return new MyDate (1,1,1);
      }
   }
}
