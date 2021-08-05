using System;

namespace Problema_17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] array = GetArray(lenght);

            Console.WriteLine();
            Console.WriteLine("Permutarile sunt");

            Permutari(array, 0, lenght);
        }

        private static int[] GetArray(int lenght)
        {
            int[] array = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                array[i] = i + 1;
            }

            return array;
        }

        public static void Permutari(int[] sol, int k, int n)
        {
            if (k >= n)
            {
                PrintVector(sol, n);
            }
            else
            {
                for (int i = k; i < n; i++)
                {
                    Swap(ref sol[k], ref sol[i]);
                    Permutari(sol, k + 1, n);
                    Swap(ref sol[k], ref sol[i]);
                }
            }
        }

        private static void PrintVector(int[] array, int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
    }
}