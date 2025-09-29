using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Zahl1;
            int Zahl2;
            // Die Methode WriteLine() fügt am Ende einen Zeilenumbruch ein
         Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.");

        Console.Write("Zahl 1: ");
        Zahl1 = Convert.ToInt32(Console.ReadLine());

         Console.Write("Zahl 2: ");
        Zahl2 = Convert.ToInt32(Console.ReadLine());

       
         double sum = Zahl1 + Zahl2;

         Console.WriteLine(sum);

        }
    }
}
