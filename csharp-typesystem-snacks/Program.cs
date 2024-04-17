using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System;
using System.Collections.Generic;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*------------------------
             Snack 1
             L’utente inserisce due numeri in successione.
             Il software stampa il maggiore.
            ------------------------*/
            {
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
                else if (numb1 < numb2)
                {
                    Console.WriteLine($"Il numero maggiore è {numb2}");
                }
                else
                {
                    Console.WriteLine($"I numeri sono uguali");
                }
            }

            /*------------------------
            Snack 2
            L’utente inserisce due parole in successione.
            Il software stampa prima la parola più corta, poi la parola più lunga.
            ------------------------*/
            { 
                string word1;
                string word2;
                Console.WriteLine("Scrivi una parola");
                word1 = Console.ReadLine();
                Console.WriteLine("Scrivi un'altra parola");
                word2 = Console.ReadLine();
                if (word1.Length > word2.Length)
                {
                    Console.WriteLine($"La parola più corta è {word2} mentre la più lunga è {word1}");
                }else if (word1.Length < word2.Length)
                {
                    Console.WriteLine($"La parola più corta è {word1} mentre la più lunga è {word2}");
                }else
                {
                    Console.WriteLine("Le parole hanno uguale lunghezza");
                }
            }

            /*------------------------
            Snack 3
            Il software deve chiedere per 10 volte all’utente di inserire un numero.
            Il programma stampa la somma di tutti i numeri inseriti.
            ------------------------*/
            { 
                int[] userNumbers = new int[10];
                int sum = 0;

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Inserisci un numero:");
                    userNumbers[i] = Convert.ToInt32(Console.ReadLine());
                    sum += userNumbers[i];
                }
                Console.WriteLine($"La somma di tutti i numeri inseriti è: {sum}");
            }

            /*------------------------
            Snack 4
            Calcola la somma e la media dei numeri da 2 a 10.
            ------------------------*/
            {
                int[] numbers = [2, 3, 4, 5, 6, 7, 8, 9, 10];
                int sum = 0;
                int avg;
                foreach (int num in numbers)
                {
                    sum += num;
                }
                Console.WriteLine($"La somma dei numeri è {sum}");
                avg = sum / numbers.Length;
                Console.WriteLine($"La media dei numeri è {avg}");
            }

            /*------------------------
            Snack 5
            Il software chiede all’utente di inserire un numero.
            Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
            ------------------------*/
            {
                int number;
                Console.WriteLine("Inserisci un numero");
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine($"Questo è il numero: {number}");
                }
                else
                {
                    Console.WriteLine($"Questo è il numero digitato + 1: {number + 1}");
                }
            }

            /*------------------------
            Snack 6
            In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
            Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
            ------------------------*/
            {
                string[] guests = ["Mirko", "Alessandro", "Davide", "Andrea", "Luigi", "Calin", "Cristopher", "Paolo", "Francesco", "Oder", "Enrico"];
                Console.WriteLine("Come si chiama, Sir?");
                string userName = Console.ReadLine();
                bool isContained = guests.Contains(userName);

                if (isContained)
                {
                    Console.WriteLine($"Buonasera Signor {userName}, prego, può entrare.");
                }
                else
                {
                    Console.WriteLine($"Ehi {userName}, vada via di qui! non è invitato!");
                }
            }

            /*------------------------
            Snack 7
            Crea un array vuoto.
            Chiedi per 6 volte all’utente di inserire un numero,
            se è dispari inseriscilo nell’array.
            ------------------------*/
            { 
                int[] numbers = new int[6];
                int currentIndex = 0;
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("Inserisci un numero");
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    if (userNumber % 2 == 1)
                    {
                        numbers[currentIndex] = userNumber;
                        currentIndex++;
                    }
                }

                Console.WriteLine("Numeri dispari inseriti:");
                for (int i = 0; i < currentIndex; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            /*------------------------
            Snack 8
            Crea un array di numeri interi e fai la somma di tutti
            gli elementi che sono in posizione dispari.
            ------------------------*/
            {
                int[] numbers = [1, 3, 4, 5, 3, 2, 3, 2, 1, 2];
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum += numbers[i];
                    }
                }
                Console.WriteLine($"La somma è {sum}");
            }

            /*------------------------ 
            Snack 9 
            Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
            Continua a chiedere i numeri all’utente e a inserirli nell’array,
            fino a quando la somma degli elementi è minore di 50.
            ------------------------*/
            {
                int[] numbers = new int[50];
                int sum = 0;
                int index = 0;

                Console.WriteLine("Inserisci il primo numero:");
                numbers[index] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[index];
                index++;

                while (sum < 50)
                {
                    Console.WriteLine("Inserisci un altro numero:");
                    numbers[index] = Convert.ToInt32(Console.ReadLine());
                    sum += numbers[index];
                    index++;
                }

                Console.WriteLine($"La somma dei numeri inseriti è maggiore o uguale a 50. Somma {sum}");
                Console.WriteLine("Numeri inseriti:");
                for (int i = 0; i < index; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            /*------------------------  
            Snack 10 
            Fai inserire un numero, che chiameremo N, all’utente.
            Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
            Ogni volta che ne crei uno, stampalo a schermo.
            ------------------------*/
            {
                Console.WriteLine("Inserisci un numero");
                int N = Convert.ToInt32(Console.ReadLine());
                Random random = new Random();
                for (int i = 0; i < N; i++)
                {
                    int[] array = new int[10];

                    for(int j = 0; j < 10; j++)
                    {
                        array[j] = random.Next(1,101);
                    }
                    Console.WriteLine($"Array {i + 1}:");
                    foreach (int number in array)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
