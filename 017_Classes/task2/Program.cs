using System;
using System.Collections.Generic;
using System.Linq;

namespace task2
{
   class Program
   {
      static void Main(string[] args)
      {
         List<Station> station = new List<Station>()
         {
            new Station
            {
                Make = "BMW",
                Model = "x5",
                YearOfManufacture = DateTime.Parse("1/1/2021"),
                Color = "black"
            },
            new Station
            {
                Make = "Skoda",
                Model = "Rapid",
                YearOfManufacture = DateTime.Parse("2/2/2021"),
                Color = "brown"
            },
            new Station
            {
                Make = "Skoda",
                Model = "Octavia",
                YearOfManufacture = DateTime.Parse("3/2/2021"),
                Color = "green"
            }
         };

         List<Car> car = new List<Car>()
         {
            new Car
            {
                Model = "x5",
                Buyer = "Alex",
                PhoneNumber = "8 343 123 23 24"

            },
            new Car
            {
                Model = "Rapid",
                Buyer = "Oli",
                PhoneNumber = "8 343 123 23 23"
            },
            new Car
            {
                Model = "Octavia",
                Buyer = "Oli",
                PhoneNumber = "8 343 123 23 23"
            },
         };


         var query = from cr in car
                     join st in station on cr.Model equals st.Model
                     where cr.Buyer == "Oli"
                     select new { NameBuyer = cr.Buyer, PhoneNumber = cr.PhoneNumber, Make = st.Make, Model = st.Model, YearOfManufacture = st.YearOfManufacture, Color = st.Color };

         foreach (var q in query)
         {
            Console.WriteLine($"{q.NameBuyer}, { q.PhoneNumber}, {q.Make} , {q.Model}, {q.YearOfManufacture}, {q.Color}");
         }
      }
   }
}
