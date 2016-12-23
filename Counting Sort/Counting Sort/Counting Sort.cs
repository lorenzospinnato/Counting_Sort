using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sort
{
    class Counting_Sort:Sorting
    {
        public int[] Sort(int[] vett)
        {
            return vett;
        }

        public void CountingSort(ref int[] data, int min, int max) //Viene preso come parametro il riferimento del vettore, la variabile intero
        {
            int[] count = new int[max - min + 1]; //Viene creato un nuovo vettore di dimensioni (valore massimo - valore minimo + 1)
            int z = 0;

            for (int i = 0; i < count.Length; i++) //Viene riempito il valore tenendo conto delle ripetizioni
            {
                count[i] = 0;
            }
            for (int i = 0; i < data.Length; i++) //Viene riordinato il vettore sommando le volte che il numero è stato ripetuto con il valore della cella precedente
            {
                count[data[i] - min]++;
            }
            for (int i = min; i <= max; i++) //I valori ottenuti vengono spostati in un terzo vettore
            {
                while (count[i - min]-- > 0)
                {
                    data[z] = i;
                    ++z;
                }
            }
        }
    }
}
