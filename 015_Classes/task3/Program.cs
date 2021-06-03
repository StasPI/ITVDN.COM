using System;

namespace task3
{
   class Program
   {
      static void Main(string[] args)
      {
         Prices prices = new Prices(2);
         prices.AddProduct();
         prices.ShopInfo();
      }
   }
}
