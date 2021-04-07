using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Classes
{
   static class ExtensionClass
   {
      public static void SortMethod(this int[] array)
      {
         Array.Sort(array);
      }
   }
}