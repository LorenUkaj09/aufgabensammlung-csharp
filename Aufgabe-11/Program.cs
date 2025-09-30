using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nummer1 = 0;
            int nummer2 = 0;

            Console.WriteLine("Zahl 1: ");

            while (int.TryParse(Console.ReadLine(), out nummer1) == false)
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Ganzzahl ein.");
            }

            Console.WriteLine("Zahl 2: ");

            while (int.TryParse(Console.ReadLine(), out nummer2) == false)
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Ganzzahl ein.");
            }


            Console.WriteLine("\nZahl, Quersumme, Zahl/Quersumme");

            string result = "-".PadRight(37, '-')
                            + Environment.NewLine;


            for (int i = nummer1; i <= nummer2; i++)
            {
                int sum = Checksum(i);
                if (i % sum == 0)
                {
                    Console.WriteLine(i + ", " + sum + ", " + i / sum);

                }
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int Checksum(int n)
        {
            var sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;




        }
    }
}
