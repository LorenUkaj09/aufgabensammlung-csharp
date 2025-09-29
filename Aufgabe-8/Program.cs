using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Aufgabe_8
{
    class Program
    {
        static void Main()
        {
          
            string[] forbiddenWords = { "Fick dich ", "arschloch" };

            
            Console.WriteLine("Dein Kommentar:");
            string userComment = Console.ReadLine();

          
            int forbiddenWordCount = 0;

           
            foreach (string word in forbiddenWords)
            {
                if (userComment.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    forbiddenWordCount++;
                }
            }

           
            if (forbiddenWordCount > 0)
            {
                Console.WriteLine($"Dein Kommentar enthält {forbiddenWordCount} verbotene Wörter. Er wird nicht veröffentlicht.");
            }
            else
            {
                Console.WriteLine("Vielen Dank für deinen Kommentar. Er wurde veröffentlicht.");
            }
        }
    }
}