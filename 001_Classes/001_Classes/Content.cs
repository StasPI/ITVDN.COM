using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Classes
{
   class Content
   {
      public string content;

      public void Show()
      {
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.WriteLine(content);
      }
   }
}
