using System;

namespace Aufgabe_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lang soll die Diagonale sein?");
            Console.Write("Deine Eingabe: ");
            int lenght = Convert.ToInt32(Console.ReadLine());

            for (int zeile = 0; zeile < lenght; zeile++)
            {
                for (int spalte = 0; spalte < lenght; spalte++)
                {
                    if (spalte == zeile)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
           
        }
    }
}


