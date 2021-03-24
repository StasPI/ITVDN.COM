using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Classes
{
   class User
   {
      readonly DateTime date;
      public string lg { get; set; }
      public string firstName { get; set; }
      public string lastName { get; set; }
      public int age { get; set; }

      public User(string login, string firstName, string lastName, int age)
      {
         this.lg = login;
         this.firstName = firstName;
         this.lastName = lastName;
         this.age = age;
         this.date = DateTime.Now;
      }

      public void Show()
      {
         Console.WriteLine($"Логин: {lg} Имя: {firstName} Фамилия: {lastName} Возраст: {age} Дата создания: {date}");
      }
   }
}