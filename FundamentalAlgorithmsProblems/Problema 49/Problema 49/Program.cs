using System;

namespace Problema_49
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = 4;
            int[] array = new int[n + 1];

            GenerareSubmultimi(array, n, 1);
        }

        private static void GenerareSubmultimi(int[] array, int lenght, int position)
        {
            if (position > 0)
            {
                for (int i = 1; i < position; i++)
                {
                    Console.Write(array[i] + " ");
                }

                Console.WriteLine();
            }

            for (int i = array[position - 1] + 1; i <= lenght; i++)
            {
                array[position] = i;
                GenerareSubmultimi(array, lenght, position + 1);
            }
        }
    }
}