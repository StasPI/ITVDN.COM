using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Classes
{
   class Ship : Vehicle
   {
      public int passengers;
      public string homePort;

      public Ship(int _x, int _y, int _price, int _speed, int _yearOfManufacture, int _passengers, string _homePort) : base()
      {
         x = _x;
         y = _y;
         price = _price;
         speed = _speed;
         yearOfManufacture = _yearOfManufacture;
         passengers = _passengers;
         homePort = _homePort;
      }

      public void Show()
      {
         Console.WriteLine("Ship");
         Console.WriteLine($"x: {x}, y: {y}, price: {price}, speed: {speed}, yearOfManufacture: {yearOfManufacture}, passengers: {passengers}, homePort: {homePort}");
      }
   }
}
