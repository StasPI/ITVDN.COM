using System;

namespace _004_Classes
{
   class Program
   {
      static void Main(string[] args)
      {
         ////Задание 2
         ////Используя Visual Studio, создайте проект по шаблону Console Application.  
         ////Требуется:
         ////Создайте класс AbstractHandler.
         ////В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
         ////Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler. 
         ////Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.

         //XMLHandler xml = new XMLHandler();
         //AbstractHandler txt = new TXTHandler();
         //AbstractHandler doc = new DOCHandler();
         //xml.Open();
         //txt.Save();
         //doc.Create();


         ////Задание 3
         ////Используя Visual Studio, создайте проект по шаблону Console Application.  
         ////Требуется:
         ////Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
         ////Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
         ////Написать программу, которая выполняет проигрывание и запись. 
         ///

         IPlayable pl = new Player();
         pl.Stop();
         IRecodable re = new Player();
         re.Stop();
      }
   }
}
