using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Classes
{
   class ClassRoom
   {
      public ClassRoom(Dictionary<string, Pupil> student)
      {
         foreach (KeyValuePair<string, Pupil> keyValue in student)
         {
            Console.WriteLine(keyValue.Key);
            keyValue.Value.Study();
            keyValue.Value.Read();
            keyValue.Value.Write();
            keyValue.Value.Relax();
         }
      }
   }
}
