using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Classes
{
   class Plane : Vehicle
   {
      public int height;
      public int passengers;

      public Plane(int _x, int _y, int _price, int _speed, int _yearOfManufacture, int _height, int _passengers) :base()
      {
         x = _x;
         y = _y;
         price = _price;
         speed = _speed;
         yearOfManufacture = _yearOfManufacture;
         height = _height;
         passengers = _passengers;
      }

      public void Show()
      {
         Console.WriteLine("Plane");
         Console.WriteLine($"x: {x}, y: {y}, price: {price}, speed: {speed}, yearOfManufacture: {yearOfManufacture}, height: {height}, passengers: {passengers}");
      }
   }
}
