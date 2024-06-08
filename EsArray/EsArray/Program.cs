using System.Threading.Channels;

namespace EsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scrivi un programma che definisca un array di interi e calcoli la somma di tutti gli elementi dell'array.

            int[] intArray = new int[] { 1, 2, 3 };

            var sum = 0;    

            foreach (int i in intArray)
            {
                sum += i;   
            }

            Console.WriteLine(sum);

            /*
             * Scrivi un programma che definisca un array di stringhe
             * e cerchi un valore specifico nell'array. 
             * Stampa un messaggio se il valore viene trovato o se non viene trovato.
            */

            string[] arraS = new string[] { "Roma", "Milano", "Firenze", "Torino" };
            var cerca = Console.ReadLine().ToLower().Trim();
            bool trovato = false;

            if(!String.IsNullOrWhiteSpace(cerca))

                for (int i = 0; !trovato && i < arraS.Length; i++)
                {
                    trovato = cerca == arraS[i].ToLower();
                }

            if (trovato )
                Console.WriteLine("complimenti Hai trovato: " + cerca);
            else
                Console.WriteLine("L'elemento cercato non è presente.");

            /*
            * Scrivi un programma che definisca un array di interi 
            * e crei una copia dell'array originale in un nuovo array.
            * 
           */

            int[] arrayInt = new int[] { 1, 2, 3, 4, 5 };
            int[] arrayCopia = new int[arrayInt.Length];

            Array.Copy(arrayInt, arrayCopia, arrayInt.Length);

            foreach (int i in arrayCopia)
            {
                Console.WriteLine(i);
            }

            /* 
             * Scrivi un programma che definisca un array di numeri interi 
             * e li ordini in modo crescente.
             * 
            */

            int[] arrayIntUn = new int[] { 5, 3, 7, 2, 4, 1, 6 };
            Array.Sort(arrayIntUn);
            Console.WriteLine(string.Join(", ", arrayIntUn));

            /* 
             * Scrivi un programma che definisca un array di numeri interi 
             * e trovi il valore massimo presente nell'array.
             * 
            */

            int[] array1 = new int[] { 3, 4, 1, 7, 10, 8, 2, 1 };

            var max = 0;

            foreach (int n in array1 )
            {
                max = Math.Max( max, n );
            }

            Console.WriteLine("Il numero più alto nell'array è: " + max);

            /* 
             * Scrivi un programma che definisca una matrice quadrata di numeri interi 
             * e calcoli la somma degli elementi presenti sulla diagonale principale.
             * 
            */ 

            int[,] matrice = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int sommaDiagonale = 0;

            for (int i = 0; i < matrice.GetLength(0); i++)
            {

                sommaDiagonale += matrice[i, i];
            }

            Console.WriteLine("La somma degli elementi sulla diagonale principale è: " + sommaDiagonale);

            /*
             * Scrivi un programma che definisca una lista di numeri interi 
             * e trovi il valore minimo presente nella lista.
             * 
            */

            int[] array2 = new int[] { 5, 4, 8, 12, 16, 1 };
            int min = array2[0];

            foreach (int n in array2)
            {
                min = Math.Min(min, n );
            }

            Console.WriteLine($"Il numero più piccolo in array è: {min}");

            /*
             * Scrivi un programma che definisca un array di stringhe 
             *  e conti quante volte un valore specifico compare nell'array. 
             * 
            */

            string[] arrayS = new string[] { "Pippo", "Pluto", "Paperino", "Pippo", "Pippo" };
            string nome = "Pippo";
            int count = 0;

            for (int i = 0; i < arrayS.Length; i++)
            {
                if (nome == arrayS[i])
                    count++;
            }

            Console.WriteLine($"Il nome cercato: {nome}, è presente: {count}.");

            /*
             * Scrivi un programma che definisca due array di numeri interi 
             * e li concateni in un nuovo array.
             * 
            */

            int[] array3 = new int[] { 1, 2, 3, 4 };
            int[] array4 = new int[] { 5, 6, 7, 8 };
            
            int[] arrayConcat = array3.Concat(array4).ToArray();
            
            Console.WriteLine($"Array concatenato è uguale a: {String.Join(", ", arrayConcat)}");

            // secondo metodo

            int[] result = new int[array3.Length + array4.Length];

            for (int i = 0; i < array3.Length; i++)
            {
                result[i] = array3[i];
            }

            for (int j = 0; j < array4.Length; j++)
            {
                result[array3.Length + j] = array4[j];
            }

            Console.WriteLine($"Array result è uguale a: {String.Join(", ", result)}");

            /*
             * Scrivi un programma che definisca un array di caratteri 
             * e inverta l'ordine degli elementi nell'array.
             * 
            */

            char[] charNome = new char[] { 'a', 'n', 'd', 'r', 'e', 'a' };

            Array.Reverse(charNome);

            Console.WriteLine($"Array di caratteri al contrario è: {String.Join(", ", charNome)}");

            // metodo due

            char[] charNome1 = new char[] { 'a', 'n', 'd', 'r', 'e', 'a' };
            char[] reverse = new char[charNome1.Length];
            count = 0;

            for (int i = charNome1.Length - 1; i >= 0; i--)
            {
                reverse[count] = charNome1[i];
                count++;
            }

            Console.WriteLine($"Reverse è uguale a: {String.Join(", ", reverse)}");
        }
    }
}
