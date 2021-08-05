using System;

namespace Problema_12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            int n = 10;

            PrintVector(array, n);

            array = SelectionSort(array, n);

            PrintVector(array, n);
        }

        private static void PrintVector(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        private static int[] SelectionSort(int[] array, int n)
        {
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }

                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }

            return array;
        }
    }
}