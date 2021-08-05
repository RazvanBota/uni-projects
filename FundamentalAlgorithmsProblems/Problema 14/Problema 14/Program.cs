using System;

namespace Problema_14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            PrintVector(array);

            InsertionSort(array);
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

        private static void InsertionSort(int[] array)
        {
            for (int index = 1; index < array.Length; index++)
            {
                int key = array[index];
                int pivot = index - 1;

                while (pivot >= 0 && array[pivot] > key)
                {
                    array[pivot + 1] = array[pivot];
                    pivot--;
                }

                array[pivot + 1] = key;
            }
        }
    }
}