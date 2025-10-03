using System;

namespace Aufgabe_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Make your calculation (2 numbers only) (or press Q to quit): ");
                string eingabe = Console.ReadLine();

                if (eingabe.Trim().ToLower() == "q")
                    break;

                string[] teile = eingabe.Split('+', '-', '*', '/');

                if (teile.Length == 2 &&
                    double.TryParse(teile[0].Trim(), out double zahl1) &&
                    double.TryParse(teile[1].Trim(), out double zahl2))
                {
                    double ergebnis = 0;
                    bool gueltig = true;

                    if (eingabe.Contains("+"))
                        ergebnis = zahl1 + zahl2;
                    else if (eingabe.Contains("-"))
                        ergebnis = zahl1 - zahl2;
                    else if (eingabe.Contains(""))
                        ergebnis = zahl1 * zahl2;
                    else if (eingabe.Contains("/"))
                    {
                        if (zahl2 != 0)
                            ergebnis = zahl1 / zahl2;
                        else
                        {
                            Console.WriteLine("Error: Division by zero.");
                            gueltig = false;
                        }
                    }
                    else
                        gueltig = false;

                    if (gueltig)
                        Console.WriteLine($"Result: {ergebnis}");
                }
                else
                {
                    Console.WriteLine("Error: Invalid input.");
                }

                Console.WriteLine();
            }
        }
    }
}