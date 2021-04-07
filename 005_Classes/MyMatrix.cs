using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Classes
{
   class MyMatrix
   {
      private int rows;
      private int columns;
      int[,] mas;
      int[,] mas2;

      public MyMatrix(int _countRows, int _countColumns)
      {
         if ((_countRows >= 0) & (_countColumns >= 0))
         {
            mas = new int[_countRows, _countColumns];
            Fill(mas);
         }
         else
         {
            Console.WriteLine("Массив не может быть отрицательным.");
         }

      }

      public void ChengeSize(int _countRows, int _countColumns)
      {
         if ((_countRows >= 0) & (_countColumns >= 0))
         {
            mas2 = mas;
            mas = new int[_countRows, _countColumns];

            rows = Math.Min(mas2.GetUpperBound(0) + 1, mas.GetUpperBound(0) + 1);
            columns = Math.Min(mas2.GetUpperBound(1) + 1, mas.GetUpperBound(1) + 1);

            for (int i = 0; i < rows; i++)
               for (int j = 0; j < columns; j++)
                  mas[i, j] = mas2[i, j];
            Fill(mas);
         }
         else
         {
            Console.WriteLine("Массив не может быть отрицательным.");
         }
      }

      private void Fill(int[,] mas)
      {
         Random rnd = new Random();
         rows = mas.GetUpperBound(0) + 1;
         columns = mas.GetUpperBound(1) + 1;

         for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
               if (mas[i, j] == 0)
                  mas[i, j] = rnd.Next(1, 10);
      }

      internal void Show()
      {
         ShowPartly(0, 0, rows, columns);
      }

      public void ShowPartly(int startRow, int startCol, int endRow, int endCol)
      {
         if (startRow < 0 || startCol < 0 || endRow > rows || endCol > columns)
         {
            Console.WriteLine("Попытка обращения за пределы массива.");
            return;
         }

         if (startRow > endRow || startCol > endCol)
         {
            Console.WriteLine("Неверно заданы координаты конечной точки");
            return;
         }

         for (int i = startRow; i < endRow; i++)
         {
            for (int j = startCol; j < endCol; j++)
               Console.Write($"{mas[i, j]} \t");
            Console.Write("\n");
         }
      }

      public int this[int index1, int index2]
      {
         get
         {
            if (index1 >= 0 && index1 < rows && index2 >= 0 && index2 < columns)
               return mas[index1, index2];
            Console.WriteLine("Попытка обращения за пределы массива.");
            return 0;
         }

         set
         {
            if (index1 >= 0 && index1 < rows && index2 >= 0 && index2 < columns)
               mas[index1, index2] = value;
            else
               Console.WriteLine("Попытка записи за пределами массива.");
         }
      }
   }
}