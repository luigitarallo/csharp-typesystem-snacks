using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Snack 1
            // L’utente inserisce due numeri in successione.
            // Il software stampa il maggiore.

            int numb1;
            int numb2;
            Console.WriteLine("Inserisci il primo numero");
            numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero");
            numb2 = Convert.ToInt32(Console.ReadLine());
            if (numb1 > numb2)
            {
                Console.WriteLine($"Il numero maggiore è {numb1}");
            }
            else if(numb1 < numb2) {
                Console.WriteLine($"Il numero maggiore è {numb2}");
            }else
            {
                Console.WriteLine($"I numeri sono uguali");
            }

            // Snack 2
            // L’utente inserisce due parole in successione.
            // Il software stampa prima la parola più corta, poi la parola più lunga.

            string word1;
            string word2;
            Console.WriteLine("Scrivi una parola");
            word1 = Console.ReadLine();
            Console.WriteLine("Scrivi un'altra parola");
            word2 = Console.ReadLine();
            if (word1.Length > word2.Length) {
                Console.WriteLine($"La parola più corta è {word2} mentre la più lunga è {word1}");
            }else if(word1.Length < word2.Length)
            {
                Console.WriteLine($"La parola più corta è {word1} mentre la più lunga è {word2}");
            }
            else
            {
                Console.WriteLine("Le parole hanno uguale lunghezza");
            }

            // Snack 3
            // Il software deve chiedere per 10 volte all’utente di inserire un numero.
            // Il programma stampa la somma di tutti i numeri inseriti.

            int[] userNumbers = new int[10];
            int sum=0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Inserisci un numero:");
                userNumbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += userNumbers[i];
            }
            Console.WriteLine($"La somma di tutti i numeri inseriti è: {sum}");

            // Snack 4
            // Calcola la somma e la media dei numeri da 2 a 10.

            //int[] numbers= new int[2,3,4,5,6,7,8,9,10];
        }
    }
}
