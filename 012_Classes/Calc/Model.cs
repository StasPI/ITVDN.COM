namespace Calc
{
   class Model
   {
      public string Plus(int a, int b)
      {
         return (a + b).ToString();
      }

      public string Minus(int a, int b)
      {
         return (a - b).ToString();
      }

      public string Times(int a, int b)
      {
         return (a * b).ToString();
      }

      public string Division(int a, int b)
      {
         return (a / b).ToString();
      }
   }
}