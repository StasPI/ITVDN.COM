using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Classes
{
   class CarCollection<T>
   {
      private MyList<string>  carName;
      private MyList<int> carYear;

      public int Count
      {
         get
         {
            return carName.Count;
         }
      }

      public CarCollection()
      {
         carName = new MyList<string>();
         carYear = new MyList<int>();
      }

      public void Add(string name, int year)
      {
         carName.Add(name);
         carYear.Add(year);
      }

      public void Clean()
      {
         carName = new MyList<string>();
         carYear = new MyList<int>();
      }

      public string this[int index]
      {
         get { return carName[index] + " " + carYear[index]; }
      }
   }


}
