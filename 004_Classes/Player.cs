using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Classes
{
   class Player : IRecodable, IPlayable
   {
      void IPlayable.Pause()
      {
         Console.WriteLine("IPlayable.Pause");
      }

      void IPlayable.Play()
      {
         Console.WriteLine("IPlayable.Play");
      }

      void IPlayable.Stop()
      {
         Console.WriteLine("IPlayable.Stop");
      }

      void IRecodable.Pause()
      {
         Console.WriteLine("IRecodable.Pause");
      }

      void IRecodable.Record()
      {
         Console.WriteLine("IRecodable.Record");
      }

      void IRecodable.Stop()
      {
         Console.WriteLine("IRecodable.Stop");
      }
   }
}
