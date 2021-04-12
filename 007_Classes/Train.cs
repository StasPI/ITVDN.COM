using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Classes
{
   public struct Train
   {
      string destinationName;
      int trainNumber;
      DateTime departureTime;

      public Train (string destinationName, int trainNumber, DateTime departureTime)
      {
         this.destinationName = destinationName;
         this.trainNumber = trainNumber;
         this.departureTime = departureTime;
      }
   }
}
