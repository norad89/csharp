using System;

namespace Metodi
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = Somma(10,5);
            Console.WriteLine(z); // 15
        }

        static int Somma (int x, int y) {
            int s = x + y;
            return s;
        } //il metodo somma specifica come comportarsi
            // viene richiamato nel metodo precedente void
        
        static double Somma(double x,double y) {
            double s = x + y;
            return s;

            // questo è un overload di metodi: due metodi con la stessa signature
            // ovvero lo stesso nome (Somma)
            // tipo differente (int vs double)
            // e lo stesso numero di elementi (2)
            // il metodo void invocherà il metodo corretto a seconda degli elemnti inseriti (se sono double o se sono int)
        }
    }
}
