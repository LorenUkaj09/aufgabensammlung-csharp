using System;

namespace Aufgabe_10
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Geben sie eine zahl ein um die Quersumme zu berechnen");
            int Zahl = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (Zahl != 0)
            {
                sum = sum + (Zahl % 10);
                Zahl = Zahl / 10;
            }

            Console.WriteLine("Die Quersumme von" + Zahl + "ist" + sum);


        }
    }
}
