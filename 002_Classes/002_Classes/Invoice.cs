using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Classes
{
   class Invoice
   {
      readonly int account;
      readonly string customer;
      readonly string provider;
      public string Article { get; set; }
      public int Quantity { get; set; }

      public Invoice(int account, string customer, string provider)
      {
         this.account = account;
         this.customer = customer;
         this.provider = provider;
      }

      public void CostCalc(bool nds)
      {
         double cost;
         switch(Article)
         {
            case "pc":
               cost = 60;
               break;
            case "laptop":
               cost = 70;
               break;
            default:
               Console.WriteLine("мы таким не торгуем");
               return;
         }
         if (nds)
         {
            cost = cost - cost * 0.18;
         }
         Console.WriteLine($"Занеси в кассу: {cost * Quantity}");
      }
   }
}
