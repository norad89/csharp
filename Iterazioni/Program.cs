using System;

namespace Iterazioni
{
    class Program
    {
        static void Main(string[] args)
        {
            int righe;
            while (true) { // questa graffa contiene tutto il programma
                Console.Write("Indica un numero ('no per uscire): ");
                string s = Console.ReadLine(); // readline definisce la lettura della variabile s

                if (s == "no") { // questa graffa contiene solo il ciclo di chiusura, come stringa
                    Console.WriteLine("Ciao");
                    break;
                }
                
                // la variabile righe serve per poter utilizzare i boolean (i boolean non vanno sul tipo string ma solo sul tipo int)
                righe = Convert.ToInt32(s); //quindi viene convertita la stringa "s" a Integer a 32 bit con convert.toint32(s)
                for (int r = 1; r <= righe; r++){ //questo ciclo for conta da 1 al numero di righe inserite dall'utente
                    for (int ast = 1; ast <= r; ast++) { //questo ciclo for quindi si ripete per ogni riga inserita per l'utente e aumenta la variabile asterischi
                        Console.Write("* "); //ogni volta che il ciclo viene reiterato, scrive "* "
                    }
                    Console.Write("\n"); //una volta terminato il ciclo asterischi, viene utilizzato il comando per andare a capo. In realtà funziona anche writeline
                                        
                }
            }
            
        }
    }
}
