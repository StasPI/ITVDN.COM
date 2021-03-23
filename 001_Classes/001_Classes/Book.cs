using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Classes
{
   class Book
   {
      public Title title = new Title();
      public Author author = new Author();
      public Content content = new Content();

      
      public void Add()
      {
         Console.WriteLine("Введите название книги:");
         title.title = Console.ReadLine();
         Console.WriteLine("Введите автора книги:");
         author.author = Console.ReadLine();
         Console.WriteLine("Введите содержимое:");
         content.content = Console.ReadLine();
      }
      public void Show()
      {
         title.Show();
         author.Show();
         content.Show();
      }
   }
}
