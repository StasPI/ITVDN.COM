using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Classes
{
   public struct Notebook
   {
      string model;
      string manufactur;
      int price;

      public Notebook(string model, string manufacturer, int price)
      {
         this.model = model;
         this.manufactur = manufacturer;
         this.price = price;
      }

      public Notebook(string model): this(model, "", 0)
      {
      }

      //public Notebook(string manufacturer): this("", manufacturer, 0)
      //{
      //}

      public Notebook(int price): this("", "", price)
      {
      }

      public void Show()
      {
         Console.WriteLine($"model: {model}, manufacturer: {manufactur}, price: {price}.");
      }
   }
}