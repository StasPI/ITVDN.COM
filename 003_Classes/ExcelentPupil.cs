using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Classes
{
   class ExcelentPupil : Pupil
   {
      public override void Study()
      {
         Console.WriteLine("Im realy Study");
      }
      public override void Read()
      {
         Console.WriteLine("Im realy Read");
      }
      public override void Write()
      {
         Console.WriteLine("Im realy Write");
      }
      public override void Relax()
      {
         Console.WriteLine("Im not Relax");
      }
   }
}
