using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Classes
{
   class FindAndReplaceManager
   {
      public void FindNext(string str)
      {
         Console.WriteLine(str);
         Book b = new Book();
         b.FindNext(str);
      }
   }

   public class Book
   {
      public void FindNext(string str)
      {
         Console.WriteLine("мне поручили эту грязную работу");
      }

      public class Notes
      {
         List<string> n = new List<string>();
   
         public void AddNotes(string text)
         {
            n.Add(text);
         }

         public void ShowNotes()
         {
            foreach(string nn in n)
            {
               Console.WriteLine(nn);
            }
         }
      }
   }
}
