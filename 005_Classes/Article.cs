using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Classes
{
   class Article
   {
      string _name;
      string _shop;
      int _cost;

      public string Name { get { return _name; } set { _name = value; } }
      public string Shop { get { return _shop; } set { _shop = value; } }
      public int Cost { get { return _cost; } set { _cost = value; } }

      public Article(string _name, string _shop, int _cost)
      {
         Name = _name;
         Shop = _shop;
         Cost = Math.Abs(_cost);
      }
   }
}
