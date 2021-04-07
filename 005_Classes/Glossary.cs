using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Classes
{
   class Glossary
   {

      Dictionary<string, Dictionary<string, string>> glos = new Dictionary<string, Dictionary<string, string>>();
      string word;

      public Glossary()
      {
         glos.Add("eng-ru", new Dictionary<string, string>());
         glos.Add("ru-eng", new Dictionary<string, string>());
         glos["eng-ru"].Add("data", "дата");
         glos["eng-ru"].Add("time", "время");
         glos["ru-eng"].Add("время", "time");
         glos["ru-eng"].Add("дата", "data");
      }
      public void Find(string _lang, string _word)
      {
         if (glos.ContainsKey(_lang))
         {
            if (glos[_lang].ContainsKey(_word))
            {
               Console.WriteLine(glos[_lang][_word]);
            }
            else
            {
               Console.WriteLine($"слово {_word}в словаре отсутствует");
            }
         }
         else
         {
            Console.WriteLine($"словарь {_lang} отсутствует");
         }

      }
   }
}
