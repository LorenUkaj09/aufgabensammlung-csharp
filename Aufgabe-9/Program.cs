using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Ganzzahlige Dezimalzahl (q to quit):");
                string input = Console.ReadLine();
                if(int.TryParse(input, out int number)){
                    string numberBin = Convert.ToString(number, 2);
                    Console.WriteLine("binär :" + numberBin);
                }
                else
                {
                    if (input?.ToLower() == "q")
                    {
                        break;
                    }
                }

                
          


               
                
             

            }  
        }
    }
}
