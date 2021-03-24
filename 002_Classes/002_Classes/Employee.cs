using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Classes
{
   class Employee
   {
      const int director = 50000;
      const int janitor = 20000;
      private double summ;
      private double nalog;
      public string firstName { get; set; }
      private string lastName { get; set; }
      public Employee(string firstName, string lastName)
      {
         this.firstName = firstName;
         this.lastName = lastName;
      }

      public void Show()
      {
         Console.WriteLine($"{firstName}, {lastName}, {summ}, {nalog}");
      }

      public void Calc()
      {
         summ = CalcGrossSalary();
         nalog = CalcNalog(summ);
      }

      private double CalcNalog(double summ)
      {
         return summ * 0.13;
      }

      private double CalcGrossSalary()
      {
         Console.WriteLine("Должность из доступных вариантов director или janitor (учти что вероятнее всего второе): ");
         string position = Console.ReadLine();
         Console.WriteLine("Стаж работы: ");
         int experience = int.Parse(Console.ReadLine());
         switch (position)
         {
            case "director":
               return director + (director / 100 * experience);
            case "janitor":
               return director + (director / 100 * experience);
            default:
               return 0;
         }
      }
   }
}