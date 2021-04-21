using System;
using System.Collections.Generic;

namespace _010_Classes
{
   class Program
   {
      static void Main(string[] args)
      {

         ////Задание
         ////Используя Visual Studio, создайте проект по шаблону Console Application.
         ////Создайте класс MyClass<T>, содержащий статический фабричный метод -T FacrotyMethod(), который будет порождать экземпляры типа, указанного в качестве параметра 
         ////типа(указателя места заполнения типом – Т).

         //int i = MyClass<int>.FacrotyMethod();
         //var l = MyClass<long>.FacrotyMethod();

         //Console.WriteLine(i.GetType());
         //Console.WriteLine(l.GetType());


         ////Задание 2
         ////Используя Visual Studio, создайте проект по шаблону Console Application.  
         ////Создайте класс MyList<T>.Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса List<T>. 
         ////Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента, индексатор для получения значения элемента по указанному индексу и свойство только 
         ////для чтения для получения общего количества элементов.  

         //MyList<int> myList = new MyList<int>();
         //myList.Add(3);
         //myList.Add(1);
         //myList.Add(5);

         //Console.WriteLine(myList.GetCount);
         //Console.WriteLine(myList.GetT(2));


         ////Задание 3
         ////Используя Visual Studio, создайте проект по шаблону Console Application.  
         ////Создайте класс MyDictionary<TKey, TValue>.Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary(Урок 6 пример 5). 
         ////Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, индексатор для получения значения элемента по указанному индексу 
         ////и свойство только для чтения для получения общего количества пар элементов.

         //MyDictionary<string, string> dictionary = new MyDictionary<string, string>(3);
         //dictionary.Add(0, "стол", "стул");
         //dictionary.Add(1, "вилка", "ложка");
         //dictionary.Add(2, "кони", "пони");

         //Console.WriteLine(dictionary.GetCount);
         //Console.WriteLine(dictionary.GetT(1));


         ////Задание 4
         ////Используя Visual Studio, создайте проект по шаблону Console Application.  
         ////Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
         ////Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для данного урока.Выведите на экран значения элементов массива, который вернул расширяющий 
         ////метод GetArray().

         //MyList<int> myList = new MyList<int>();
         //myList.Add(3);
         //myList.Add(1);
         //myList.Add(5);

         //int[] n = myList.GetArray();

         //for (int i = 0; i < n.Length; i++)
         //{
         //   Console.WriteLine(n[i]);
         //}

      }
   }
}
