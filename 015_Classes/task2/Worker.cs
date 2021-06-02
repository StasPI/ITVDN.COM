using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
   struct Worker
   {
      string name;
      string position;
      int year;

      public object Name 
      { 
         get { return name; }
      }
      public object Position 
      {
         get { return position; }
      }
      public object Year
      {
         get { return year; }
      }

      public Worker(string name, string position, int year)
      {
         this.name = name;
         this.position = position;
         this.year = year;
      }  
   }
}
