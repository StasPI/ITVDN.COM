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

      public dynamic Add(dynamic a, dynamic b)
      {
         return a + b;
      }
      public dynamic Sub(dynamic a, dynamic b)
      {
         return a - b;
      }
      public dynamic Mul(dynamic a, dynamic b)
      {
         return a * b;
      }
      public dynamic Div(dynamic a, dynamic b)
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
