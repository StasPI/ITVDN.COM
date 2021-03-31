using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Classes
{
   class DOCHandler : AbstractHandler
   {
      public override void Open()
      {
         Console.WriteLine("Open DOC");
      }
      public override void Create()
      {
         Console.WriteLine("Create DOC");
      }
      public override void Chenge()
      {
         Console.WriteLine("Chenge DOC");
      }
      public override void Save()
      {
         Console.WriteLine("Save DOC");
      }
   }
}
