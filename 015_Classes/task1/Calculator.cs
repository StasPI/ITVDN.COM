using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
   class Calculator
   {
      Exception zeroEx = new Exception("На ночь делить нельзя!");

      public int Add(int a, int b)
      {
         return a + b;
      }
      public int Sub(int a, int b)
      {
         return a - b;
      }
      public int Mul(int a, int b)
      {
         return a * b;
      }
      public int Div(int a, int b)
      {
         try
         {
            return a / b;
         }
         catch
         {
            throw zeroEx;
         }
      }
   }
}
