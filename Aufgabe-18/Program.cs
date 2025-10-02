using System;

namespace Aufgabe_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string[] vokale = { "a", "e", "i", "o", "u", "ä", "ö", "ü",
                                "A", "E", "I", "O", "U", "Ä", "Ö", "Ü" };

                Console.WriteLine("Deine Eingabe: ");
                string eingabe = Console.ReadLine();
                Console.WriteLine();

                int gesamtanzahlVokale = 0;

                foreach (string vokal in vokale)
                {

                    int anzahlVokale = eingabe.Split(new string[] { vokal }, StringSplitOptions.None).Length - 1;


                    if (anzahlVokale > 0)
                    {
                        Console.WriteLine("Der Vokal " + vokal + " kommt " + anzahlVokale + " mal vor");
                        gesamtanzahlVokale += anzahlVokale;
                    }
                }


                Console.WriteLine("\nDein Text hat total " + gesamtanzahlVokale + " Vokale");
            }
        }
    }
}
    

