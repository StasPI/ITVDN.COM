using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Classes
{
   class XMLHandler : AbstractHandler
   {
      public override void Open()
      {
         Console.WriteLine("Open XML");
      }
      public override void Create() 
      {
         Console.WriteLine("Create XML");
      }
      public override void Chenge() 
      {
         Console.WriteLine("Chenge XML");
      }
      public override void Save()
      {
         Console.WriteLine("Save XML");
      }
   }
}
