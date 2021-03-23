using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Classes
{
   class Title
   {
      public string title;

      public void Show()
      {
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine(title);
      }
   }
}
