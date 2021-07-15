//Scrivere un programma che permetta all'utente di creare la sua lista della spesa.

//Si chiede all'utente quanti prodotti vuole inserire nell'elenco. (numero intero valido e positivo).
//Quindi si chiede all'utete di inserire i prodotti (esempio "uova", "pasta"..).
//Non si possono inserire 2 prodotti uguali.
//(Opzionale: "uova", "UOVA", "Uova" sono da intendersi uguali, quindi no-case-sensitive)

//Se l'utente inserisce un prodotto già presente, gli si mostra un messaggio del tipo "prodotto già inserito".
//Completato l'elenco della spesa, stampare un riepilogo con tutti i prodotti che ha inserito l'utente.

//Requisiti: utilizzare un array (non una lista). Utilizzare le routine (es. ScriviListaSpesa e StampaListaSpesa)

//Opzionale. Stampare la lista della spesa su un file "listaSpesa.txt" invece che a video.


using System;
using System.IO;

//toDo inserire scrittura su file

namespace Esercizio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            
        
            do
            {
                Console.WriteLine("Quanti elementi vuoi inserire nella lista?");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            string[] lista = new string[n];

            ScriviLista(ref lista, ref n);
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("\nEcco la lista della spesa\n");
            StampaLista(ref lista, ref n);

        }

        private static void StampaLista(ref string[] lista, ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{lista[i]}");
               

            }
        }

        private static void ScriviLista(ref string[] lista, ref int n)
        {
            StreamWriter sw = new StreamWriter(@"listaSpesa.txt");


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1}° elemento nella lista: ");
                string prodotto = Console.ReadLine().ToUpper();

                int found = Array.IndexOf(lista, prodotto);

                if (found > -1)
                {
                    Console.WriteLine($"Hai già inserito {prodotto}: ");
                    i--;
                }
                else
                {
                    lista[i] = prodotto;
                }
               
            }
        }
    }
}