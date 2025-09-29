using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnung von Sekunden eines Monats in Abhängigkeit seiner Anzahl tage");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(" Wieviele Tage hat der Monat, für den sie die sekundenzahl berechnen wollen?");
            int Tage = Convert.ToInt32(Console.ReadLine());

            int sektag  = 3600 * 24;
            int sekmonat = sektag * Tage;
            int minmonat = 28;
            int maxmonat = 31;

            if (Tage < minmonat || Tage > maxmonat)
            {
                Console.WriteLine("Ungültige Eingabe " + Tage + " gibt es nicht");
            }
            else
            {
                Console.WriteLine("Ein monat mit" + Tage + "Tagen hat" + sekmonat + "Sekunden" );

            }

            }


           
        }
    }

