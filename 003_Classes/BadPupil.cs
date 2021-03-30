using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Classes
{
   class BadPupil : Pupil
   {
      public override void Study()
      {
         Console.WriteLine("Im Relax");
      }
      public override void Read()
      {
         Console.WriteLine("Im Relax");
      }
      public override void Write()
      {
         Console.WriteLine("Im Relax");
      }
      public override void Relax()
      {
         Console.WriteLine("Im Relax");
      }
   }
}
