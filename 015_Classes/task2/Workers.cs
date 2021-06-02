using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
   class Workers
   {
      private static string name;
      private static string post;
      private static int year;
      int count;
      Worker[] worker;

      public Workers(int count)
      {
         this.count = count;
         worker = new Worker[count];
      }

      public void AddWorkers()
      {
         for (int i = 0; i < count; i++)
         {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите должность");
            post = Console.ReadLine();
            Console.WriteLine("Введите год");
            try
            {
               year = Int32.Parse(Console.ReadLine());
            }
            catch
            {
               //throw new Exception("Вы ввели не корректную дату");
               Console.WriteLine("Вы ввели не корректную дату, мы установим дату по умолчанию");
               year = DateTime.Now.Year;
            }
            finally
            {
               worker[i] = new Worker(name, post, year);
            }
         }
         worker = worker.OrderBy(work => work.Name).ToArray<Worker>();
      }

      public void FindWorkerYear(int y)
      {
         foreach(var i in worker)
         {
            year = DateTime.Now.Year;

            if ((year - Convert.ToInt32(i.Year)) > y)
               Console.WriteLine($"Name: {i.Name}, Post: {i.Position}, Year: {i.Year}");
         }
      }
   }
}
