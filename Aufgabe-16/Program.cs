using System;

namespace Aufgabe_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            bool weiterspielen = true;

            while (weiterspielen)
            {
                int random = rng.Next(1, 101);
                int versuche = 0;
                Console.WriteLine("Rate die Zahl (1..100): ");

                while (true)
                {
                    int eingabe = Convert.ToInt32(Console.ReadLine());
                    versuche++;

                    if (eingabe < 1 || eingabe > 100)
                    {
                        Console.WriteLine("Die Zahl muss zwischen 1 und 100 liegen! Nächster Versuch: ");
                    }
                    else if (eingabe < random)
                    {
                        Console.WriteLine("Die Zahl ist zu klein! Nächster Versuch: ");
                    }
                    else if (eingabe > random)
                    {
                        Console.WriteLine("Die Zahl ist zu groß! Nächster Versuch: ");
                    }
                    else
                    {
                        Console.WriteLine("DIe Zahl stimmt! du hast total " + versuche + " Versuhe benötigt.");
                        break;
                    }
                }

                Console.WriteLine("Noch einmal spielen? [y/n]");
                string antwort = Console.ReadLine().ToLower();


                if (antwort == "y")
                {
                    weiterspielen = true;
                }

                if (antwort == "n")
                {
                    weiterspielen = false;
                }
            }
        }
    }
}