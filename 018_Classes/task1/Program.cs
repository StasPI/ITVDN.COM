using System;
using namespace1;

namespace task1
{
   class Program
   {
      static void Main(string[] args)
      {
         MyClass my = new MyClass();
         my.Print();

         namespace1.MyClass myTwo = new namespace1.MyClass();
         myTwo.Print();
      }
   }
}
