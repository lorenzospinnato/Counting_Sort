using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Counting_Sort cs = new Counting_Sort(); 
            Random r = new Random();
            int s=0; //Intero temporaneo
            int[] vett = new int[10000]; //Viene creato il vettore di 10000 celle
            Console.WriteLine("Ordinando Il Vettore . . . ");
           
            for (int c = 0; c <= 10000; c++)
            {
                for (int i = 0; i < vett.Length; i++) //Viene riempito il vettore con la funzione Random
                {
                    vett[i] = r.Next(0, 99999);
                }
                var watch = System.Diagnostics.Stopwatch.StartNew(); //Avvio del Timer
                {
                    cs.CountingSort(ref vett, 0, 99999); //Ordinamento delle celle tenendo conto del valore minimo e del valore massimo
                }
                watch.Stop(); //Stop del Timer
                var elapsedMs = watch.ElapsedMilliseconds; //Viene salvato in una variabile il Timer
                s = s + Convert.ToInt32(elapsedMs); //Il Timer viene convertito in un intero a 64bit
            }
            
        
            for (int i = 0; i < vett.Length; i++) //Viene stampato il vettore ordinato
            {
                Console.WriteLine("Cella " + i + " : " + vett[i]);
            }
            Console.ReadLine();
            Console.WriteLine("Tempo Medio d'Ordinamento: " + s/1000 + " ms"); //Stampa del Tempo Medio di Esecuzione dell'Algoritmo d'Ordinamento
            Console.ReadLine();
        }
    }
}
