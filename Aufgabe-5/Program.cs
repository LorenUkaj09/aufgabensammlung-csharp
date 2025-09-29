using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wie viele Kilometer möchtest du rennen? ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int km))
            {
                Console.WriteLine("Fehler: Bitte eine ganze Zahl eingeben!");
                return;
            }

         
            if (km > 42)
            {
                Console.WriteLine("Das schaffst du nicht!");
                return;
            }

         
            int runden = km * 1000 / 400;

            Console.WriteLine($"Das sind {runden} Runden. Bereit für den Lauf? (ja/nein)");
            string bereit = Console.ReadLine()?.Trim().ToLower();

            if (bereit != "ja")
            {
                Console.WriteLine("Okay, vielleicht später!");
                return;
            }

          
            for (int i = 1; i <= runden; i++)
            {
                Console.WriteLine($"Du läufst Runde {i}");
            }

            Console.WriteLine("Du hast es geschafft!");
        }
    }
}

    
