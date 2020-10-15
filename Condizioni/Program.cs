using System;

namespace Condizioni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Scrivi qualcosa: ");
            string s = Console.ReadLine();

            if (s == "Primo")
                Console.WriteLine("Hai scritto Primo");
            else if (s == "Secondo")
                Console.WriteLine("Hai scritto Secondo");
            else
                Console.WriteLine($"Hai Scritto {s}");

            switch (s) {
                case "Primo":
                    Console.WriteLine("Hai scritto primo");
                    break;
                case "Secondo":
                    Console.WriteLine("Hai scritto secondo");
                    break;
                 default:
                    Console.WriteLine($"Hai Scritto {s}");
                    break;

            }
                
        }
    }
}
