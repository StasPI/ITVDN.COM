using System;

namespace task2
{
   class Program
   {
      static void Main(string[] args)
      {
         Block a = new Block(1, 2, 3, 4);
         Block b = new Block(1, 2, 4, 4);
         Block c = new Block(1, 2, 3, 4);

         Console.WriteLine("a == b : {0}", a.Equals(b));
         Console.WriteLine("a == c : {0}", a.Equals(c));

         Console.WriteLine(a.ToString());
         Console.WriteLine(b.ToString());
         Console.WriteLine(c.ToString());
      }
   }
}
