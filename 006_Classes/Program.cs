using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace _006_Classes
{
   class Program
   {
      static void Main()
      {

         ////Задание
         ////Используя Visual Studio, создайте проект по шаблону Console Application.
         ////Требуется:  
         ////Создать статический класс Calculator, с методами для выполнения основных арифметических операций.
         ////Написать программу, которая выводит на экран основные арифметические операции.

         //Calculator.Plus(1, 2);
         //Calculator.Minus(2, 3);
         //Calculator.Times(3, 4);
         //Calculator.Divided(4, 5);

         ////Задание 2 
         ////Используя Visual Studio, создайте проект по шаблону Console Application.  
         ////Требуется:  
         ////Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для поиска по книге из примера урока 005_Delegation.
         ////При вызове этого метода, производится последовательный поиск строки в книге. 

         //FindAndReplaceManager farm = new FindAndReplaceManager();
         //farm.FindNext("a");

         ////Задание 3 
         ////Используя Visual Studio, создайте проект по шаблону Console Application.  
         ////Расширьте пример урока 005_Delegation, создав в классе Book, вложенный класс Notes, который позволит сохранять заметки читателя.

         //Book.Notes nn = new Book.Notes();
         //nn.AddNotes("я первая заметка");
         //nn.AddNotes("я вторая заметка");
         //nn.ShowNotes();

         ////Задание 4 
         ////Используя Visual Studio, создайте проект по шаблону Console Application.  
         ////Требуется: Создать расширяющий метод для целочисленного массива, который сортирует элементы массива по возрастанию. 

         //int[] array = new int[] { 5, 6, 2, 1, 3, 4 };
         //array.SortMethod();
         //foreach (int i in array)
         //{
         //   Console.WriteLine(i);
         //}
      }
   }
}