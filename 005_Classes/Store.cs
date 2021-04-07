using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Classes
{
   class Store
   {
      Article[] art;

      public Store(int _size)
      {
         art = new Article[Math.Abs(_size)];
      }

      internal void AddArticle(Article _value, int _index)
      {
         if (_index <= art.Length)
            art[_index] = _value;
         else
            Console.WriteLine("Индекс выше допустимого");
      }

      internal void FindIndex(int _index)
      {
         Article info = art[_index];
         Console.WriteLine($"Артикул: {_index}, Название: {info.Name}, Магазин : {info.Shop}, Цена : {info.Cost}.");
      }

      internal void FindName(string _name)
      {
         for (int i = 0; i < art.Length; i++)
         {
            if (art[i] != null)
               if (art[i].Name.ToLower() == _name.ToLower())
                  FindIndex(i);
         }
      }
   }
}