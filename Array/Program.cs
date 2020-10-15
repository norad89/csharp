using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] arr = new int[5,5];
            int counter = 0;
            for (int i = 0; i < 5; i++) { // qui i rappresenta le righe, da 0 a 4, e j le colonne. questo primo loop costruisce l'array
                for (int j = 0; j < 5; j++) { // per ogni riga viene anche costruita una colonna con un altro loop
                        ++counter; // al termine della costruzione di righe e colonne, aumenta un counter
                        arr[i,j] = (j == 0) ? 0 : counter;
                        // impostiamo l'array riga/colonna con un test condizionale se la colonna j == 0 allora (?) il valore è zero, altrimenti (:) è counter
                }
            }
            for (int i = 0; i <5; i++) { 
                for (int j = 0; j < 5; j++) 
                    Console.Write($"{arr[i,j]} "); // questo write richiama il test condizionale e posiziona 0 oppure counter su ogni valore di riga e colonna
                Console.Write("\n");

            }
        }
    }
}
