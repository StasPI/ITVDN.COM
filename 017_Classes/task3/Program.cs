using System;
using System.Collections.Generic;

namespace task3
{
   class Program
   {
      static void Main(string[] args)
      {
         var dictionary = new Dictionary<dynamic, dynamic>();
         dictionary.Add("One", "Один");
         dictionary.Add("Two", "два");
         dictionary.Add("Three", "три");


         foreach (var item in dictionary)
         {
            Console.WriteLine($"{item.Key}-{item.Value}");
         }

         var a = dictionary["Two"];
         Console.WriteLine(a);
         
         // Delay.
         Console.ReadKey();
      }
   }
}
