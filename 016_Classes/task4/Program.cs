using System;

namespace task4
{
   class Program
   {
      static void Main(string[] args)
      {
         MyDate one = new MyDate(DateTime.Now);
         MyDate two = new MyDate(new DateTime(1989, 10, 18));
         MyDate three = new MyDate(2);

         Console.WriteLine($"Первая {one }");
         Console.WriteLine($"Вторая {two }");
         Console.WriteLine($"Между ними {one - two}");
         Console.WriteLine(MyDate.Add(two, three).ToString());
      }
   }
}
