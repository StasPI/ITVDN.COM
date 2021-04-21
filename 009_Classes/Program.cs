using System;

namespace _009_Classes
{
   class Program
   {
      static void Main(string[] args)
      {
         ////Задание
         ////Используя Visual Studio, создайте проект по шаблону Console Application.
         ////Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и возвращает среднее арифметическое этих аргументов.

         //MyFirst first = delegate (int x, int y, int z) { return (x + y + z) / 3; };
         //Console.WriteLine(first(1, 2, 3));

         ////Задание 2
         ////Используя Visual Studio, создайте проект по шаблону Console Application.  
         ////Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление). 
         ////Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления.Лямбда оператор деления должен делать проверку деления на ноль.
         ////Написать программу, которая будет выполнять арифметические действия указанные пользователем. 

         //Console.WriteLine("Введите первое число");
         //int x = Int32.Parse(Console.ReadLine());
         //Console.WriteLine("Введите второе число");
         //int y = Int32.Parse(Console.ReadLine());
         //Console.WriteLine("Введите одну из доступных операций Add – сложение, Sub – вычитание, Mul – умножение, Div – деление");
         //string oper = Console.ReadLine().ToLower();

         //MyCalc Add = (x, y) => { return x + y; };
         //MyCalc Sub = (x, y) => { return x - y; };
         //MyCalc Mul = (x, y) => { return x * y; };
         //MyCalc Div = (x, y) => {
         //                           if (y == 0)
         //                           {
         //                              Console.WriteLine("Делить на ноль нельзя, лови ноль.");
         //                              return 0;
         //                           }
         //                           else
         //                              return x / y;
         //                       };

         //int result;

         //switch (oper)
         //{
         //   case "add":
         //      {
         //         result = Add(x, y);
         //         break;
         //      }
         //   case "sub":
         //      {
         //         result = Sub(x, y);
         //         break;
         //      }
         //   case "mul":
         //      {
         //         result = Mul(x, y);
         //         break;
         //      }
         //   case "div":
         //      {
         //         result = Div(x, y);
         //         break;
         //      }
         //   default:
         //      {
         //         Console.WriteLine("Вы ввели недопустимое значение.");
         //         result = 0;
         //         break;
         //      }
         //}

         //Console.WriteLine(result);


         ////Задание 3
         ////Используя Visual Studio, создайте проект по шаблону Console Application.  
         ////Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает среднее арифметическое возвращаемых значений методов сообщенных 
         ////с делегатами в массиве.Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.

         Console.WriteLine("Здадайте размер массива");
         int x = Int32.Parse(Console.ReadLine());

         RD rdd = delegate () { return new Random().Next(x); };
         RD[] array = new RD[x];

         for (int i = 0; i < array.Length; i++)
         {
            array[i] = () => new RD(rdd).Invoke();
         }

         RDArray a = delegate(RD[] c) {
                                         int y = new int();
                                         foreach (var i in array)
                                         {
                                            y += i.Invoke();
                                         }
                                         return y / array.Length;
                                      };

         foreach (var i in array)
         {
            Console.WriteLine(i.Invoke());
         }

         Console.WriteLine(a(array));


      }
      public delegate int MyFirst(int x, int y, int z);
      public delegate int MyCalc(int x, int y);

      public delegate int RD();
      public delegate int RDArray(RD[] rd);
   }
}
