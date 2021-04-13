using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _007_Classes
{
   class Program
   {
      static void Main(string[] args)
      {
         ////Задание
         ////Используя Visual Studio, создайте проект по шаблону Console Application.
         ////Создайте структуру с именем -Notebook.
         ////Поля структуры: модель, производитель, цена.
         ////В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого полей на экран.

         //Notebook a1 = new Notebook("one", "two", 3);
         //a1.Show();

         ////Задание 2
         ////Используя Visual Studio, создайте проект по шаблону Console Application.  
         ////Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления.
         ////Написать программу, выполняющую следующие действия: 
         ////-ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train(записи должны быть упорядочены по номерам поездов);
         ////-вывод на экран информации о поезде, номер которого введен с клавиатуры(если таких поездов нет, вывести соответствующее сообщение).

         //Train[] tr1 = new Train[2];
         //string destinationName;
         //int trainNumber;
         //int sw = 0;

         //// Принять с консоли
         //for (int i = 0; i < tr1.Length; ++i)
         //{
         //   Console.WriteLine($"Введи пункт назначения для {i + 1} из {tr1.Length}");
         //   destinationName = Console.ReadLine();
         //   Console.WriteLine("Введи номер поезда");
         //   trainNumber = Convert.ToInt32(Console.ReadLine());

         //   tr1[i] = new Train(destinationName, trainNumber, DateTime.Now);
         //}
         //// Сортировка
         //List<Train> tr2 = tr1.OrderBy(si => si.trainNumber).ToList();

         //// Вывод информации по нужному поезду
         //Console.WriteLine("Введите номер поезда что бы получить информацию по нему");
         //trainNumber = Convert.ToInt32(Console.ReadLine());

         //for (int i = 0; i < tr1.Length; ++i)
         //{
         //   if (tr1[i].trainNumber == trainNumber)
         //   {
         //      Console.WriteLine($"{tr1[i].trainNumber}, {tr1[i].destinationName}, {tr1[i].departureTime}");
         //      sw = 1;
         //   }
         //}
         //if (sw != 1)
         //{
         //   Console.WriteLine($"Херня какая то");
         //}

         ////Задание 3
         ////Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
         ////В классе Program  создайте два  метода:  
         ////- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass значение «изменено». 
         ////- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct значение «изменено». 
         ////Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры структуры и класса.Измените, 
         ////значения полей экземпляров на «не изменено», а затем вызовите методы ClassTaker и StruktTaker.Выведите на экран значения полей экземпляров. 
         ////Проанализируйте полученные результаты.

         MyClass myClass = new MyClass();
         MyStruct myStruct = new MyStruct();

         myClass.change = "MyClass не изменено";
         myStruct.change = "MyStruct не изменено";

         Console.WriteLine(myClass.change);
         Console.WriteLine(myStruct.change);

         ClassTaker(myClass);
         StruktTaker(myStruct);

         Console.WriteLine(myClass.change);
         Console.WriteLine(myStruct.change);

         Console.ReadKey();
      }

      static void ClassTaker(MyClass myClass)
      {
         myClass.change = "MyClass изменено";
      }
      static void StruktTaker(MyStruct myStruct)
      {
         myStruct.change = "MyStruct изменено";
      }
   }
}