using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Classes
{
   class Converter
   {
      public double usd { get; set; }
      public double eur { get; set; }
      public double rub { get; set; }
      private string user_value;
      public double user_summ;
      public Converter(double usd, double eur, double rub)
      {
         this.usd = usd;
         this.eur = eur;
         this.rub = rub;
      }

      public void ConverToGrn()
      {
         user_summ = GetNumber("Сколько гривен у вас есть? ");
         Console.WriteLine("В какую валюту попробуем сконвертировать ваши гроши: usd, eur, rub.");
         user_value = Console.ReadLine();
         switch (user_value)
         {
            case "usd":
               Console.WriteLine(user_summ / usd);
               break;
            case "eur":
               Console.WriteLine(user_summ / eur);
               break;
            case "rub":
               Console.WriteLine(user_summ / rub);
               break;
         }
      }

      private static double GetNumber(string text)
      {
         Console.WriteLine(text);
         while (true)
         {
            string strInput = Console.ReadLine();
            double result;
            if (double.TryParse(strInput, out result))
               return result;
            else
               Console.WriteLine("Неправильный формат числа. Попробуйте еще раз");
         }
      }
   }
}
