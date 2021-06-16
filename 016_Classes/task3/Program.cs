using System;

namespace task3
{
   class Program : House
   {
      static void Main(string[] args)
      {
         Program originalClone = new Program { A = 0, B = 0, Work = new Company { Name = "Micro"} };
         House clonelClone = originalClone.Clone();
         originalClone.A = 3;
         clonelClone.B = 3;
         clonelClone.Work.Name = "Gog";

         Console.WriteLine($"originalClone A = {originalClone.A}, B = {originalClone.B}  + {originalClone.Work.Name}");
         Console.WriteLine($"clonelClone A = {clonelClone.A}, B = {clonelClone.B} + {clonelClone.Work.Name}");


         Program originalDeepClone = new Program { A = 0, B = 0, Work = new Company { Name = "Micro" } };
         House clonelDeepClone = originalDeepClone.DeepClone();
         originalDeepClone.A = 3;
         clonelDeepClone.B = 3;
         clonelDeepClone.Work.Name = "Gog";

         Console.WriteLine($"originalDeepClone A = {originalDeepClone.A}, B = {originalDeepClone.B}  + {originalDeepClone.Work.Name}");
         Console.WriteLine($"clonelDeepClone A = {clonelDeepClone.A}, B = {clonelDeepClone.B} + {clonelDeepClone.Work.Name}");
      }
   }
}
