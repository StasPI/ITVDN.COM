using System;
using System.Linq;

namespace task2
{
   class Program
   {


      static void Main(string[] args)
      {
         Workers workers = new Workers(2);
         workers.AddWorkers();
         workers.FindWorkerYear(5);
      }
   }
}
