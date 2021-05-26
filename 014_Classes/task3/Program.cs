using System;
using System.Collections.Generic;

namespace task3
{
   class Program
   {
      static void Main(string[] args)
      {
         MyDictionary<int, string> md = new MyDictionary<int, string>();
         md.Add(1, "one");
         md.Add(2, "two");
         md.Add(3, "three");

         foreach(var keyValue in md)
         {
            Console.WriteLine(keyValue);
         }

         Console.WriteLine(md.Lenght);
         Console.WriteLine(md[1]);
      }
   }
}
