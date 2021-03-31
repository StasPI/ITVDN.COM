using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Classes
{
   class TXTHandler : AbstractHandler
   {
      public override void Open()
      {
         Console.WriteLine("Open TXT");
      }
      public override void Create()
      {
         Console.WriteLine("Create TXT");
      }
      public override void Chenge()
      {
         Console.WriteLine("Chenge TXT");
      }
      public override void Save()
      {
         Console.WriteLine("Save TXT");
      }
   }
}
