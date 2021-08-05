using System;

namespace Problema_42
{
    internal class Program
    {

        private static void Main()
        {
            int[] array = { -3, 4, 0, -9, -8, 8, 7, -2, 3, 4, 10, -2 };

            QuickSort(array, 0, array.Length - 1);
            PrintArray(array, array.Length);

            return;
        }

        private static int Partition(int[] array, int start, int end)
        {
            int pivot = end;
            int i = (start - 1);

            for (int j = start; j < end; j++)
            {
                if (array[j] <= array[pivot])
                {
                    i++;

                    int aux = array[i];
                    array[i] = array[j];
                    array[j] = aux;
                }
            }

            int temp = array[i + 1];
            array[i + 1] = array[pivot];
            array[pivot] = temp;

            return (i + 1);
        }

        private static int SelectPartition(int[] array, int start, int end)
        {
            Random rnd = new Random();
            int pivot = rnd.Next(start, end + 1);
            int aux = array[end];
            array[end] = array[pivot];
            array[pivot] = aux;

            return Partition(array, start, end);
        }

        private static void QuickSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int partition = SelectPartition(array, start, end);

                QuickSort(array, start, partition - 1);
                QuickSort(array, partition + 1, end);
            }
        }

        private static void PrintArray(int[] array, int lenght)
        {
            for (int i = 0; i < lenght; ++i)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}