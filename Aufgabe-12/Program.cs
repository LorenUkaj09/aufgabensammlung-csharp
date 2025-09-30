using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_12
{
    internal class Program
    {
       
        
        static int[] SumUp(int[] arr)
        {


            int[] result = new int[arr.Length];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                result[i] = sum;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Zahlen Aufsummieren");
            Console.WriteLine("-------------------");

            Console.WriteLine("Geben sie die zu summierenden Ganzzahlen mit komma getrennt ein :");

            string eingabe = Console.ReadLine();
            string[] inputArray = eingabe.Split(',');
            int[] zahlen = inputArray.Select(s =>  int.Parse(s.Trim())).ToArray();
            int[] aufsummiert = SumUp(zahlen);


            Console.WriteLine("Eingabe: " + string.Join(", ", zahlen));
            Console.WriteLine("Aufsummiert: " + string.Join(", ", aufsummiert));
        }
    }   
}
