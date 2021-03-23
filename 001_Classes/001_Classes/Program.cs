using System;

namespace _001_Classes
{
   class Program
   {
      static void Main(string[] args)
      {
         //// Дополнительное задание 
         //Address user_adress = new Address { };
         //user_adress.Index = "69";
         //user_adress.Country = "Rus";
         //user_adress.City = "SPb";
         //user_adress.Street = "pioter";
         //user_adress.House = "50";
         //user_adress.Apartment = "15";

         //user_adress.GetInfo();

         ////Задание 2 
         //double side1 = GetNumber("Пожалуйста, введите первое число:");
         //double side2 = GetNumber("Пожалуйста, введите второе число:");
         //Rectangle rectangle = new Rectangle(side1, side2);
         //Console.WriteLine($"площадь: {rectangle.AreaCalculator()}, периметр: {rectangle.PerimeterCalculator()}");

         ////Задание 3
         //Book bk = new Book();
         //bk.Add();
         //bk.Show();

         ////Задание 4
         //Figure figure = new Figure(new Point("A", 1, 1), new Point("B", 1, 4), new Point("C", 4, 4));

         //Console.Write("{0}, P = ", figure.name);

         //figure.PerimeterCalculator();

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
