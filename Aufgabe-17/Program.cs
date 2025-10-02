using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gib ein Geburtsdatum ein: ");
            string input = Console.ReadLine();

            DateTime birthDate;

            if (DateTime.TryParse(input, out birthDate))
            {
                TimeSpan diff = DateTime.Today - birthDate;

                int ageInDays = diff.Days;

                int ageInWeeks = ageInDays / 7;

                int ageInYears = DateTime.Today.Year - birthDate.Year;

                int ageInMonths = ageInYears * 12;

                if (DateTime.Today.Month < birthDate.Month)
                {
            
                    ageInYears--;
                    ageInMonths -= birthDate.Month - DateTime.Today.Month;

                }
                else if (DateTime.Today.Month == birthDate.Month
                            && DateTime.Today.Day < birthDate.Day)
                {
                    
                    ageInYears--;
                    ageInMonths--;
                }
                else if (DateTime.Today.Month > birthDate.Month)
                {
                  
                    ageInMonths += DateTime.Today.Month - birthDate.Month;

                    if (DateTime.Today.Day < birthDate.Day)
                    {
                      
                        ageInMonths--;
                    }
                }

                Resultat(ageInYears, ageInMonths, ageInWeeks, ageInDays);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte gib ein gültiges Datum ein.");
            }

            Console.ReadKey();
        }

        private static void Resultat(double years, double months, double weeks, double days)
        {
            Console.WriteLine("\nAlter in Jahren: " + years.ToString());
            Console.WriteLine("Alter in Monaten: " + months.ToString());
            Console.WriteLine("Alter in Wochen: " + weeks.ToString());
            Console.WriteLine("Alter in Tagen: " + days.ToString());
        }
    }
}
