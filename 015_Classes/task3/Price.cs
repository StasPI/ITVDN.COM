using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
   struct Price
   {
      string productName;
      string shopName;
      int productPrice;

      public object ProductName
      {
         get { return productName; }
      }
      public object ShopName
      {
         get { return shopName; }
      }
      public object ProductPrice
      { 
         get { return productPrice; }
      }

      public Price(string productName, string shopName, int productPrice)
      {
         this.productName = productName;
         this.shopName = shopName;
         this.productPrice = productPrice;
      }
   }
}
