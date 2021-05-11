using System;
using System.Collections;

namespace _011_Classes
{
   class Program
   {
      static void Main(string[] args)
      {
         ////Задание
         ////Используя Visual Studio, создайте проект по шаблону Console Application.
         ////В коллекцию  ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа, переберите данную коллекцию с помощью, цикла for – С какой проблемой вы столкнулись ?

         //ArrayList arrayList = new ArrayList();

         //arrayList.Add(1);
         //arrayList.Add("one");

         //foreach (var i in arrayList)
         //{
         //   Console.WriteLine(i);
         //}

         ////// другое название метода для получения длины массива
         //for (int i = 0; i < arrayList.Count; i++)
         //{
         //   Console.WriteLine(arrayList[i]);
         //}


         ////Задание 2
         ////Используя Visual Studio, создайте проект по шаблону Console Application.
         ////Создайте класс CarCollection<T>.Реализуйте в простейшем приближении возможность использования его экземпляра для создания парка машин.Минимально требуемый интерфейс взаимодействия 
         ////с экземпляром, должен включать метод добавления машин с названием машины и года ее выпуска, индексатор для получения значения элемента по указанному индексу и свойство только 
         ////для чтения для получения общего количества элементов.
         ////Создайте метод удаления всех машин автопарка.

         //CarCollection<string> collection = new CarCollection<string>();

         //collection.Add("Молния Маквин", 1991);
         //collection.Add("Хатсен Хорнот", 1982);
         //collection.Add("Выхлоп", 1973);

         //Console.WriteLine(collection[1]);
         //Console.WriteLine(collection.Count);
         //collection.Clean();
         //Console.WriteLine(collection.Count);


         ////Задание 3
         ////Используя Visual Studio, создайте проект по шаблону Console Application.
         ////Создайте класс Dictionary<TKey, TValue>.Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен 
         ////System.Collections.Generic.Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, индексатор для получения значения элемента 
         ////по указанному индексу и свойство только для чтения для получения общего количества пар элементов.

         //MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
         //dictionary.Add("стол", "стул");
         //dictionary.Add("вилка", "ложка");
         //dictionary.Add("кони", "пони");

         //Console.WriteLine(dictionary.Lenght);
         //Console.WriteLine(dictionary.Get(1));


         ////Задание 4
         ////Используя Visual Studio, создайте проект по шаблону Console Application.
         ////Создайте класс ArrayList.Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections.

         //MyArrayList m = new MyArrayList();

         //m.Add(5);
         //m.Add("Hello");
         //m.Add('d');
         //m.Add(5.78);

         //for (int i = 0; i < m.Length; i++)
         //{
         //   Console.WriteLine(m[i]);
         //}

      }
   }
}
