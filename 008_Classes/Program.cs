using System;
using System.Globalization;

namespace _008_Classes
{
   class Program
   {
      static void Main(string[] args)
      {
         ////Задание
         ////Используя Visual Studio, создайте проект по шаблону Console Application.
         ////Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить количество дней до его следующего дня рождения. 

         DateTime dateOfBirth;
         DateTime dateNow = DateTime.Now;

         dateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd-MM", System.Globalization.CultureInfo.InvariantCulture);

         int days = (dateOfBirth - dateNow).Days;

         Console.WriteLine(days);

         ////Задание 2
         ////Используя Visual Studio, создайте проект по шаблону Console Application. 
         ////Создайте статический класс с методом void Print(string stroka, int color), который выводит на экран строку заданным цветом.Используя перечисление,
         ////создайте набор цветов, доступных пользователю.Ввод строки и выбор цвета предоставьте пользователю.

         //int color;
         //string text;
         //Console.WriteLine("Введите текст:");
         //text = Console.ReadLine();
         //Console.WriteLine("Введе номер одного из доступных цветов Green = 0,Red = 1, Black = 2");
         //color = Int32.Parse(Console.ReadLine());

         //PrintColor.Print(text, color);

         ////Задание 3
         ////Используя Visual Studio, создайте проект по шаблону Console Application.  
         ////Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант. 
         ////Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за месяц.
         ////Создайте класс  Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее давать или нет сотруднику премию. Если сотрудник отработал
         ////больше положеных часов в месяц, то ему положена премия.

      }
   }
}
