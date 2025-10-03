using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Aufgabe_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean weiter = true;
            while (true)
            {
                WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
                WebResponse response = request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                string jsonData = new StreamReader(responseStream).ReadToEnd();
                JArray array = JArray.Parse(jsonData);
                array[0]["text"].ToString();
                Console.WriteLine(array[0]["text"].ToString());
                Console.WriteLine();
                Console.Write("Nächsten Witz holen? j/n ");
                string antwort = Console.ReadLine();
                Console.WriteLine();

                if (antwort == ("j"))
                {
                    weiter = true;

                }
                if (antwort == ("n"))
                {
                    weiter = false;

                    break;
                }

                if (antwort != "j" && antwort != "n")
                {
                    Console.WriteLine("Bitte nur j oder n eingeben!");
                    Console.WriteLine();
                    weiter = true;
                }
            }
        }
    }
}