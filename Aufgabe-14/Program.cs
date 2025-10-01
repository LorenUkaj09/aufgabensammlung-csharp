using System;

namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prüfen,ob es sich bei einem jahr um ein Schaltjahr handelt");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Eingabe Jahr ( q zum Beenden):");
                string input = Console.ReadLine();

                if (input?.ToLower() == "q")
                {
                    break;
                }

                if (int.TryParse(input, out int eingabe))
                {
                    if ((eingabe % 4 == 0 && eingabe % 100 != 0) || eingabe % 400 == 0)
                    {
                        Console.WriteLine(eingabe + " ist ein Schaltjahr");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(eingabe + " ist kein Schaltjahr");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein oder 'q' zum Beenden.");
                    Console.WriteLine();
                }
            }
        }
    }
}
