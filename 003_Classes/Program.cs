using System;
using System.Collections.Generic;

namespace _003_Classes
{
   class Program
   {
      static void Main(string[] args)
      {
         ////Дополнительное
         //Printer1 printer1 = new Printer1();
         //printer1.Print("Print1");
         //Printer printer = (Printer)printer1;
         //printer.Print("Print");
         //Printer2 printer2 = new Printer2();
         //printer2.Print("Printer2");

         //Задание 2
         //Используя Visual Studio, создайте проект по шаблону Console Application.  
         //Требуется:
         //Создать класс, представляющий учебный класс ClassRoom.
         //Создайте класс ученик Pupil.  В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().  
         //Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
         //Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
         //Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
         //Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.

         //Dictionary<string, Pupil> student = new Dictionary<string, Pupil>();
         //student.Add("ExcelentPupil", new ExcelentPupil());
         //student.Add("GoodPupil", new GoodPupil());
         //student.Add("BadPupil", new BadPupil());
         //ClassRoom a1 = new ClassRoom(student);

         //Задание 3
         //Используя Visual Studio, создайте проект по шаблону Console Application.  
         //Требуется:
         //Создать класс Vehicle.
         //В теле класса создайте поля: координаты и параметры средств передвижения(цена, скорость, год выпуска).
         //Создайте 3 производных класса Plane, Саг и Ship.
         //Для класса Plane должна быть определена высота и количество пассажиров.  
         //Для класса Ship — количество пассажиров и порт приписки.
         //Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

         Plane plane = new Plane(5, 10, 10000000, 350, 1981, 50, 60);
         plane.Show();
         Ship ship = new Ship(10, 10, 10000000, 35, 2000, 3000, "home");
         ship.Show();

         //Задание 4
         //Используя Visual Studio, создайте проект по шаблону Console Application.  
         //Требуется:
         //Создайте класс DocumentWorker.
         //В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
         //В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт", "Редактирование документа доступно в версии Про", "Сохранение документа доступно в версии Про".
         //Создайте производный класс ProDocumentWorker.  
         //Переопределите соответствующие методы, при переопределении методов выводите следующие строки: "Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт".
         //Создайте производный  класс ExpertDocumentWorker от базового класса ProDocumentWorker. Переопределите соответствующий метод.При вызове данного метода необходимо выводить на экран "Документ сохранен в новом формате".
         //В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.Если пользователь не вводит ключ, он может пользоваться только
         //бесплатной версией(создается экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен создаться экземпляр соответствующей версии класса,
         //приведенный к базовому - DocumentWorker.

         Dictionary<string, string> systemKey = new Dictionary<string, string>();
         systemKey.Add("1234", "ProDocumentWorker" );
         systemKey.Add("4321", "ExpertDocumentWorker");

         DocumentWorker doc = new DocumentWorker();

         Console.WriteLine("У вас есть ключ доступа? Yes or No");
         string answer = Console.ReadLine();
         if (answer == "Yes")
         {
            Console.WriteLine("Введите ключ:");
            string userKey = Console.ReadLine();
            if (systemKey[userKey] == "ProDocumentWorker")
            {
               Console.WriteLine("Вам доступна про версия");
               doc = new ProDocumentWorker();
               doc.OpenDocument();
               doc.EditDocument();
               doc.SaveDocument();
            }
            else if (systemKey[userKey] == "ExpertDocumentWorker")
            {
               Console.WriteLine("Вам доступна експерт версия:");
               doc = new ExpertDocumentWorker();
               doc.OpenDocument();
               doc.EditDocument();
               doc.SaveDocument();
            }

         }
         else if (answer == "No")
         {
            Console.WriteLine("Вам доступна бесплатная версия");
            doc = new DocumentWorker();
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();
         }
      }
   }
}
