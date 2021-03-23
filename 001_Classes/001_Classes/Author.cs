using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Classes
{
   class Author
   {
      public string author;

      public void Show()
      {
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine(author);
      }
   }
}
