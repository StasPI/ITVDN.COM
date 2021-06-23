using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
   class MyDate
   {
      readonly DateTime date;
      private int days;
      string type;

      public MyDate(DateTime date)
      {
         this.date = date;
      }

      public MyDate(int days)
      {
         this.days = days;
         this.type = "days";
      }

      public static MyDate operator -(MyDate date1, MyDate date2)
      {
         TimeSpan timeSpan = date1.date - date2.date;
         DateTime newDate = date1.date.AddDays(timeSpan.Days);
         return new MyDate(Math.Abs(timeSpan.Days));
      }

      public static MyDate operator +(MyDate date1, MyDate date2)
      {
         DateTime newDate = date1.date.AddDays(Convert.ToDouble(date2.ToInt()));
         return new MyDate(newDate);
      }

      public static MyDate Add(MyDate d1, MyDate d2)
      {
         return d1 + d2;
      }

      public override string ToString()
      {
         if (this.type == "days")
            return "Даней: " + days;
         else
            return "Дата: " + date;
      }

      public int ToInt()
      {
         if (this.type == "days")
            return days;
         else
         {
            TimeSpan timeSpan = this.date - new DateTime(0001,01,01);
            return Math.Abs(timeSpan.Days);
         }

      }

   }
}
