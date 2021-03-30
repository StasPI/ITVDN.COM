using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Classes
{
   class Pupil
   {
      public virtual void Study()
      {
         Console.WriteLine("Im Study");
      }
      public virtual void Read()
      {
         Console.WriteLine("Im Read");
      }
      public virtual void Write()
      {
         Console.WriteLine("Im Write");
      }
      public virtual void Relax()
      {
         Console.WriteLine("Im Relax");
      }
   }
}
