using System;

namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Breite des Stammes? ");
            int stammBreite = Convert.ToInt32(Console.ReadLine());

            Console.Write("Höhe des Stammes? ");
            int stammHoehe = Convert.ToInt32(Console.ReadLine());

            Console.Write("Höhe der Krone? ");
            int kronenHoehe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dein Baum wird generiert...");
            System.Threading.Thread.Sleep(1000);

            ZeichneBaum(stammBreite, stammHoehe, kronenHoehe);

            Console.ReadKey();
        }

        static void ZeichneBaum(int stammBreite, int stammHoehe, int kronenHoehe)
        {
            ZeichneKrone(kronenHoehe);
            ZeichneStamm(stammBreite, stammHoehe, kronenHoehe);
        }

        static void ZeichneKrone(int kronenHoehe)
        {
            for (int zeile = 0; zeile < kronenHoehe; zeile++)
            {
                for (int leer = 0; leer < kronenHoehe - zeile - 1; leer++)
                {
                    Console.Write(" ");
                }
                for (int stern = 0; stern < (2 * zeile) + 1; stern++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void ZeichneStamm(int stammBreite, int stammHoehe, int kronenHoehe)
        {
            for (int zeile = 0; zeile < stammHoehe; zeile++)
            {
                for (int leer = 0; leer < (kronenHoehe - 1) - (stammBreite / 2); leer++)
                {
                    Console.Write(" ");
                }
                for (int stamm = 0; stamm < stammBreite; stamm++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}