using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Classes
{
   class Address
   {
      public string Index {get; set;}
      public string Country {get; set;}
      public string City { get; set; } 
      public string Street {get; set;}
      public string House { get; set; }
      public string Apartment { get; set; }
      public void GetInfo()
      {
         Console.WriteLine($"index: {Index}, country: {Country}, city: {City}, street: {Street}, house: {House}, apartment: {Apartment}");
      }
   }
}
