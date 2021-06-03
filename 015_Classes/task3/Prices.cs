using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
   class Prices
   {
      private static string productName;
      private static string shopName;
      private static int productPrice;
      int count;
      Price[] price;

      public Prices(int count)
      {
         this.count = count;
         price = new Price[count];
      }

      public void AddProduct()
      {
         for (int i = 0; i < count; i++)
         {
            Console.WriteLine("Введите название продукта");
            productName = Console.ReadLine();
            Console.WriteLine("Введите название магазина");
            shopName = Console.ReadLine();
            Console.WriteLine("Введите цену товара");
            try
            {
               productPrice = Int32.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
               Console.WriteLine("Вы ввели не корректную цену, мы установили цену по умолчанию равную 0");
               Console.WriteLine(e.Message);
               productPrice = 0;
            }
            finally
            {
               price[i] = new Price(productName, shopName, productPrice);
            }
         }
         price = price.OrderBy(price => price.ShopName).ToArray<Price>();
      }

      public void ShopInfo()
      {
         Console.WriteLine("Введите название магазина продукты которого хотите увидеть");
         shopName = Console.ReadLine();
         count = 0;
         try
         {
            foreach (var product in price)
            {
               if (shopName.ToUpper() == Convert.ToString(product.ShopName).ToUpper())
               {
                  count++;
                  Console.WriteLine($"ProductName: {product.ProductName}, ShopName: {product.ShopName}, ProductPrice: {product.ProductPrice}");
               }
            }
            if (count == 0)
            {
               throw new Exception("Такой магазин отсутствует в списке");
            }
         }
         catch(Exception e)
         {
            Console.WriteLine(e);
         }
         finally
         {
            count = 0;
         }
      }
   }
}
