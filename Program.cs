using System;

namespace sort_insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 230, 45, 345, 4, 324, 90, 76, 34, 67, 11 };
            Console.WriteLine("######## Ordenação com Insertion Sort ########\n");
            Console.WriteLine("Array original\n");
            foreach (int numero in numeros)
                Console.Write($"{numero} ");
            Console.WriteLine("\n\nOrdenando o array usando Insertion Short\n");
            int[] arrayOrdenado = IntArrayInsertionSort(numeros);
            Console.WriteLine("Array Ordenado\n");
            foreach (int numero in arrayOrdenado)
                Console.Write($"{numero} ");
            Console.ReadLine();
        }
        public static int[] IntArrayInsertionSort(int[] data)
        {
            int i, j;
            int N = data.Length;
            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    TrocarValores(data, i, i - 1);
                }
            }
            return data;
        }

        public static int[] TrocarValores(int[] arrayDados, int m, int n)
        {
            int temp;
            temp = arrayDados[m];
            arrayDados[m] = arrayDados[n];
            arrayDados[n] = temp;
            return arrayDados;
        }
    }
}