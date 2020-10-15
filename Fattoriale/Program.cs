using System;

namespace Fattoriale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Il fattoriale di {n} è {Fattoriale(n)}");
            
        }


        static int Fattoriale(int n) {
            if (n == 0)
                return 1;
            return n * Fattoriale(n -1);

            /* ora ho capito :)
            praticamente n resta sempre uguale su "return n"
            ma Fattoriale(n-1) crea una cascata di chiamate a Fattoriale
            quindi non è che ricomincia, si richiama dentro se stesso
            per questo ogni invocazione di se stesso fa calare di uno
            */
        }

    }
}
