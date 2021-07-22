extern alias t3p;


namespace task3
{
   class Program
   {
      static void Main(string[] args)
      {
         t3p.task3_public.MyPublicClass my = new t3p.task3_public.MyPublicClass();
         my.PublicMethod();
      }
   }
}
