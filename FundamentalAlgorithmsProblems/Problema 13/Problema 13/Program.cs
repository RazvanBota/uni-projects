using System;

namespace Problema_13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            PrintVector(array);

            DirectSelection(array);
            PrintVector(array);
        }

        private static void PrintVector(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        private static void DirectSelection(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
        }
    }
}