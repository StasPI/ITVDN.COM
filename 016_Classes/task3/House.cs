using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
   class House
   {
      public Company Work { get; set; }
      int a;
      int b;

      public int A { get; set; }
      public int B { get; set; }

      public House Clone()
      {
         return this.MemberwiseClone() as House;
      }

      public House DeepClone()
      {
         Company company = new Company { Name = this.Work.Name };
         return new House
         {
            a = this.A,
            b = this.B,
            Work = company
         };
      }
   }

   class Company
   {
      public string Name { get; set; }
   }
}
